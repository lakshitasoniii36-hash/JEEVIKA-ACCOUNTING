using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;

namespace Backend
{
    [ApiController]
    [Route("api/opening-balances")]
    public class OpeningBalancesController : ControllerBase
    {
        private readonly string _sqliteDbPath = System.IO.Path.Combine(System.AppContext.BaseDirectory, "Data", "ShreeRam.sqlite");

        public class LedgerBalanceRow
        {
            public string Type { get; set; }
            public string Code { get; set; }
            public string Name { get; set; }
            public decimal Dr { get; set; }
            public decimal Cr { get; set; }
            public decimal PDr { get; set; }
            public decimal PCr { get; set; }
        }

        public class MemberBalanceRow
        {
            public string Type { get; set; }
            public string Code { get; set; }
            public string Name { get; set; }
            public double Prin { get; set; }
            public double Int { get; set; }
            public double Total { get; set; }
        }

        private SqliteConnection GetConn()
        {
            var cs = new SqliteConnectionStringBuilder { DataSource = _sqliteDbPath, Mode = SqliteOpenMode.ReadWriteCreate }.ToString();
            return new SqliteConnection(cs);
        }

        private string GetStringSafe(SqliteDataReader r, string col1, string col2)
        {
            try
            {
                int idx = r.GetOrdinal(col1);
                return r.IsDBNull(idx) ? "" : r.GetValue(idx).ToString();
            }
            catch
            {
                try
                {
                    int idx = r.GetOrdinal(col2);
                    return r.IsDBNull(idx) ? "" : r.GetValue(idx).ToString();
                }
                catch
                {
                    return "";
                }
            }
        }

        private int GetIntSafe(SqliteDataReader r, string col1, string col2)
        {
            try
            {
                int idx = r.GetOrdinal(col1);
                return r.IsDBNull(idx) ? 0 : Convert.ToInt32(r.GetValue(idx));
            }
            catch
            {
                try
                {
                    int idx = r.GetOrdinal(col2);
                    return r.IsDBNull(idx) ? 0 : Convert.ToInt32(r.GetValue(idx));
                }
                catch
                {
                    return 0;
                }
            }
        }

