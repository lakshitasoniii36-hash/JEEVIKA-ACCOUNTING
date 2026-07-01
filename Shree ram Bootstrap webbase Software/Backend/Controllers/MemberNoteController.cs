using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;

namespace Backend
{
    [ApiController]
    [Route("api/member-notes")]
    public class MemberNoteController : ControllerBase
    {
        private readonly string _sqliteDbPath = System.IO.Path.Combine(System.AppContext.BaseDirectory, "Data", "ShreeRam.sqlite");

        public class MemberNoteModel
        {
            public int Id { get; set; }
            public string? NoteNo { get; set; }
            public string? NoteDate { get; set; }
            public string? NoteType { get; set; } // 'Credit' or 'Debit'
            public string? MemberCode { get; set; }
            public string? BillType { get; set; }
            public string? LedgerCode { get; set; }
            public decimal Amount { get; set; }
            public decimal GstRate { get; set; }
            public decimal GstAmount { get; set; }
            public decimal Total { get; set; }
            public string? Particular { get; set; }
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
                if (string.IsNullOrEmpty(type)) return BadRequest(new { success = false, message = "Note type required (Credit/Debit)" });
                type = type.Trim();

                using var conn = GetConn();
                conn.Open();

                var list = new List<MemberNoteModel>();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM SocMemberNote WHERE NoteType = @type ORDER BY NoteDate DESC, Id DESC";
                    cmd.Parameters.AddWithValue("@type", type);
                    using var r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        list.Add(new MemberNoteModel
                        {
                            Id = Convert.ToInt32(r["Id"]),
                            NoteNo = r["NoteNo"]?.ToString() ?? "",
                            NoteDate = r["NoteDate"]?.ToString() ?? "",
                            NoteType = r["NoteType"]?.ToString() ?? "",
                            MemberCode = r["MemberCode"]?.ToString() ?? "",
                            BillType = r["BillType"]?.ToString() ?? "",
                            LedgerCode = r["LedgerCode"]?.ToString() ?? "",
                            Amount = r["Amount"] != DBNull.Value ? Convert.ToDecimal(r["Amount"]) : 0,
                            GstRate = r["GstRate"] != DBNull.Value ? Convert.ToDecimal(r["GstRate"]) : 0,
                            GstAmount = r["GstAmount"] != DBNull.Value ? Convert.ToDecimal(r["GstAmount"]) : 0,
                            Total = r["Total"] != DBNull.Value ? Convert.ToDecimal(r["Total"]) : 0,
                            Particular = r["Particular"]?.ToString() ?? ""
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
        public IActionResult Create([FromBody] MemberNoteModel req)
        {
            try
            {
                if (req == null) return BadRequest(new { success = false, message = "Invalid request body" });
                if (string.IsNullOrWhiteSpace(req.NoteNo)) return BadRequest(new { success = false, message = "Note number required" });
                if (string.IsNullOrWhiteSpace(req.NoteType)) return BadRequest(new { success = false, message = "Note type required" });

                using var conn = GetConn();
                conn.Open();

                // Unique check
                using (var chkCmd = conn.CreateCommand())
                {
                    chkCmd.CommandText = "SELECT COUNT(*) FROM SocMemberNote WHERE TRIM(UPPER(NoteNo)) = TRIM(UPPER(@no))";
                    chkCmd.Parameters.AddWithValue("@no", req.NoteNo.Trim());
                    if (Convert.ToInt32(chkCmd.ExecuteScalar()) > 0)
                    {
                        return BadRequest(new { success = false, message = "Note number already exists" });
                    }
                }

                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"INSERT INTO SocMemberNote (NoteNo, NoteDate, NoteType, MemberCode, BillType, LedgerCode, Amount, GstRate, GstAmount, Total, Particular)
                    VALUES(@no, @nd, @nt, @mc, @bt, @lc, @amt, @gr, @ga, @tot, @part)";
                
                cmd.Parameters.AddWithValue("@no", req.NoteNo.Trim());
                cmd.Parameters.AddWithValue("@nd", req.NoteDate);
                cmd.Parameters.AddWithValue("@nt", req.NoteType);
                cmd.Parameters.AddWithValue("@mc", req.MemberCode.Trim());
                cmd.Parameters.AddWithValue("@bt", req.BillType ?? "");
                cmd.Parameters.AddWithValue("@lc", req.LedgerCode ?? "");
                cmd.Parameters.AddWithValue("@amt", req.Amount);
                cmd.Parameters.AddWithValue("@gr", req.GstRate);
                cmd.Parameters.AddWithValue("@ga", req.GstAmount);
                cmd.Parameters.AddWithValue("@tot", req.Total);
                cmd.Parameters.AddWithValue("@part", req.Particular ?? "");
                cmd.ExecuteNonQuery();

                return Ok(new { success = true, message = $"{req.NoteType} note saved successfully." });
            }
            catch (Exception ex)
            {
                return Ok(new { success = false, message = ex.Message });
            }
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] MemberNoteModel req)
        {
            try
            {
                if (req == null) return BadRequest(new { success = false, message = "Invalid request body" });

                using var conn = GetConn();
                conn.Open();

                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"UPDATE SocMemberNote SET 
                    NoteDate = @nd, MemberCode = @mc, BillType = @bt, LedgerCode = @lc, 
                    Amount = @amt, GstRate = @gr, GstAmount = @ga, Total = @tot, Particular = @part 
                    WHERE Id = @id";
                
                cmd.Parameters.AddWithValue("@nd", req.NoteDate);
                cmd.Parameters.AddWithValue("@mc", req.MemberCode.Trim());
                cmd.Parameters.AddWithValue("@bt", req.BillType ?? "");
                cmd.Parameters.AddWithValue("@lc", req.LedgerCode ?? "");
                cmd.Parameters.AddWithValue("@amt", req.Amount);
                cmd.Parameters.AddWithValue("@gr", req.GstRate);
                cmd.Parameters.AddWithValue("@ga", req.GstAmount);
                cmd.Parameters.AddWithValue("@tot", req.Total);
                cmd.Parameters.AddWithValue("@part", req.Particular ?? "");
                cmd.Parameters.AddWithValue("@id", id);
                int rows = cmd.ExecuteNonQuery();

                return rows > 0 ? Ok(new { success = true, message = "Note updated successfully." })
                    : NotFound(new { success = false, message = "Note not found." });
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
                cmd.CommandText = "DELETE FROM SocMemberNote WHERE Id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                int rows = cmd.ExecuteNonQuery();

                return rows > 0 ? Ok(new { success = true, message = "Note deleted successfully." })
                    : NotFound(new { success = false, message = "Note not found." });
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
        public IActionResult GetNextNo([FromQuery] string type, [FromQuery] int? startNo = null)
        {
            try
            {
                if (string.IsNullOrEmpty(type)) return BadRequest(new { success = false, message = "Note type required" });
                type = type.Trim();

                using var conn = GetConn();
                conn.Open();

                string prefix = type == "Credit" ? "MCRN/25-26/" : "MDRN/25-26/";
                int start = startNo ?? DbHelper.GetStartNoForTransaction(type, 1);

                int maxExisting = 0;
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT NoteNo FROM SocMemberNote WHERE NoteType = @type";
                    cmd.Parameters.AddWithValue("@type", type);
                    using var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string noteNo = reader.GetString(0);
                        int num = ParseLastNumeric(noteNo);
                        if (num > maxExisting) maxExisting = num;
                    }
                }

                int currentSeq = Math.Max(start, maxExisting + 1);

                while (true)
                {
                    string candidate = prefix + currentSeq.ToString().PadLeft(2, '0');
                    using var chk = conn.CreateCommand();
                    chk.CommandText = "SELECT COUNT(*) FROM SocMemberNote WHERE NoteNo = @no";
                    chk.Parameters.AddWithValue("@no", candidate);
                    if (Convert.ToInt32(chk.ExecuteScalar()) == 0)
                    {
                        return Ok(new { success = true, noteNo = candidate });
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
