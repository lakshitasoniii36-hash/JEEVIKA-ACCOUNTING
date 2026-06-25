using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;

namespace Backend
{
    [ApiController]
    [Route("api/billing-master")]
    public class BillingMasterController : ControllerBase
    {
        private readonly string _sqliteDbPath = System.IO.Path.Combine(System.AppContext.BaseDirectory, "Data", "ShreeRam.sqlite");

        public class BillingMatrixRow
        {
            public string MemNo { get; set; }
            public string Wing { get; set; }
            public string Name { get; set; }
            public double Sqft { get; set; }
            public double Op_Prin { get; set; }
            public double Op_Int { get; set; }
            public Dictionary<string, double> Amounts { get; set; } = new Dictionary<string, double>();
            public bool Checked { get; set; }
        }

        public class MatrixSettingsModel
        {
            public string BillType { get; set; }
            public string GstCalc { get; set; }
            public string InterestCalc { get; set; }
        }

        private SqliteConnection GetConn()
        {
            var cs = new SqliteConnectionStringBuilder { DataSource = _sqliteDbPath, Mode = SqliteOpenMode.ReadWriteCreate }.ToString();
            return new SqliteConnection(cs);
        }

        [HttpGet]
        public IActionResult GetMatrix([FromQuery] string billType)
        {
            try
            {
                if (string.IsNullOrEmpty(billType)) billType = "Maintenance";

                using var conn = GetConn();
                conn.Open();

                // 1. Inspect SocMember schema
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
                string wingCol = columns.Contains("Wing") ? "Wing" : null;
                string flatCol = columns.Contains("FlatNo") ? "FlatNo" : null;
                string sqftCol = columns.Contains("Sqft") ? "Sqft" : null;

                if (codeCol == null || nameCol == null)
                {
                    return Ok(new { success = false, message = "SocMember table is missing required code/name columns." });
                }

                // Query all members
                var membersList = new List<BillingMatrixRow>();
                string selWing = wingCol != null ? wingCol : "''";
                string selFlat = flatCol != null ? flatCol : "''";
                string selSqft = sqftCol != null ? sqftCol : "0";
                string whereClause = columns.Contains("IsDeleted") ? "WHERE m.IsDeleted = 0" : "";

                using (var mCmd = conn.CreateCommand())
                {
                    mCmd.CommandText = $@"SELECT m.{idCol} AS MemberId, m.{codeCol} AS MemberCode, m.{nameCol} AS MemberName, 
                                        m.{selWing} AS Wing, m.{selFlat} AS FlatNo, m.{selSqft} AS Sqft, 
                                        COALESCE(b.Op_Prin, 0) AS Op_Prin, COALESCE(b.Op_Int, 0) AS Op_Int 
                                        FROM SocMember m 
                                        LEFT JOIN SocMemberOpeningBalance b ON m.{codeCol} = b.MemberCode AND b.BillType = @bt 
                                        {whereClause}";
                    mCmd.Parameters.AddWithValue("@bt", billType);
                    
                    using var mr = mCmd.ExecuteReader();
                    while (mr.Read())
                    {
                        var row = new BillingMatrixRow
                        {
                            MemNo = mr["MemberCode"]?.ToString() ?? "",
                            Wing = mr["Wing"]?.ToString() ?? "",
                            Name = mr["MemberName"]?.ToString() ?? "",
                            Sqft = mr["Sqft"] != DBNull.Value ? Convert.ToDouble(mr["Sqft"]) : 0,
                            Op_Prin = mr["Op_Prin"] != DBNull.Value ? Convert.ToDouble(mr["Op_Prin"]) : 0,
                            Op_Int = mr["Op_Int"] != DBNull.Value ? Convert.ToDouble(mr["Op_Int"]) : 0,
                            Checked = false
                        };
                        membersList.Add(row);
                    }
                }

                // Query matrix head adjustments
                using (var aCmd = conn.CreateCommand())
                {
                    aCmd.CommandText = "SELECT MemberCode, LedgerCode, Amount FROM SocBillingMatrix WHERE BillType = @bt";
                    aCmd.Parameters.AddWithValue("@bt", billType);
                    using var ar = aCmd.ExecuteReader();
                    while (ar.Read())
                      {
                        string memCode = ar["MemberCode"]?.ToString() ?? "";
                        string ledger = ar["LedgerCode"]?.ToString() ?? "";
                        double amt = ar["Amount"] != DBNull.Value ? Convert.ToDouble(ar["Amount"]) : 0;

                        var match = membersList.Find(m => string.Equals(m.MemNo.Trim(), memCode.Trim(), StringComparison.OrdinalIgnoreCase));
                        if (match != null)
                        {
                            match.Amounts[ledger] = amt;
                        }
                    }
                }

                return Ok(new { success = true, data = membersList });
            }
            catch (Exception ex)
            {
                return Ok(new { success = false, message = ex.Message });
            }
        }