        [HttpGet("ledger")]
        public IActionResult GetLedgerBalances([FromQuery] string category)
        {
            try
            {
                if (string.IsNullOrEmpty(category))
                {
                    category = "BS";
                }
                category = category.ToUpper().Trim();

                using var conn = GetConn();
                conn.Open();

                // Fetch groups to establish sorting and categorizing
                var groups = new Dictionary<int, (string Name, string Code, int MainId)>();
                using (var gCmd = conn.CreateCommand())
                {
                    gCmd.CommandText = "SELECT SocGroupId, GrpName, GrpCode, GrpMainId FROM SocGroup";
                    using var gr = gCmd.ExecuteReader();
                    while (gr.Read())
                    {
                        int id = Convert.ToInt32(gr["SocGroupId"]);
                        groups[id] = (
                            gr["GrpName"]?.ToString() ?? "",
                            gr["GrpCode"]?.ToString() ?? "",
                            gr["GrpMainId"] != DBNull.Value ? Convert.ToInt32(gr["GrpMainId"]) : 0
                        );
                    }
                }

                // Query accounts
                var accounts = new List<(int Id, string Code, string Name, decimal OpBal, decimal PrBal, int GroupId, int MainId, string OpDrCr, string PrDrCr)>();
                using (var aCmd = conn.CreateCommand())
                {
                    aCmd.CommandText = "SELECT SocAccId, AccCode, AccName, Op_Bal, Pr_Bal, SocSubGroupId, GrpMainId, OpDrCr, PrDrCr FROM SocAccount WHERE IsDeleted = 0";
                    using var ar = aCmd.ExecuteReader();
                    while (ar.Read())
                    {
                        accounts.Add((
                            Convert.ToInt32(ar["SocAccId"]),
                            ar["AccCode"]?.ToString() ?? "",
                            ar["AccName"]?.ToString() ?? "",
                            ar["Op_Bal"] != DBNull.Value ? Convert.ToDecimal(ar["Op_Bal"]) : 0,
                            ar["Pr_Bal"] != DBNull.Value ? Convert.ToDecimal(ar["Pr_Bal"]) : 0,
                            ar["SocSubGroupId"] != DBNull.Value ? Convert.ToInt32(ar["SocSubGroupId"]) : 0,
                            ar["GrpMainId"] != DBNull.Value ? Convert.ToInt32(ar["GrpMainId"]) : 0,
                            ar["OpDrCr"]?.ToString() ?? "Dr.",
                            ar["PrDrCr"]?.ToString() ?? "Dr."
                        ));
                    }
                }

                var list = new List<object>();

                if (category == "BS")
                {
                    // Balance Sheet (Assets = 1, Liabilities = 2)
                    // We group accounts by parent SocSubGroupId
                    var grouped = new Dictionary<int, List<object>>();
                    foreach (var acc in accounts)
                    {
                        if (acc.MainId == 1 || acc.MainId == 2)
                        {
                            if (!grouped.ContainsKey(acc.GroupId))
                                grouped[acc.GroupId] = new List<object>();

                            decimal dr = acc.OpBal >= 0 ? acc.OpBal : 0;
                            decimal cr = acc.OpBal < 0 ? -acc.OpBal : 0;

                            grouped[acc.GroupId].Add(new
                            {
                                type = "row",
                                id = acc.Id,
                                code = acc.Code,
                                name = acc.Name,
                                dr = dr,
                                cr = cr
                            });
                        }
                    }

                    // Sort groups: Assets first, then Liabilities, then alphabetically or by GrpCode
                    var sortedGroupIds = new List<int>(grouped.Keys);
                    sortedGroupIds.Sort((x, y) =>
                    {
                        var gx = groups.ContainsKey(x) ? groups[x] : (Name: "", Code: "", MainId: 99);
                        var gy = groups.ContainsKey(y) ? groups[y] : (Name: "", Code: "", MainId: 99);

                        // Primary sort by GrpMainId (1 before 2)
                        int cmp = gx.MainId.CompareTo(gy.MainId);
                        if (cmp != 0) return cmp;

                        // Secondary sort by GrpCode
                        cmp = string.Compare(gx.Code, gy.Code, StringComparison.OrdinalIgnoreCase);
                        if (cmp != 0) return cmp;

                        return string.Compare(gx.Name, gy.Name, StringComparison.OrdinalIgnoreCase);
                    });

                    foreach (var grpId in sortedGroupIds)
                    {
                        var grp = groups.ContainsKey(grpId) ? groups[grpId] : (Name: "Others", Code: "", MainId: 1);
                        string section = grp.MainId == 1 ? "Assets" : "Liabilities";
                        string prefix = string.IsNullOrEmpty(grp.Code) ? "" : $"{grp.Code}.";
                        string headerName = $"({section}) {prefix}{grp.Name.ToUpper()}";

                        list.Add(new { type = "header", name = headerName });

                        decimal sumDr = 0;
                        decimal sumCr = 0;

                        // Sort accounts within group by Code
                        var grpAccounts = grouped[grpId];
                        grpAccounts.Sort((x, y) => {
                            dynamic dx = x;
                            dynamic dy = y;
                            return string.Compare(dx.code, dy.code, StringComparison.OrdinalIgnoreCase);
                        });

                        foreach (dynamic row in grpAccounts)
                        {
                            list.Add(row);
                            sumDr += (decimal)row.dr;
                            sumCr += (decimal)row.cr;
                        }

                        list.Add(new
                        {
                            type = "total",
                            name = $"Total: {grp.Name.ToUpper()}",
                            debit = sumDr,
                            credit = sumCr
                        });
                    }
                }
                else if (category == "IE")
                {
                    // Income & Expenditure (Income = 3, Expenditure = 4)
                    var grouped = new Dictionary<int, List<object>>();
                    foreach (var acc in accounts)
                    {
                        if (acc.MainId == 3 || acc.MainId == 4)
                        {
                            if (!grouped.ContainsKey(acc.GroupId))
                                grouped[acc.GroupId] = new List<object>();

                            decimal pDr = acc.PrBal >= 0 ? acc.PrBal : 0;
                            decimal pCr = acc.PrBal < 0 ? -acc.PrBal : 0;

                            grouped[acc.GroupId].Add(new
                            {
                                type = "row",
                                id = acc.Id,
                                code = acc.Code,
                                name = acc.Name,
                                pDr = pDr,
                                pCr = pCr
                            });
                        }
                    }

                    // Sort groups: Income first (3), then Expense (4)
                    var sortedGroupIds = new List<int>(grouped.Keys);
                    sortedGroupIds.Sort((x, y) =>
                    {
                        var gx = groups.ContainsKey(x) ? groups[x] : (Name: "", Code: "", MainId: 99);
                        var gy = groups.ContainsKey(y) ? groups[y] : (Name: "", Code: "", MainId: 99);

                        // Primary sort by GrpMainId (3 before 4)
                        int cmp = gx.MainId.CompareTo(gy.MainId);
                        if (cmp != 0) return cmp;

                        // Secondary sort by GrpCode
                        cmp = string.Compare(gx.Code, gy.Code, StringComparison.OrdinalIgnoreCase);
                        if (cmp != 0) return cmp;

                        return string.Compare(gx.Name, gy.Name, StringComparison.OrdinalIgnoreCase);
                    });

                    foreach (var grpId in sortedGroupIds)
                    {
                        var grp = groups.ContainsKey(grpId) ? groups[grpId] : (Name: "Others", Code: "", MainId: 3);
                        string section = grp.MainId == 3 ? "Income" : "Expense";
                        string prefix = string.IsNullOrEmpty(grp.Code) ? "" : $"{grp.Code}.";
                        string headerName = $"({section}) {prefix}{grp.Name.ToUpper()}";

                        list.Add(new { type = "header", name = headerName });

                        decimal sumDr = 0;
                        decimal sumCr = 0;

                        // Sort accounts by Code
                        var grpAccounts = grouped[grpId];
                        grpAccounts.Sort((x, y) => {
                            dynamic dx = x;
                            dynamic dy = y;
                            return string.Compare(dx.code, dy.code, StringComparison.OrdinalIgnoreCase);
                        });

                        foreach (dynamic row in grpAccounts)
                        {
                            list.Add(row);
                            sumDr += (decimal)row.pDr;
                            sumCr += (decimal)row.pCr;
                        }

                        list.Add(new
                        {
                            type = "total",
                            name = $"Total: {grp.Name.ToUpper()}",
                            pDr = sumDr,
                            pCr = sumCr
                        });
                    }
                }

                return Ok(new { success = true, data = list });
            }
            catch (Exception ex)
            {
                return Ok(new { success = false, message = ex.Message });
            }
        }

