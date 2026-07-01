using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;

namespace Backend
{
    [ApiController]
    [Route("api/member-bills")]
    public class MemberBillController : ControllerBase
    {
        private readonly string _sqliteDbPath = System.IO.Path.Combine(System.AppContext.BaseDirectory, "Data", "ShreeRam.sqlite");

        public class BillDetailRow
        {
            public string? HeadName { get; set; }
            public decimal Amount { get; set; }
        }

        public class MemberBillModel
        {
            public string? Id { get; set; }
            public string? VoucherNo { get; set; }
            public string? BillDate { get; set; }
            public string? DueDate { get; set; }
            public string? MemberCode { get; set; }
            public string? BillPeriod { get; set; }
            public string? BillType { get; set; }
            public decimal PrincipalAmount { get; set; }
            public decimal GstAmount { get; set; }
            public decimal InterestAmount { get; set; }
            public decimal TotalAmount { get; set; }
            public decimal OpeningBalance { get; set; }
            public decimal ClosingBalance { get; set; }
            public List<BillDetailRow> LineItems { get; set; } = new List<BillDetailRow>();
        }

        private SqliteConnection GetConn()
        {
            var cs = new SqliteConnectionStringBuilder { DataSource = _sqliteDbPath, Mode = SqliteOpenMode.ReadWriteCreate }.ToString();
            return new SqliteConnection(cs);
        }

        [HttpGet]
        public IActionResult GetAll([FromQuery] string? billType = null)
        {
            try
            {
                using var conn = GetConn();
                conn.Open();

                var list = new List<MemberBillModel>();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM SocMemberBill " +
                                      (string.IsNullOrEmpty(billType) ? "" : "WHERE BillType = @bt ") +
                                      "ORDER BY BillDate DESC, Id DESC";
                    if (!string.IsNullOrEmpty(billType))
                    {
                        cmd.Parameters.AddWithValue("@bt", billType.Trim());
                    }

                    using var r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        list.Add(new MemberBillModel
                        {
                            Id = "BILL-ID-" + r["Id"].ToString(),
                            VoucherNo = r["VoucherNo"]?.ToString() ?? "",
                            BillDate = r["BillDate"]?.ToString() ?? "",
                            DueDate = r["DueDate"]?.ToString() ?? "",
                            MemberCode = r["MemberCode"]?.ToString() ?? "",
                            BillPeriod = r["BillPeriod"]?.ToString() ?? "",
                            BillType = r["BillType"]?.ToString() ?? "",
                            PrincipalAmount = r["PrincipalAmount"] != DBNull.Value ? Convert.ToDecimal(r["PrincipalAmount"]) : 0,
                            GstAmount = r["GstAmount"] != DBNull.Value ? Convert.ToDecimal(r["GstAmount"]) : 0,
                            InterestAmount = r["InterestAmount"] != DBNull.Value ? Convert.ToDecimal(r["InterestAmount"]) : 0,
                            TotalAmount = r["TotalAmount"] != DBNull.Value ? Convert.ToDecimal(r["TotalAmount"]) : 0,
                            OpeningBalance = r["OpeningBalance"] != DBNull.Value ? Convert.ToDecimal(r["OpeningBalance"]) : 0,
                            ClosingBalance = r["ClosingBalance"] != DBNull.Value ? Convert.ToDecimal(r["ClosingBalance"]) : 0
                        });
                    }
                }

