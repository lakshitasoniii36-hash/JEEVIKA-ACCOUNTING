using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;

namespace Backend
{
    [ApiController]
    [Route("api/vouchers")]
    public class VoucherController : ControllerBase
    {
        private readonly string _sqliteDbPath = System.IO.Path.Combine(System.AppContext.BaseDirectory, "Data", "ShreeRam.sqlite");

        public class VoucherDetailRow
        {
            public int Sr { get; set; }
            public string? Code { get; set; }
            public string? AccountName { get; set; }
            public decimal Debit { get; set; }
            public decimal Credit { get; set; }
        }

        public class VoucherModel
        {
            public string? Id { get; set; } // string formatted like PV-ID-1 or CV-ID-2
            public string? VoucherNo { get; set; }
            public string? VoucherDate { get; set; }
            public string? VoucherType { get; set; }
            public string? CashBankCode { get; set; }
            public string? CashBankName { get; set; }
            public decimal Amount { get; set; }
            public string? ChqNo { get; set; }
            public string? ChqDate { get; set; }
            public string? BillNo { get; set; }
            public string? PersonName { get; set; }
            public string? Particular1 { get; set; }
            public string? Particular2 { get; set; }
            public string? Remark1 { get; set; }
            public string? Remark2 { get; set; }
            public string? Status { get; set; } = "Posted";
            public List<VoucherDetailRow> LineItems { get; set; } = new List<VoucherDetailRow>();
        }

        private SqliteConnection GetConn()
        {
            var cs = new SqliteConnectionStringBuilder { DataSource = _sqliteDbPath, Mode = SqliteOpenMode.ReadWriteCreate }.ToString();
            return new SqliteConnection(cs);
        }

        [HttpGet]
        public IActionResult GetAll([FromQuery] string type)
        {
            try
            {
                if (string.IsNullOrEmpty(type)) return BadRequest(new { success = false, message = "Voucher type required" });
                type = type.Trim();

                using var conn = GetConn();
                conn.Open();

                var list = new List<VoucherModel>();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM SocVoucherHeader WHERE VoucherType = @type ORDER BY VoucherDate DESC, Id DESC";
                    cmd.Parameters.AddWithValue("@type", type);
                    using var r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        list.Add(new VoucherModel
                        {
                            Id = r["VoucherType"].ToString().Substring(0, 2).ToUpper() + "-ID-" + r["Id"].ToString(),
                            VoucherNo = r["VoucherNo"]?.ToString() ?? "",
                            VoucherDate = r["VoucherDate"]?.ToString() ?? "",
                            VoucherType = r["VoucherType"]?.ToString() ?? "",
                            CashBankCode = r["CashBankCode"]?.ToString() ?? "",
                            CashBankName = r["CashBankName"]?.ToString() ?? "",
                            Amount = r["Amount"] != DBNull.Value ? Convert.ToDecimal(r["Amount"]) : 0,
                            ChqNo = r["ChqNo"]?.ToString() ?? "",
                            ChqDate = r["ChqDate"]?.ToString() ?? "",
                            BillNo = r["BillNo"]?.ToString() ?? "",
                            PersonName = r["PersonName"]?.ToString() ?? "",
                            Particular1 = r["Particular1"]?.ToString() ?? "",
                            Particular2 = r["Particular2"]?.ToString() ?? "",
                            Remark1 = r["Remark1"]?.ToString() ?? "",
                            Remark2 = r["Remark2"]?.ToString() ?? "",
                            Status = r["Status"]?.ToString() ?? "Posted"
                        });
                    }
                }

