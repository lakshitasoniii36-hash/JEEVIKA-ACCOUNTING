using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;

namespace Backend
{
    [ApiController]
    [Route("api/opening-bank-reco")]
    public class OpeningBankRecoController : ControllerBase
    {
        private readonly string _sqliteDbPath = System.IO.Path.Combine(System.AppContext.BaseDirectory, "Data", "ShreeRam.sqlite");

        public class BankRecoVoucher
        {
            public int Id { get; set; }
            public string VchNo { get; set; }
            public string VchDate { get; set; }
            public string Bank { get; set; }
            public decimal Amount { get; set; }
            public string ChqNo { get; set; }
            public string ChqDate { get; set; }
            public string BillNo { get; set; }
            public string PaidTo { get; set; }
            public string Part1 { get; set; }
            public string Part2 { get; set; }
            public string Narration { get; set; }
        }

        private SqliteConnection GetConn()
        {
            var cs = new SqliteConnectionStringBuilder { DataSource = _sqliteDbPath, Mode = SqliteOpenMode.ReadWriteCreate }.ToString();
            return new SqliteConnection(cs);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var list = new List<BankRecoVoucher>();
                using var conn = GetConn();
                conn.Open();

                using var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM SocOpeningBankReco ORDER BY VchDate DESC, Id DESC";
                using var r = cmd.ExecuteReader();
                while (r.Read())
                {
                    list.Add(new BankRecoVoucher
                    {
                        Id = Convert.ToInt32(r["Id"]),
                        VchNo = r["VchNo"]?.ToString() ?? "",
                        VchDate = r["VchDate"]?.ToString() ?? "",
                        Bank = r["BankLedger"]?.ToString() ?? "",
                        Amount = r["Amount"] != DBNull.Value ? Convert.ToDecimal(r["Amount"]) : 0,
                        ChqNo = r["ChqNo"]?.ToString() ?? "",
                        ChqDate = r["ChqDate"]?.ToString() ?? "",
                        BillNo = r["BillNo"]?.ToString() ?? "",
                        PaidTo = r["PaidTo"]?.ToString() ?? "",
                        Part1 = r["Part1"]?.ToString() ?? "",
                        Part2 = r["Part2"]?.ToString() ?? "",
                        Narration = r["Narration"]?.ToString() ?? ""
                    });
                }

                return Ok(new { success = true, data = list });
            }
            catch (Exception ex)
            {
                return Ok(new { success = false, message = ex.Message });
            }
        }