                // Fetch line items for each bill
                foreach (var b in list)
                {
                    using var dCmd = conn.CreateCommand();
                    dCmd.CommandText = "SELECT * FROM SocMemberBillDetail WHERE VoucherNo = @vno";
                    dCmd.Parameters.AddWithValue("@vno", b.VoucherNo);
                    using var dr = dCmd.ExecuteReader();
                    while (dr.Read())
                    {
                        b.LineItems.Add(new BillDetailRow
                        {
                            HeadName = dr["HeadName"]?.ToString() ?? "",
                            Amount = dr["Amount"] != DBNull.Value ? Convert.ToDecimal(dr["Amount"]) : 0
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

                MemberBillModel bill = null;
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM SocMemberBill WHERE VoucherNo = @vno LIMIT 1";
                    cmd.Parameters.AddWithValue("@vno", voucherNo.Trim());
                    using var r = cmd.ExecuteReader();
                    if (r.Read())
                    {
                        bill = new MemberBillModel
                        {
                            Id = "BILL-ID-" + r["Id"].ToString(),
                            VoucherNo = r["VoucherNo"]?.ToString() ?? "",
                            BillDate = r["BillDate"]?.ToString() ?? "",
                            DueDate = r["DueDate"]?.ToString() ?? "",
                            MemberCode = r["MemberCode"]?.ToString() ?? "",
                            BillPeriod = r["BillPeriod"]?.ToString() ?? "",
                            BillType = r["BillType"]?.ToString() ?? "",
                            PrincipalAmount = r["PrincipalAmount"] != DBNull.Value ? Convert.ToDecimal(r["PrincipalAmount"]) : 0,
                            GstAmount = r["GstAmount"] != DBNull.Value ? Convert.ToDecimal(r["GstAmount"]) : 0,
                            InterestAmount = r["InterestAmount"] != DBNull.Value ? Convert.ToDecimal(r["InterestAmount"]) : 0,
                            TotalAmount = r["TotalAmount"] != DBNull.Value ? Convert.ToDecimal(r["TotalAmount"]) : 0,
                            OpeningBalance = r["OpeningBalance"] != DBNull.Value ? Convert.ToDecimal(r["OpeningBalance"]) : 0,
                            ClosingBalance = r["ClosingBalance"] != DBNull.Value ? Convert.ToDecimal(r["ClosingBalance"]) : 0
                        };
                    }
                }

                if (bill == null) return NotFound(new { success = false, message = "Bill not found" });

                // Get details
                using (var dCmd = conn.CreateCommand())
                {
                    dCmd.CommandText = "SELECT * FROM SocMemberBillDetail WHERE VoucherNo = @vno";
                    dCmd.Parameters.AddWithValue("@vno", bill.VoucherNo);
                    using var dr = dCmd.ExecuteReader();
                    while (dr.Read())
                    {
                        bill.LineItems.Add(new BillDetailRow
                        {
                            HeadName = dr["HeadName"]?.ToString() ?? "",
                            Amount = dr["Amount"] != DBNull.Value ? Convert.ToDecimal(dr["Amount"]) : 0
                        });
                    }
                }

                return Ok(new { success = true, data = bill });
            }
            catch (Exception ex)
            {
                return Ok(new { success = false, message = ex.Message });
            }
        }

        [HttpPost]
        public IActionResult CreateOrUpdateBulk([FromBody] List<MemberBillModel> bills)
        {
            try
            {
                if (bills == null || bills.Count == 0) return BadRequest(new { success = false, message = "No bills provided" });

                using var conn = GetConn();
                conn.Open();
                using var trans = conn.BeginTransaction();

                try
                {
                    foreach (var bill in bills)
                    {
                        if (string.IsNullOrWhiteSpace(bill.VoucherNo)) continue;

                        // 1. Delete if existing
                        using (var delHC = conn.CreateCommand())
                        {
                            delHC.Transaction = trans;
                            delHC.CommandText = "DELETE FROM SocMemberBill WHERE VoucherNo = @vno";
                            delHC.Parameters.AddWithValue("@vno", bill.VoucherNo.Trim());
                            delHC.ExecuteNonQuery();
                        }
                        using (var delDC = conn.CreateCommand())
                        {
                            delDC.Transaction = trans;
                            delDC.CommandText = "DELETE FROM SocMemberBillDetail WHERE VoucherNo = @vno";
                            delDC.Parameters.AddWithValue("@vno", bill.VoucherNo.Trim());
                            delDC.ExecuteNonQuery();
                        }

                        // 2. Insert Header
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.Transaction = trans;
                            cmd.CommandText = @"INSERT INTO SocMemberBill (VoucherNo, BillDate, DueDate, MemberCode, BillPeriod, BillType, PrincipalAmount, GstAmount, InterestAmount, TotalAmount, OpeningBalance, ClosingBalance)
                                VALUES(@vn, @bd, @dd, @mc, @bp, @bt, @pa, @ga, @ia, @ta, @ob, @cb)";
                            
                            cmd.Parameters.AddWithValue("@vn", bill.VoucherNo.Trim());
                            cmd.Parameters.AddWithValue("@bd", bill.BillDate);
                            cmd.Parameters.AddWithValue("@dd", bill.DueDate);
                            cmd.Parameters.AddWithValue("@mc", bill.MemberCode.Trim());
                            cmd.Parameters.AddWithValue("@bp", bill.BillPeriod ?? "Monthly");
                            cmd.Parameters.AddWithValue("@bt", bill.BillType ?? "Maintenance");
                            cmd.Parameters.AddWithValue("@pa", bill.PrincipalAmount);
                            cmd.Parameters.AddWithValue("@ga", bill.GstAmount);
                            cmd.Parameters.AddWithValue("@ia", bill.InterestAmount);
                            cmd.Parameters.AddWithValue("@ta", bill.TotalAmount);
                            cmd.Parameters.AddWithValue("@ob", bill.OpeningBalance);
                            cmd.Parameters.AddWithValue("@cb", bill.ClosingBalance);
                            cmd.ExecuteNonQuery();
                        }

                        // 3. Insert Details
                        if (bill.LineItems != null)
                        {
                            foreach (var item in bill.LineItems)
                            {
                                using var dCmd = conn.CreateCommand();
                                dCmd.Transaction = trans;
                                dCmd.CommandText = @"INSERT INTO SocMemberBillDetail (VoucherNo, HeadName, Amount)
                                    VALUES(@vn, @hn, @amt)";
                                dCmd.Parameters.AddWithValue("@vn", bill.VoucherNo.Trim());
                                dCmd.Parameters.AddWithValue("@hn", item.HeadName ?? "");
                                dCmd.Parameters.AddWithValue("@amt", item.Amount);
                                dCmd.ExecuteNonQuery();
                            }
                        }
                    }

                    trans.Commit();
                    return Ok(new { success = true, message = "Bills stored successfully." });
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    return Ok(new { success = false, message = "Bulk bills save failed: " + ex.Message });
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
                    using (var dCmd = conn.CreateCommand())
                    {
                        dCmd.Transaction = trans;
                        dCmd.CommandText = "DELETE FROM SocMemberBillDetail WHERE VoucherNo = @vn";
                        dCmd.Parameters.AddWithValue("@vn", voucherNo.Trim());
                        dCmd.ExecuteNonQuery();
                    }

                    int rows = 0;
                    using (var hCmd = conn.CreateCommand())
                    {
                        hCmd.Transaction = trans;
                        hCmd.CommandText = "DELETE FROM SocMemberBill WHERE VoucherNo = @vn";
                        hCmd.Parameters.AddWithValue("@vn", voucherNo.Trim());
                        rows = hCmd.ExecuteNonQuery();
                    }

                    trans.Commit();
                    return rows > 0 ? Ok(new { success = true, message = "Bill deleted." })
                        : NotFound(new { success = false, message = "Bill not found." });
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

        private static int ParseLastNumeric(string vNo)
        {
            if (string.IsNullOrEmpty(vNo)) return 0;
            int idx = vNo.Length - 1;
            while (idx >= 0 && char.IsDigit(vNo[idx]))
            {
                idx--;
            }
            string numStr = vNo.Substring(idx + 1);
            if (int.TryParse(numStr, out int result))
            {
                return result;
            }
            return 0;
        }

        [HttpGet("next-no")]
        public IActionResult GetNextNo([FromQuery] int? startNo = null)
        {
            try
            {
                using var conn = GetConn();
                conn.Open();

                string prefix = "MBIL/2025-26/";
                int start = startNo ?? DbHelper.GetStartNoForTransaction("Bill", 1);

                int maxExisting = 0;
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT VoucherNo FROM SocMemberBill";
                    using var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string vNo = reader.GetString(0);
                        int num = ParseLastNumeric(vNo);
                        if (num > maxExisting) maxExisting = num;
                    }
                }

                int currentSeq = Math.Max(start, maxExisting + 1);

                while (true)
                {
                    string candidate = prefix + currentSeq.ToString().PadLeft(2, '0');
                    using var chk = conn.CreateCommand();
                    chk.CommandText = "SELECT COUNT(*) FROM SocMemberBill WHERE VoucherNo = @vno";
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
