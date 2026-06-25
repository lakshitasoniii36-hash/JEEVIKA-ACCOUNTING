using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;

namespace Backend
{
    [ApiController]
    [Route("api/voucher-audits")]
    public class VoucherAuditController : ControllerBase
    {
        private readonly string _sqliteDbPath = System.IO.Path.Combine(System.AppContext.BaseDirectory, "Data", "ShreeRam.sqlite");

        public class AuditChecksModel
        {
            public string? VoucherNo { get; set; }
            public bool NoCommSign { get; set; }
            public bool NoRecSign { get; set; }
            public bool NoSupp { get; set; }
            public bool NoMeetApp { get; set; }
            public bool NoTds { get; set; }
            public bool NoVch { get; set; }
            public bool ExcessCash { get; set; }
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

                var dict = new Dictionary<string, AuditChecksModel>();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM SocVoucherAudit";
                    using var r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        string vno = r["VoucherNo"]?.ToString() ?? "";
                        dict[vno] = new AuditChecksModel
                        {
                            VoucherNo = vno,
                            NoCommSign = Convert.ToInt32(r["NoCommSign"]) > 0,
                            NoRecSign = Convert.ToInt32(r["NoRecSign"]) > 0,
                            NoSupp = Convert.ToInt32(r["NoSupp"]) > 0,
                            NoMeetApp = Convert.ToInt32(r["NoMeetApp"]) > 0,
                            NoTds = Convert.ToInt32(r["NoTds"]) > 0,
                            NoVch = Convert.ToInt32(r["NoVch"]) > 0,
                            ExcessCash = Convert.ToInt32(r["ExcessCash"]) > 0
                        };
                    }
                }

                return Ok(new { success = true, data = dict });
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

                using var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM SocVoucherAudit WHERE VoucherNo = @vno LIMIT 1";
                cmd.Parameters.AddWithValue("@vno", voucherNo.Trim());

                using var r = cmd.ExecuteReader();
                if (r.Read())
                {
                    return Ok(new
                    {
                        success = true,
                        data = new AuditChecksModel
                        {
                            VoucherNo = voucherNo,
                            NoCommSign = Convert.ToInt32(r["NoCommSign"]) > 0,
                            NoRecSign = Convert.ToInt32(r["NoRecSign"]) > 0,
                            NoSupp = Convert.ToInt32(r["NoSupp"]) > 0,
                            NoMeetApp = Convert.ToInt32(r["NoMeetApp"]) > 0,
                            NoTds = Convert.ToInt32(r["NoTds"]) > 0,
                            NoVch = Convert.ToInt32(r["NoVch"]) > 0,
                            ExcessCash = Convert.ToInt32(r["ExcessCash"]) > 0
                        }
                    });
                }

                // Default empty check
                return Ok(new
                {
                    success = true,
                    data = new AuditChecksModel { VoucherNo = voucherNo }
                });
            }
            catch (Exception ex)
            {
                return Ok(new { success = false, message = ex.Message });
            }
        }

        [HttpPost]
        public IActionResult Save([FromBody] AuditChecksModel req)
        {
            try
            {
                if (req == null || string.IsNullOrEmpty(req.VoucherNo))
                    return BadRequest(new { success = false, message = "Voucher number required" });

                using var conn = GetConn();
                conn.Open();

                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"INSERT INTO SocVoucherAudit (VoucherNo, NoCommSign, NoRecSign, NoSupp, NoMeetApp, NoTds, NoVch, ExcessCash)
                    VALUES(@vno, @cs, @rs, @ns, @ma, @tds, @nv, @ec)
                    ON CONFLICT(VoucherNo) DO UPDATE SET 
                        NoCommSign=@cs, NoRecSign=@rs, NoSupp=@ns, NoMeetApp=@ma, NoTds=@tds, NoVch=@nv, ExcessCash=@ec";
                
                cmd.Parameters.AddWithValue("@vno", req.VoucherNo.Trim());
                cmd.Parameters.AddWithValue("@cs", req.NoCommSign ? 1 : 0);
                cmd.Parameters.AddWithValue("@rs", req.NoRecSign ? 1 : 0);
                cmd.Parameters.AddWithValue("@ns", req.NoSupp ? 1 : 0);
                cmd.Parameters.AddWithValue("@ma", req.NoMeetApp ? 1 : 0);
                cmd.Parameters.AddWithValue("@tds", req.NoTds ? 1 : 0);
                cmd.Parameters.AddWithValue("@nv", req.NoVch ? 1 : 0);
                cmd.Parameters.AddWithValue("@ec", req.ExcessCash ? 1 : 0);
                cmd.ExecuteNonQuery();

                return Ok(new { success = true, message = "Voucher audit checks saved." });
            }
            catch (Exception ex)
            {
                return Ok(new { success = false, message = ex.Message });
            }
        }
    }
}