        [HttpPost("ledger")]
        public IActionResult SaveLedgerBalances([FromQuery] string category, [FromBody] List<LedgerBalanceRow> rows)
        {
            try
            {
                if (string.IsNullOrEmpty(category)) return BadRequest(new { success = false, message = "Category required" });
                category = category.ToUpper().Trim();

                if (rows == null) return BadRequest(new { success = false, message = "Invalid data rows" });

                using var conn = GetConn();
                conn.Open();
                using var trans = conn.BeginTransaction();

                try
                {
                    // 1. Reset all balances for this category in DB to handle deletions
                    if (category == "BS")
                    {
                        using var resetCmd = conn.CreateCommand();
                        resetCmd.Transaction = trans;
                        resetCmd.CommandText = "UPDATE SocAccount SET Op_Bal = 0, OpDrCr = 'Dr.' WHERE GrpMainId IN (1, 2)";
                        resetCmd.ExecuteNonQuery();
                    }
                    else if (category == "IE")
                    {
                        using var resetCmd = conn.CreateCommand();
                        resetCmd.Transaction = trans;
                        resetCmd.CommandText = "UPDATE SocAccount SET Pr_Bal = 0, PrDrCr = 'Dr.' WHERE GrpMainId IN (3, 4)";
                        resetCmd.ExecuteNonQuery();
                    }

                    // Fetch default group ids to use if inserting new accounts
                    int defaultAssetGrpId = GetGroupIdByName(conn, trans, "Current Assets");
                    int defaultLiabGrpId = GetGroupIdByName(conn, trans, "Current Liabilities & Provisions");
                    int defaultIncomeGrpId = GetGroupIdByName(conn, trans, "Other Sources");
                    int defaultExpenseGrpId = GetGroupIdByName(conn, trans, "Others");

                    // 2. Loop and update modified accounts
                    foreach (var row in rows)
                    {
                        if (row.Type != "row" || string.IsNullOrWhiteSpace(row.Code)) continue;

                        // Check if account exists
                        bool exists = false;
                        using (var chkCmd = conn.CreateCommand())
                        {
                            chkCmd.Transaction = trans;
                            chkCmd.CommandText = "SELECT COUNT(*) FROM SocAccount WHERE TRIM(UPPER(AccCode)) = TRIM(UPPER(@code))";
                            chkCmd.Parameters.AddWithValue("@code", row.Code.Trim());
                            exists = Convert.ToInt32(chkCmd.ExecuteScalar()) > 0;
                        }

                        if (exists)
                        {
                            using var updCmd = conn.CreateCommand();
                            updCmd.Transaction = trans;
                            if (category == "BS")
                            {
                                decimal opBal = row.Dr - row.Cr;
                                updCmd.CommandText = "UPDATE SocAccount SET Op_Bal = @bal, OpDrCr = @drcr WHERE TRIM(UPPER(AccCode)) = TRIM(UPPER(@code))";
                                updCmd.Parameters.AddWithValue("@bal", opBal);
                                updCmd.Parameters.AddWithValue("@drcr", opBal < 0 ? "Cr." : "Dr.");
                                updCmd.Parameters.AddWithValue("@code", row.Code.Trim());
                            }
                            else if (category == "IE")
                            {
                                decimal prBal = row.PDr - row.PCr;
                                updCmd.CommandText = "UPDATE SocAccount SET Pr_Bal = @bal, PrDrCr = @drcr WHERE TRIM(UPPER(AccCode)) = TRIM(UPPER(@code))";
                                updCmd.Parameters.AddWithValue("@bal", prBal);
                                updCmd.Parameters.AddWithValue("@drcr", prBal < 0 ? "Cr." : "Dr.");
                                updCmd.Parameters.AddWithValue("@code", row.Code.Trim());
                            }
                            updCmd.ExecuteNonQuery();
                        }
                        else
                        {
                            // Auto create new account since it was added dynamically in grid
                            int grpId = 0;
                            int mainId = 0;

                            if (category == "BS")
                            {
                                if (row.Dr >= row.Cr)
                                {
                                    grpId = defaultAssetGrpId;
                                    mainId = 1;
                                }
                                else
                                {
                                    grpId = defaultLiabGrpId;
                                    mainId = 2;
                                }
                            }
                            else
                            {
                                if (row.PDr >= row.PCr)
                                {
                                    grpId = defaultExpenseGrpId;
                                    mainId = 4;
                                }
                                else
                                {
                                    grpId = defaultIncomeGrpId;
                                    mainId = 3;
                                }
                            }

                            decimal opBal = category == "BS" ? (row.Dr - row.Cr) : 0;
                            decimal prBal = category == "IE" ? (row.PDr - row.PCr) : 0;

                            using var insCmd = conn.CreateCommand();
                            insCmd.Transaction = trans;
                            insCmd.CommandText = @"INSERT INTO SocAccount(AccCode,AccName,AccName1,AccName2,
                                SocSubGroupId,SocGroupId,GrpMainId,SocAccountType,
                                Op_Bal,Cl_Bal,Pr_Bal,OpDrCr,PrDrCr,IsDeleted)
                                VALUES(@code,@name,@name,@name,@grpId,@grpId,@mainId,1,@opBal,@opBal,@prBal,@opDrCr,@prDrCr,0)";
                            
                            insCmd.Parameters.AddWithValue("@code", row.Code.Trim());
                            insCmd.Parameters.AddWithValue("@name", row.Name.Trim());
                            insCmd.Parameters.AddWithValue("@grpId", grpId);
                            insCmd.Parameters.AddWithValue("@mainId", mainId);
                            insCmd.Parameters.AddWithValue("@opBal", opBal);
                            insCmd.Parameters.AddWithValue("@prBal", prBal);
                            insCmd.Parameters.AddWithValue("@opDrCr", opBal < 0 ? "Cr." : "Dr.");
                            insCmd.Parameters.AddWithValue("@prDrCr", prBal < 0 ? "Cr." : "Dr.");
                            
                            insCmd.ExecuteNonQuery();
                        }
                    }

                    trans.Commit();
                    return Ok(new { success = true, message = "Balances updated successfully." });
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    return Ok(new { success = false, message = "Database transaction failed: " + ex.Message });
                }
            }
            catch (Exception ex)
            {
                return Ok(new { success = false, message = ex.Message });
            }
        }

