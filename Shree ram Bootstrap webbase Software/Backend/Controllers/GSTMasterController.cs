using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using System;

namespace Backend.Controllers
{
    [ApiController]
    [Route("api/gst-master")]
    public class GSTMasterController : ControllerBase
    {
        private readonly string _sqliteDbPath = System.IO.Path.Combine(System.AppContext.BaseDirectory, "Data", "ShreeRam.sqlite");

        public class GSTConfigModel
        {
            public string CgstAccCode { get; set; }
            public string CgstAccName { get; set; }
            public string SgstAccCode { get; set; }
            public string SgstAccName { get; set; }
            public bool InterestOnDuesApplyGst { get; set; }
            public bool InterestOnDuesApplyGstExemptLimit { get; set; }
            public double CgstRate { get; set; }
            public double SgstRate { get; set; }
            public int CgstRound { get; set; }
            public int SgstRound { get; set; }
            public double ExemptLimit { get; set; }
        }

        private SqliteConnection GetConn()
        {
            var cs = new SqliteConnectionStringBuilder { DataSource = _sqliteDbPath, Mode = SqliteOpenMode.ReadWriteCreate }.ToString();
            return new SqliteConnection(cs);
        }

        private string S(SqliteDataReader r, string n) { try { return r[n]?.ToString() ?? ""; } catch { return ""; } }
        private double D(SqliteDataReader r, string n) { try { return r[n] != DBNull.Value ? Convert.ToDouble(r[n]) : 0; } catch { return 0; } }
        private int I(SqliteDataReader r, string n) { try { return r[n] != DBNull.Value ? Convert.ToInt32(r[n]) : 0; } catch { return 0; } }
        private bool B(SqliteDataReader r, string n) { try { return r[n] != DBNull.Value && Convert.ToInt32(r[n]) != 0; } catch { return false; } }

        [HttpGet("settings")]
        public IActionResult GetSettings()
        {
            try
            {
                using var conn = GetConn(); conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM GSTConfig LIMIT 1";
                using var r = cmd.ExecuteReader();
                if (r.Read())
                {
                    var config = new GSTConfigModel
                    {
                        CgstAccCode = S(r, "CgstAccCode"),
                        CgstAccName = S(r, "CgstAccName"),
                        SgstAccCode = S(r, "SgstAccCode"),
                        SgstAccName = S(r, "SgstAccName"),
                        InterestOnDuesApplyGst = B(r, "InterestOnDuesApplyGst"),
                        InterestOnDuesApplyGstExemptLimit = B(r, "InterestOnDuesApplyGstExemptLimit"),
                        CgstRate = D(r, "CgstRate"),
                        SgstRate = D(r, "SgstRate"),
                        CgstRound = I(r, "CgstRound"),
                        SgstRound = I(r, "SgstRound"),
                        ExemptLimit = D(r, "ExemptLimit")
                    };
                    return Ok(config);
                }

                // If somehow database is empty, return standard defaults
                var defaults = new GSTConfigModel
                {
                    CgstAccCode = "LIA-1032",
                    CgstAccName = "CGST - 9%",
                    SgstAccCode = "LIA-1033",
                    SgstAccName = "SGST - 9%",
                    InterestOnDuesApplyGst = true,
                    InterestOnDuesApplyGstExemptLimit = false,
                    CgstRate = 9.0,
                    SgstRate = 9.0,
                    CgstRound = 0,
                    SgstRound = 0,
                    ExemptLimit = 7500.0
                };
                return Ok(defaults);
            }
            catch (Exception ex) { return Ok(new { success = false, message = ex.Message }); }
        }

        [HttpPost("settings")]
        public IActionResult SaveSettings([FromBody] GSTConfigModel req)
        {
            try
            {
                using var conn = GetConn(); conn.Open();
                
                // Clear any existing configuration to ensure only 1 row exists
                using (var deleteCmd = conn.CreateCommand())
                {
                    deleteCmd.CommandText = "DELETE FROM GSTConfig";
                    deleteCmd.ExecuteNonQuery();
                }

                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"INSERT INTO GSTConfig (CgstAccCode, CgstAccName, SgstAccCode, SgstAccName, InterestOnDuesApplyGst, InterestOnDuesApplyGstExemptLimit, CgstRate, SgstRate, CgstRound, SgstRound, ExemptLimit)
                    VALUES(@CgstAccCode, @CgstAccName, @SgstAccCode, @SgstAccName, @InterestOnDuesApplyGst, @InterestOnDuesApplyGstExemptLimit, @CgstRate, @SgstRate, @CgstRound, @SgstRound, @ExemptLimit)";
                
                cmd.Parameters.AddWithValue("@CgstAccCode", req.CgstAccCode ?? "LIA-1032");
                cmd.Parameters.AddWithValue("@CgstAccName", req.CgstAccName ?? "CGST - 9%");
                cmd.Parameters.AddWithValue("@SgstAccCode", req.SgstAccCode ?? "LIA-1033");
                cmd.Parameters.AddWithValue("@SgstAccName", req.SgstAccName ?? "SGST - 9%");
                cmd.Parameters.AddWithValue("@InterestOnDuesApplyGst", req.InterestOnDuesApplyGst ? 1 : 0);
                cmd.Parameters.AddWithValue("@InterestOnDuesApplyGstExemptLimit", req.InterestOnDuesApplyGstExemptLimit ? 1 : 0);
                cmd.Parameters.AddWithValue("@CgstRate", req.CgstRate);
                cmd.Parameters.AddWithValue("@SgstRate", req.SgstRate);
                cmd.Parameters.AddWithValue("@CgstRound", req.CgstRound);
                cmd.Parameters.AddWithValue("@SgstRound", req.SgstRound);
                cmd.Parameters.AddWithValue("@ExemptLimit", req.ExemptLimit);
                cmd.ExecuteNonQuery();

                return Ok(new { success = true, message = "GST Configuration saved successfully.", data = req });
            }
            catch (Exception ex) { return BadRequest(new { success = false, message = ex.Message }); }
        }
    }
}