        [HttpPost]
        public IActionResult Create([FromBody] BankRecoVoucher req)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(req.VchNo)) return BadRequest(new { success = false, message = "Voucher No required" });
                if (string.IsNullOrWhiteSpace(req.VchDate)) return BadRequest(new { success = false, message = "Voucher Date required" });
                if (string.IsNullOrWhiteSpace(req.Bank)) return BadRequest(new { success = false, message = "Bank/Cash Ledger required" });
                if (string.IsNullOrWhiteSpace(req.ChqNo)) return BadRequest(new { success = false, message = "Cheque No required" });
                if (string.IsNullOrWhiteSpace(req.ChqDate)) return BadRequest(new { success = false, message = "Cheque Date required" });

                using var conn = GetConn();
                conn.Open();

                // Unique check
                using (var chkCmd = conn.CreateCommand())
                {
                    chkCmd.CommandText = "SELECT COUNT(*) FROM SocOpeningBankReco WHERE TRIM(UPPER(VchNo)) = TRIM(UPPER(@vch))";
                    chkCmd.Parameters.AddWithValue("@vch", req.VchNo.Trim());
                    if (Convert.ToInt32(chkCmd.ExecuteScalar()) > 0)
                    {
                        return BadRequest(new { success = false, message = "Duplicate Voucher Number" });
                    }
                }

                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"INSERT INTO SocOpeningBankReco (VchNo, VchDate, BankLedger, Amount, ChqNo, ChqDate, BillNo, PaidTo, Part1, Part2, Narration)
                    VALUES(@vch, @vchDate, @bank, @amount, @chq, @chqDate, @bill, @paidTo, @part1, @part2, @narration)";
                cmd.Parameters.AddWithValue("@vch", req.VchNo.Trim());
                cmd.Parameters.AddWithValue("@vchDate", req.VchDate);
                cmd.Parameters.AddWithValue("@bank", req.Bank.Trim());
                cmd.Parameters.AddWithValue("@amount", req.Amount);
                cmd.Parameters.AddWithValue("@chq", req.ChqNo.Trim());
                cmd.Parameters.AddWithValue("@chqDate", req.ChqDate);
                cmd.Parameters.AddWithValue("@bill", req.BillNo ?? "");
                cmd.Parameters.AddWithValue("@paidTo", req.PaidTo ?? "");
                cmd.Parameters.AddWithValue("@part1", req.Part1 ?? "");
                cmd.Parameters.AddWithValue("@part2", req.Part2 ?? "");
                cmd.Parameters.AddWithValue("@narration", req.Narration ?? "");
                cmd.ExecuteNonQuery();

                return Ok(new { success = true, message = "Voucher added to opening bank reconciliation." });
            }
            catch (Exception ex)
            {
                return BadRequest(new { success = false, message = ex.Message });
            }
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] BankRecoVoucher req)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(req.VchDate)) return BadRequest(new { success = false, message = "Voucher Date required" });
                if (string.IsNullOrWhiteSpace(req.Bank)) return BadRequest(new { success = false, message = "Bank/Cash Ledger required" });
                if (string.IsNullOrWhiteSpace(req.ChqNo)) return BadRequest(new { success = false, message = "Cheque No required" });
                if (string.IsNullOrWhiteSpace(req.ChqDate)) return BadRequest(new { success = false, message = "Cheque Date required" });

                using var conn = GetConn();
                conn.Open();

                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"UPDATE SocOpeningBankReco 
                    SET VchDate = @vchDate, BankLedger = @bank, Amount = @amount, ChqNo = @chq, ChqDate = @chqDate, 
                        BillNo = @bill, PaidTo = @paidTo, Part1 = @part1, Part2 = @part2, Narration = @narration 
                    WHERE Id = @id";
                cmd.Parameters.AddWithValue("@vchDate", req.VchDate);
                cmd.Parameters.AddWithValue("@bank", req.Bank.Trim());
                cmd.Parameters.AddWithValue("@amount", req.Amount);
                cmd.Parameters.AddWithValue("@chq", req.ChqNo.Trim());
                cmd.Parameters.AddWithValue("@chqDate", req.ChqDate);
                cmd.Parameters.AddWithValue("@bill", req.BillNo ?? "");
                cmd.Parameters.AddWithValue("@paidTo", req.PaidTo ?? "");
                cmd.Parameters.AddWithValue("@part1", req.Part1 ?? "");
                cmd.Parameters.AddWithValue("@part2", req.Part2 ?? "");
                cmd.Parameters.AddWithValue("@narration", req.Narration ?? "");
                cmd.Parameters.AddWithValue("@id", id);
                int rows = cmd.ExecuteNonQuery();

                return rows > 0 ? Ok(new { success = true, message = "Voucher updated." })
                    : NotFound(new { success = false, message = "Voucher not found." });
            }
            catch (Exception ex)
            {
                return BadRequest(new { success = false, message = ex.Message });
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                using var conn = GetConn();
                conn.Open();

                using var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM SocOpeningBankReco WHERE Id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                int rows = cmd.ExecuteNonQuery();

                return rows > 0 ? Ok(new { success = true, message = "Voucher deleted." })
                    : NotFound(new { success = false, message = "Voucher not found." });
            }
            catch (Exception ex)
            {
                return BadRequest(new { success = false, message = ex.Message });
            }
        }

        [HttpGet("banks")]
        public IActionResult GetBanks()
        {
            try
            {
                var list = new List<string>();
                using var conn = GetConn();
                conn.Open();

                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"SELECT a.AccName 
                    FROM SocAccount a 
                    JOIN SocGroup g ON a.SocSubGroupId = g.SocGroupId 
                    WHERE a.GrpMainId = 1 AND g.GrpName = 'Cash & Bank Balance' AND a.IsDeleted = 0
                    ORDER BY a.AccCode";
                using var r = cmd.ExecuteReader();
                while (r.Read())
                {
                    string name = r["AccName"]?.ToString();
                    if (!string.IsNullOrEmpty(name))
                    {
                        list.Add(name);
                    }
                }

                // If somehow empty, provide default fallback
                if (list.Count == 0)
                {
                    list.AddRange(new[] { "Cash in Hand", "The M.D C.C. Bank A/C No.", "The Saraswat Bank A/C No." });
                }

                return Ok(list);
            }
            catch (Exception ex)
            {
                return Ok(new List<string> { "Cash in Hand", "The M.D C.C. Bank A/C No.", "The Saraswat Bank A/C No." });
            }
        }
    }
}