        [HttpPost]
        public IActionResult SaveMatrix([FromQuery] string billType, [FromBody] List<BillingMatrixRow> rows)
        {
            try
            {
                if (string.IsNullOrEmpty(billType)) billType = "Maintenance";
                if (rows == null) return BadRequest(new { success = false, message = "No data rows provided" });

                using var conn = GetConn();
                conn.Open();
                using var trans = conn.BeginTransaction();

                try
                {
                    // Clean adjustments for this bill type
                    using (var delCmd = conn.CreateCommand())
                    {
                        delCmd.Transaction = trans;
                        delCmd.CommandText = "DELETE FROM SocBillingMatrix WHERE BillType = @bt";
                        delCmd.Parameters.AddWithValue("@bt", billType);
                        delCmd.ExecuteNonQuery();
                    }

                    // Insert adjustments
                    foreach (var row in rows)
                      {
                        if (string.IsNullOrWhiteSpace(row.MemNo) || row.Amounts == null) continue;

                        foreach (var kvp in row.Amounts)
                        {
                            if (kvp.Value == 0) continue; // Skip zero values to save DB space

                            using var insCmd = conn.CreateCommand();
                            insCmd.Transaction = trans;
                            insCmd.CommandText = @"INSERT INTO SocBillingMatrix (MemberCode, BillType, LedgerCode, Amount)
                                VALUES(@mc, @bt, @lc, @amt)";
                            insCmd.Parameters.AddWithValue("@mc", row.MemNo.Trim());
                            insCmd.Parameters.AddWithValue("@bt", billType);
                            insCmd.Parameters.AddWithValue("@lc", kvp.Key);
                            insCmd.Parameters.AddWithValue("@amt", kvp.Value);
                            insCmd.ExecuteNonQuery();
                        }
                    }

                    trans.Commit();
                    return Ok(new { success = true, message = "Billing adjustments saved successfully." });
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    return Ok(new { success = false, message = "Database save failed: " + ex.Message });
                }
            }
            catch (Exception ex)
            {
                return Ok(new { success = false, message = ex.Message });
            }
        }

        [HttpGet("settings")]
        public IActionResult GetSettings([FromQuery] string billType)
        {
            try
            {
                if (string.IsNullOrEmpty(billType)) billType = "Maintenance";

                using var conn = GetConn();
                conn.Open();

                using var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT GstCalc, InterestCalc FROM SocBillingMatrixSettings WHERE BillType = @bt";
                cmd.Parameters.AddWithValue("@bt", billType);

                using var r = cmd.ExecuteReader();
                if (r.Read())
                {
                    return Ok(new
                    {
                        success = true,
                        data = new MatrixSettingsModel
                        {
                            BillType = billType,
                            GstCalc = r["GstCalc"]?.ToString() ?? "MANUAL",
                            InterestCalc = r["InterestCalc"]?.ToString() ?? "MANUAL"
                        }
                    });
                }

                // Seed default
                return Ok(new
                {
                    success = true,
                    data = new MatrixSettingsModel
                    {
                        BillType = billType,
                        GstCalc = "MANUAL",
                        InterestCalc = "MANUAL"
                    }
                });
            }
            catch (Exception ex)
            {
                return Ok(new { success = false, message = ex.Message });
            }
        }

        [HttpPost("settings")]
        public IActionResult SaveSettings([FromBody] MatrixSettingsModel settings)
        {
            try
            {
                if (settings == null || string.IsNullOrEmpty(settings.BillType))
                    return BadRequest(new { success = false, message = "Settings parameters missing." });

                using var conn = GetConn();
                conn.Open();

                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"INSERT INTO SocBillingMatrixSettings (BillType, GstCalc, InterestCalc)
                    VALUES(@bt, @gst, @int)
                    ON CONFLICT(BillType) DO UPDATE SET GstCalc=@gst, InterestCalc=@int";
                
                cmd.Parameters.AddWithValue("@bt", settings.BillType);
                cmd.Parameters.AddWithValue("@gst", settings.GstCalc ?? "MANUAL");
                cmd.Parameters.AddWithValue("@int", settings.InterestCalc ?? "MANUAL");
                cmd.ExecuteNonQuery();

                return Ok(new { success = true, message = "Calculation settings updated." });
            }
            catch (Exception ex)
            {
                return Ok(new { success = false, message = ex.Message });
            }
        }
    }
}
