using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;

namespace Backend
{
    [ApiController]
    [Route("api/bill-transfers")]
    public class BillTransferController : ControllerBase
    {
        private readonly string _sqliteDbPath = System.IO.Path.Combine(System.AppContext.BaseDirectory, "Data", "ShreeRam.sqlite");

        public class BillTransferModel
        {
            public int Id { get; set; }
            public string? TransferNo { get; set; }
            public string? TransferDate { get; set; }
            public string? MemberCode { get; set; }
            public string? FromBillType { get; set; }
            public string? ToBillType { get; set; }
            public decimal Amount { get; set; }
            public string? Narration { get; set; }
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
                using var conn = GetConn();
                conn.Open();

                var list = new List<BillTransferModel>();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM SocBillTransfer ORDER BY TransferDate DESC, Id DESC";
                    using var r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        list.Add(new BillTransferModel
                        {
                            Id = Convert.ToInt32(r["Id"]),
                            TransferNo = r["TransferNo"]?.ToString() ?? "",
                            TransferDate = r["TransferDate"]?.ToString() ?? "",
                            MemberCode = r["MemberCode"]?.ToString() ?? "",
                            FromBillType = r["FromBillType"]?.ToString() ?? "",
                            ToBillType = r["ToBillType"]?.ToString() ?? "",
                            Amount = r["Amount"] != DBNull.Value ? Convert.ToDecimal(r["Amount"]) : 0,
                            Narration = r["Narration"]?.ToString() ?? ""
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

        [HttpPost]
        public IActionResult Create([FromBody] BillTransferModel req)
        {
            try
            {
                if (req == null) return BadRequest(new { success = false, message = "Invalid request body" });
                if (string.IsNullOrWhiteSpace(req.TransferNo)) return BadRequest(new { success = false, message = "Transfer number required" });
                if (string.IsNullOrWhiteSpace(req.MemberCode)) return BadRequest(new { success = false, message = "Member Code required" });

                using var conn = GetConn();
                conn.Open();

                // Unique check
                using (var chkCmd = conn.CreateCommand())
                {
                    chkCmd.CommandText = "SELECT COUNT(*) FROM SocBillTransfer WHERE TRIM(UPPER(TransferNo)) = TRIM(UPPER(@no))";
                    chkCmd.Parameters.AddWithValue("@no", req.TransferNo.Trim());
                    if (Convert.ToInt32(chkCmd.ExecuteScalar()) > 0)
                    {
                        return BadRequest(new { success = false, message = "Transfer number already exists" });
                    }
                }

                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"INSERT INTO SocBillTransfer (TransferNo, TransferDate, MemberCode, FromBillType, ToBillType, Amount, Narration)
                    VALUES(@no, @td, @mc, @fbt, @tbt, @amt, @narr)";
                
                cmd.Parameters.AddWithValue("@no", req.TransferNo.Trim());
                cmd.Parameters.AddWithValue("@td", req.TransferDate);
                cmd.Parameters.AddWithValue("@mc", req.MemberCode.Trim());
                cmd.Parameters.AddWithValue("@fbt", req.FromBillType ?? "");
                cmd.Parameters.AddWithValue("@tbt", req.ToBillType ?? "");
                cmd.Parameters.AddWithValue("@amt", req.Amount);
                cmd.Parameters.AddWithValue("@narr", req.Narration ?? "");
                cmd.ExecuteNonQuery();

                return Ok(new { success = true, message = "Bill type balance transfer logged successfully." });
            }
            catch (Exception ex)
            {
                return Ok(new { success = false, message = ex.Message });
            }
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] BillTransferModel req)
        {
            try
            {
                if (req == null) return BadRequest(new { success = false, message = "Invalid request body" });

                using var conn = GetConn();
                conn.Open();

                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"UPDATE SocBillTransfer SET 
                    TransferDate = @td, MemberCode = @mc, FromBillType = @fbt, ToBillType = @tbt, 
                    Amount = @amt, Narration = @narr 
                    WHERE Id = @id";
                
                cmd.Parameters.AddWithValue("@td", req.TransferDate);
                cmd.Parameters.AddWithValue("@mc", req.MemberCode.Trim());
                cmd.Parameters.AddWithValue("@fbt", req.FromBillType ?? "");
                cmd.Parameters.AddWithValue("@tbt", req.ToBillType ?? "");
                cmd.Parameters.AddWithValue("@amt", req.Amount);
                cmd.Parameters.AddWithValue("@narr", req.Narration ?? "");
                cmd.Parameters.AddWithValue("@id", id);
                int rows = cmd.ExecuteNonQuery();

                return rows > 0 ? Ok(new { success = true, message = "Transfer updated successfully." })
                    : NotFound(new { success = false, message = "Transfer not found." });
            }
            catch (Exception ex)
            {
                return Ok(new { success = false, message = ex.Message });
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
                cmd.CommandText = "DELETE FROM SocBillTransfer WHERE Id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                int rows = cmd.ExecuteNonQuery();

                return rows > 0 ? Ok(new { success = true, message = "Transfer log deleted successfully." })
                    : NotFound(new { success = false, message = "Transfer log not found." });
            }
            catch (Exception ex)
            {
                return Ok(new { success = false, message = ex.Message });
            }
        }

        [HttpGet("next-no")]
        public IActionResult GetNextNo()
        {
            try
            {
                using var conn = GetConn();
                conn.Open();

                string prefix = "TR/25/";
                int currentSeq = 100;
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT COUNT(*) FROM SocBillTransfer";
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    currentSeq += count + 1;
                }

                while (true)
                {
                    string candidate = prefix + currentSeq.ToString().PadLeft(3, '0');
                    using var chk = conn.CreateCommand();
                    chk.CommandText = "SELECT COUNT(*) FROM SocBillTransfer WHERE TransferNo = @no";
                    chk.Parameters.AddWithValue("@no", candidate);
                    if (Convert.ToInt32(chk.ExecuteScalar()) == 0)
                    {
                        return Ok(new { success = true, transferNo = candidate });
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