                // Fetch line items for each voucher
                foreach (var v in list)
                {
                    using var dCmd = conn.CreateCommand();
                    dCmd.CommandText = "SELECT * FROM SocVoucherDetail WHERE VoucherNo = @vno ORDER BY SrNo";
                    dCmd.Parameters.AddWithValue("@vno", v.VoucherNo);
                    using var dr = dCmd.ExecuteReader();
                    while (dr.Read())
                    {
                        v.LineItems.Add(new VoucherDetailRow
                        {
                            Sr = Convert.ToInt32(dr["SrNo"]),
                            Code = dr["AccountCode"]?.ToString() ?? "",
                            AccountName = dr["AccountName"]?.ToString() ?? "",
                            Debit = dr["Debit"] != DBNull.Value ? Convert.ToDecimal(dr["Debit"]) : 0,
                            Credit = dr["Credit"] != DBNull.Value ? Convert.ToDecimal(dr["Credit"]) : 0
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

        [HttpGet("{*voucherNo}")]
        public IActionResult GetSingle(string voucherNo)
        {
            try
            {
                using var conn = GetConn();
                conn.Open();

                VoucherModel voucher = null;
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM SocVoucherHeader WHERE VoucherNo = @vno LIMIT 1";
                    cmd.Parameters.AddWithValue("@vno", voucherNo.Trim());
                    using var r = cmd.ExecuteReader();
                    if (r.Read())
                    {
                        voucher = new VoucherModel
                        {
                            Id = r["VoucherType"].ToString().Substring(0, 2).ToUpper() + "-ID-" + r["Id"].ToString(),
                            VoucherNo = r["VoucherNo"]?.ToString() ?? "",
                            VoucherDate = r["VoucherDate"]?.ToString() ?? "",
                            VoucherType = r["VoucherType"]?.ToString() ?? "",
                            CashBankCode = r["CashBankCode"]?.ToString() ?? "",
                            CashBankName = r["CashBankName"]?.ToString() ?? "",
                            Amount = r["Amount"] != DBNull.Value ? Convert.ToDecimal(r["Amount"]) : 0,
                            ChqNo = r["ChqNo"]?.ToString() ?? "",
                            ChqDate = r["ChqDate"]?.ToString() ?? "",
                            BillNo = r["BillNo"]?.ToString() ?? "",
                            PersonName = r["PersonName"]?.ToString() ?? "",
                            Particular1 = r["Particular1"]?.ToString() ?? "",
                            Particular2 = r["Particular2"]?.ToString() ?? "",
                            Remark1 = r["Remark1"]?.ToString() ?? "",
                            Remark2 = r["Remark2"]?.ToString() ?? "",
                            Status = r["Status"]?.ToString() ?? "Posted"
                        };
                    }
                }

                if (voucher == null) return NotFound(new { success = false, message = "Voucher not found" });

                // Get details
                using (var dCmd = conn.CreateCommand())
                {
                    dCmd.CommandText = "SELECT * FROM SocVoucherDetail WHERE VoucherNo = @vno ORDER BY SrNo";
                    dCmd.Parameters.AddWithValue("@vno", voucher.VoucherNo);
                    using var dr = dCmd.ExecuteReader();
                    while (dr.Read())
                    {
                        voucher.LineItems.Add(new VoucherDetailRow
                        {
                            Sr = Convert.ToInt32(dr["SrNo"]),
                            Code = dr["AccountCode"]?.ToString() ?? "",
                            AccountName = dr["AccountName"]?.ToString() ?? "",
                            Debit = dr["Debit"] != DBNull.Value ? Convert.ToDecimal(dr["Debit"]) : 0,
                            Credit = dr["Credit"] != DBNull.Value ? Convert.ToDecimal(dr["Credit"]) : 0
                        });
                    }
                }

                return Ok(new { success = true, data = voucher });
            }
            catch (Exception ex)
            {
                return Ok(new { success = false, message = ex.Message });
            }
        }

        [HttpPost]
        public IActionResult Create([FromBody] VoucherModel req)
        {
            try
            {
                if (req == null) return BadRequest(new { success = false, message = "Invalid request body" });
                if (string.IsNullOrWhiteSpace(req.VoucherNo)) return BadRequest(new { success = false, message = "Voucher number required" });
                if (string.IsNullOrWhiteSpace(req.VoucherType)) return BadRequest(new { success = false, message = "Voucher type required" });

                using var conn = GetConn();
                conn.Open();

                // Unique check
                using (var chkCmd = conn.CreateCommand())
                {
                    chkCmd.CommandText = "SELECT COUNT(*) FROM SocVoucherHeader WHERE TRIM(UPPER(VoucherNo)) = TRIM(UPPER(@vno))";
                    chkCmd.Parameters.AddWithValue("@vno", req.VoucherNo.Trim());
                    if (Convert.ToInt32(chkCmd.ExecuteScalar()) > 0)
                    {
                        return BadRequest(new { success = false, message = "Voucher number already exists" });
                    }
                }

                using var trans = conn.BeginTransaction();
                try
                {
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.Transaction = trans;
                        cmd.CommandText = @"INSERT INTO SocVoucherHeader (VoucherNo, VoucherDate, VoucherType, CashBankCode, CashBankName, Amount, ChqNo, ChqDate, BillNo, PersonName, Particular1, Particular2, Remark1, Remark2, Status)
                            VALUES(@vn, @vd, @vt, @cbc, @cbn, @amt, @cn, @cd, @bn, @pn, @p1, @p2, @r1, @r2, @st)";
                        
                        cmd.Parameters.AddWithValue("@vn", req.VoucherNo.Trim());
                        cmd.Parameters.AddWithValue("@vd", req.VoucherDate);
                        cmd.Parameters.AddWithValue("@vt", req.VoucherType);
                        cmd.Parameters.AddWithValue("@cbc", req.CashBankCode ?? "");
                        cmd.Parameters.AddWithValue("@cbn", req.CashBankName ?? "");
                        cmd.Parameters.AddWithValue("@amt", req.Amount);
                        cmd.Parameters.AddWithValue("@cn", req.ChqNo ?? "");
                        cmd.Parameters.AddWithValue("@cd", req.ChqDate ?? "");
                        cmd.Parameters.AddWithValue("@bn", req.BillNo ?? "");
                        cmd.Parameters.AddWithValue("@pn", req.PersonName ?? "");
                        cmd.Parameters.AddWithValue("@p1", req.Particular1 ?? "");
                        cmd.Parameters.AddWithValue("@p2", req.Particular2 ?? "");
                        cmd.Parameters.AddWithValue("@r1", req.Remark1 ?? "");
                        cmd.Parameters.AddWithValue("@r2", req.Remark2 ?? "");
                        cmd.Parameters.AddWithValue("@st", req.Status ?? "Posted");
                        cmd.ExecuteNonQuery();
                    }

                    // Insert detail line items
                    if (req.LineItems != null)
                    {
                        foreach (var item in req.LineItems)
                        {
                            using var dCmd = conn.CreateCommand();
                            dCmd.Transaction = trans;
                            dCmd.CommandText = @"INSERT INTO SocVoucherDetail (VoucherNo, SrNo, AccountCode, AccountName, Debit, Credit)
                                VALUES(@vn, @sr, @ac, @an, @db, @cr)";
                            dCmd.Parameters.AddWithValue("@vn", req.VoucherNo.Trim());
                            dCmd.Parameters.AddWithValue("@sr", item.Sr);
                            dCmd.Parameters.AddWithValue("@ac", item.Code ?? "");
                            dCmd.Parameters.AddWithValue("@an", item.AccountName ?? "");
                            dCmd.Parameters.AddWithValue("@db", item.Debit);
                            dCmd.Parameters.AddWithValue("@cr", item.Credit);
                            dCmd.ExecuteNonQuery();
                        }
                    }

                    trans.Commit();
                    return Ok(new { success = true, message = "Voucher saved successfully." });
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    return Ok(new { success = false, message = "Save failed: " + ex.Message });
                }
            }
            catch (Exception ex)
            {
                return Ok(new { success = false, message = ex.Message });
            }
        }

        [HttpPut("{*voucherNo}")]
        public IActionResult Update(string voucherNo, [FromBody] VoucherModel req)
        {
            try
            {
                if (req == null) return BadRequest(new { success = false, message = "Invalid request body" });

                using var conn = GetConn();
                conn.Open();
                using var trans = conn.BeginTransaction();

                try
                {
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.Transaction = trans;
                        cmd.CommandText = @"UPDATE SocVoucherHeader SET 
                            VoucherDate = @vd, CashBankCode = @cbc, CashBankName = @cbn, Amount = @amt, 
                            ChqNo = @cn, ChqDate = @cd, BillNo = @bn, PersonName = @pn, Particular1 = @p1, 
                            Particular2 = @p2, Remark1 = @r1, Remark2 = @r2, Status = @st 
                            WHERE VoucherNo = @vn";

                        cmd.Parameters.AddWithValue("@vd", req.VoucherDate);
                        cmd.Parameters.AddWithValue("@cbc", req.CashBankCode ?? "");
                        cmd.Parameters.AddWithValue("@cbn", req.CashBankName ?? "");
                        cmd.Parameters.AddWithValue("@amt", req.Amount);
                        cmd.Parameters.AddWithValue("@cn", req.ChqNo ?? "");
                        cmd.Parameters.AddWithValue("@cd", req.ChqDate ?? "");
                        cmd.Parameters.AddWithValue("@bn", req.BillNo ?? "");
                        cmd.Parameters.AddWithValue("@pn", req.PersonName ?? "");
                        cmd.Parameters.AddWithValue("@p1", req.Particular1 ?? "");
                        cmd.Parameters.AddWithValue("@p2", req.Particular2 ?? "");
                        cmd.Parameters.AddWithValue("@r1", req.Remark1 ?? "");
                        cmd.Parameters.AddWithValue("@r2", req.Remark2 ?? "");
                        cmd.Parameters.AddWithValue("@st", req.Status ?? "Posted");
                        cmd.Parameters.AddWithValue("@vn", voucherNo.Trim());
                        cmd.ExecuteNonQuery();
                    }

                    // Reset details
                    using (var delCmd = conn.CreateCommand())
                    {
                        delCmd.Transaction = trans;
                        delCmd.CommandText = "DELETE FROM SocVoucherDetail WHERE VoucherNo = @vn";
                        delCmd.Parameters.AddWithValue("@vn", voucherNo.Trim());
                        delCmd.ExecuteNonQuery();
                    }

                    // Re-insert detail lines
                    if (req.LineItems != null)
                    {
                        foreach (var item in req.LineItems)
                        {
                            using var dCmd = conn.CreateCommand();
                            dCmd.Transaction = trans;
                            dCmd.CommandText = @"INSERT INTO SocVoucherDetail (VoucherNo, SrNo, AccountCode, AccountName, Debit, Credit)
                                VALUES(@vn, @sr, @ac, @an, @db, @cr)";
                            dCmd.Parameters.AddWithValue("@vn", voucherNo.Trim());
                            dCmd.Parameters.AddWithValue("@sr", item.Sr);
                            dCmd.Parameters.AddWithValue("@ac", item.Code ?? "");
                            dCmd.Parameters.AddWithValue("@an", item.AccountName ?? "");
                            dCmd.Parameters.AddWithValue("@db", item.Debit);
                            dCmd.Parameters.AddWithValue("@cr", item.Credit);
                            dCmd.ExecuteNonQuery();
                        }
                    }

                    trans.Commit();
                    return Ok(new { success = true, message = "Voucher updated successfully." });
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    return Ok(new { success = false, message = "Update failed: " + ex.Message });
                }
            }
            catch (Exception ex)
            {
                return Ok(new { success = false, message = ex.Message });
            }
        }

        [HttpDelete("{*voucherNo}")]
        public IActionResult Delete(string voucherNo)
        {
            try
            {
                using var conn = GetConn();
                conn.Open();
                using var trans = conn.BeginTransaction();

                try
                {
                    // Delete details
                    using (var dCmd = conn.CreateCommand())
                    {
                        dCmd.Transaction = trans;
                        dCmd.CommandText = "DELETE FROM SocVoucherDetail WHERE VoucherNo = @vn";
                        dCmd.Parameters.AddWithValue("@vn", voucherNo.Trim());
                        dCmd.ExecuteNonQuery();
                    }

                    // Delete header
                    int rows = 0;
                    using (var hCmd = conn.CreateCommand())
                    {
                        hCmd.Transaction = trans;
                        hCmd.CommandText = "DELETE FROM SocVoucherHeader WHERE VoucherNo = @vn";
                        hCmd.Parameters.AddWithValue("@vn", voucherNo.Trim());
                        rows = hCmd.ExecuteNonQuery();
                    }

                    trans.Commit();
                    return rows > 0 ? Ok(new { success = true, message = "Voucher deleted successfully." })
                        : NotFound(new { success = false, message = "Voucher not found." });
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    return Ok(new { success = false, message = "Delete failed: " + ex.Message });
                }
            }
            catch (Exception ex)
            {
                return Ok(new { success = false, message = ex.Message });
            }
        }

        [HttpGet("next-no")]
        public IActionResult GetNextNo([FromQuery] string type)
        {
            try
            {
                if (string.IsNullOrEmpty(type)) return BadRequest(new { success = false, message = "Voucher type required" });
                type = type.Trim();

                using var conn = GetConn();
                conn.Open();

                string prefix = "";
                if (type == "Payment") prefix = "PV/25/";
                else if (type == "Receipt") prefix = "MR/25/";
                else if (type == "Contra") prefix = "CV/25/";
                else if (type == "JV") prefix = "JV/25/";
                else if (type == "OtherReceipt") prefix = "OR/25/";
                else if (type == "Reversal") prefix = "VR/25/";
                else prefix = type.Substring(0, 2).ToUpper() + "/25/";

                int currentSeq = 100;
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT COUNT(*) FROM SocVoucherHeader WHERE VoucherType = @type";
                    cmd.Parameters.AddWithValue("@type", type);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    currentSeq += count + 1;
                }

                // Make sure it is unique
                while (true)
                {
                    string candidate = prefix + currentSeq.ToString().PadLeft(3, '0');
                    using var chk = conn.CreateCommand();
                    chk.CommandText = "SELECT COUNT(*) FROM SocVoucherHeader WHERE VoucherNo = @vno";
                    chk.Parameters.AddWithValue("@vno", candidate);
                    if (Convert.ToInt32(chk.ExecuteScalar()) == 0)
                    {
                        return Ok(new { success = true, voucherNo = candidate });
                    }
                    currentSeq++;
                }
            }
            catch (Exception ex)
            {
                return Ok(new { success = false, message = ex.Message });
            }
        }
    }
}