        [HttpGet("member")]
        public IActionResult GetMemberBalances([FromQuery] string billType)
        {
            try
            {
                if (string.IsNullOrEmpty(billType)) billType = "Maintenance";

                using var conn = GetConn();
                conn.Open();

                // Inspect SocMember schema
                var columns = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
                using (var schemaCmd = conn.CreateCommand())
                {
                    schemaCmd.CommandText = "PRAGMA table_info(SocMember)";
                    using var sr = schemaCmd.ExecuteReader();
                    while (sr.Read())
                    {
                        columns.Add(sr["name"]?.ToString() ?? "");
                    }
                }

                string idCol = columns.Contains("SocMemberId") ? "SocMemberId" : (columns.Contains("SocMemId") ? "SocMemId" : "rowid");
                string codeCol = columns.Contains("MemberCode") ? "MemberCode" : (columns.Contains("MemCode") ? "MemCode" : null);
                string nameCol = columns.Contains("MemberName") ? "MemberName" : (columns.Contains("MemName") ? "MemName" : null);

                if (codeCol == null || nameCol == null)
                {
                    return Ok(new { success = false, message = "SocMember table is missing required code/name columns." });
                }

                string whereClause = columns.Contains("IsDeleted") ? "WHERE IsDeleted = 0" : "";
                
                string orderBy = "";
                if (columns.Contains("FlatNo"))
                {
                    orderBy = $"ORDER BY FlatNo, {nameCol}";
                }
                else
                {
                    orderBy = $"ORDER BY {nameCol}";
                }

                // Fetch members
                var membersList = new List<(int Id, string Code, string Name)>();
                using (var mCmd = conn.CreateCommand())
                {
                    mCmd.CommandText = $"SELECT {idCol} AS MemberId, {codeCol} AS MemberCode, {nameCol} AS MemberName FROM SocMember {whereClause} {orderBy}";
                    try
                    {
                        using var mr = mCmd.ExecuteReader();
                        while (mr.Read())
                        {
                            int id = Convert.ToInt32(mr["MemberId"]);
                            string code = mr["MemberCode"]?.ToString() ?? "";
                            string name = mr["MemberName"]?.ToString() ?? "";
                            if (!string.IsNullOrEmpty(code))
                            {
                                membersList.Add((id, code, name));
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        return Ok(new { success = false, message = "Failed to query members: " + ex.Message });
                    }
                }

                // Fetch member balances for this bill type
                var balances = new Dictionary<string, (double Prin, double Int)>();
                using (var bCmd = conn.CreateCommand())
                {
                    bCmd.CommandText = "SELECT MemberCode, Op_Prin, Op_Int FROM SocMemberOpeningBalance WHERE BillType = @billType";
                    bCmd.Parameters.AddWithValue("@billType", billType);
                    try
                    {
                        using var br = bCmd.ExecuteReader();
                        while (br.Read())
                        {
                            string code = br["MemberCode"]?.ToString() ?? "";
                            double prin = br["Op_Prin"] != DBNull.Value ? Convert.ToDouble(br["Op_Prin"]) : 0;
                            double inte = br["Op_Int"] != DBNull.Value ? Convert.ToDouble(br["Op_Int"]) : 0;
                            balances[code] = (prin, inte);
                        }
                    }
                    catch { } // Table might be empty, no problem
                }

                var list = new List<object>();
                list.Add(new { type = "header", name = "1. MEMBER OUTSTANDING BALANCES" });

                double sumPrin = 0;
                double sumInt = 0;

                foreach (var mem in membersList)
                {
                    double prin = 0;
                    double inte = 0;
                    if (balances.ContainsKey(mem.Code))
                    {
                        prin = balances[mem.Code].Prin;
                        inte = balances[mem.Code].Int;
                    }
                    else if (billType == "Maintenance")
                    {
                        // Fallback: If Maintenance and not in our split table, check if SocMember has values
                        using var fbCmd = conn.CreateCommand();
                        fbCmd.CommandText = $"SELECT Op_Prin, Op_Int FROM SocMember WHERE {idCol} = @id";
                        fbCmd.Parameters.AddWithValue("@id", mem.Id);
                        using var fbr = fbCmd.ExecuteReader();
                        if (fbr.Read())
                        {
                            prin = fbr["Op_Prin"] != DBNull.Value ? Convert.ToDouble(fbr["Op_Prin"]) : 0;
                            inte = fbr["Op_Int"] != DBNull.Value ? Convert.ToDouble(fbr["Op_Int"]) : 0;
                        }
                    }

                    double tot = prin + inte;
                    list.Add(new
                    {
                        type = "row",
                        id = mem.Id,
                        code = mem.Code,
                        name = mem.Name,
                        prin = prin,
                        @int = inte,
                        total = tot
                    });

                    sumPrin += prin;
                    sumInt += inte;
                }

                list.Add(new
                {
                    type = "total",
                    name = "Total: MEMBER OUTSTANDING BALANCES",
                    prin = sumPrin,
                    @int = sumInt,
                    total = sumPrin + sumInt
                });

                return Ok(new { success = true, data = list });
            }
            catch (Exception ex)
            {
                return Ok(new { success = false, message = ex.Message });
            }
        }

        [HttpPost("member")]
        public IActionResult SaveMemberBalances([FromQuery] string billType, [FromBody] List<MemberBalanceRow> rows)
        {
            try
            {
                if (string.IsNullOrEmpty(billType)) billType = "Maintenance";
                if (rows == null) return BadRequest(new { success = false, message = "Invalid data rows" });

                using var conn = GetConn();
                conn.Open();

                // Inspect SocMember schema
                var columns = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
                using (var schemaCmd = conn.CreateCommand())
                {
                    schemaCmd.CommandText = "PRAGMA table_info(SocMember)";
                    using var sr = schemaCmd.ExecuteReader();
                    while (sr.Read())
                    {
                        columns.Add(sr["name"]?.ToString() ?? "");
                    }
                }
                string codeCol = columns.Contains("MemberCode") ? "MemberCode" : (columns.Contains("MemCode") ? "MemCode" : null);

                using var trans = conn.BeginTransaction();

                try
                {
                    // 1. Delete all existing member balances for this bill type
                    using (var delCmd = conn.CreateCommand())
                    {
                        delCmd.Transaction = trans;
                        delCmd.CommandText = "DELETE FROM SocMemberOpeningBalance WHERE BillType = @billType";
                        delCmd.Parameters.AddWithValue("@billType", billType);
                        delCmd.ExecuteNonQuery();
                    }

                    // If billType is Maintenance, also clear out SocMember table balances
                    if (billType == "Maintenance")
                    {
                        using var resetCmd = conn.CreateCommand();
                        resetCmd.Transaction = trans;
                        resetCmd.CommandText = "UPDATE SocMember SET Op_Prin = 0, Op_Int = 0";
                        resetCmd.ExecuteNonQuery();
                    }

                    // 2. Loop and insert new balances
                    foreach (var row in rows)
                    {
                        if (row.Type != "row" || string.IsNullOrWhiteSpace(row.Code)) continue;

                        using var insCmd = conn.CreateCommand();
                        insCmd.Transaction = trans;
                        insCmd.CommandText = @"INSERT INTO SocMemberOpeningBalance(MemberCode, BillType, Op_Prin, Op_Int)
                            VALUES(@code, @billType, @prin, @int)";
                        insCmd.Parameters.AddWithValue("@code", row.Code.Trim());
                        insCmd.Parameters.AddWithValue("@billType", billType);
                        insCmd.Parameters.AddWithValue("@prin", row.Prin);
                        insCmd.Parameters.AddWithValue("@int", row.Int);
                        insCmd.ExecuteNonQuery();

                        // If billType is Maintenance, also update the main SocMember table columns
                        if (billType == "Maintenance" && !string.IsNullOrEmpty(codeCol))
                        {
                            using var updCmd = conn.CreateCommand();
                            updCmd.Transaction = trans;
                            updCmd.CommandText = $@"UPDATE SocMember 
                                SET Op_Prin = @prin, Op_Int = @int 
                                WHERE TRIM(UPPER({codeCol})) = TRIM(UPPER(@code))";
                            updCmd.Parameters.AddWithValue("@prin", row.Prin);
                            updCmd.Parameters.AddWithValue("@int", row.Int);
                            updCmd.Parameters.AddWithValue("@code", row.Code.Trim());
                            updCmd.ExecuteNonQuery();
                        }
                    }

                    trans.Commit();
                    return Ok(new { success = true, message = "Member balances updated successfully." });
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    return Ok(new { success = false, message = "Database transaction failed: " + ex.Message });
                }
            }
            catch (Exception ex)
            {
                return Ok(new { success = false, message = ex.Message });
            }
        }

        private int GetGroupIdByName(SqliteConnection conn, SqliteTransaction trans, string name)
        {
            using var cmd = conn.CreateCommand();
            cmd.Transaction = trans;
            cmd.CommandText = "SELECT SocGroupId FROM SocGroup WHERE TRIM(UPPER(GrpName)) = TRIM(UPPER(@name)) LIMIT 1";
            cmd.Parameters.AddWithValue("@name", name);
            var result = cmd.ExecuteScalar();
            return result != null && result != DBNull.Value ? Convert.ToInt32(result) : 0;
        }
    }
}
