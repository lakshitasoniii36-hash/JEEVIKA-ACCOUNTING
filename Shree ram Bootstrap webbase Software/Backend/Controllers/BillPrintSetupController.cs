using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using System;

namespace Backend.Controllers
{
    [ApiController]
    [Route("api/bill-print-setup")]
    public class BillPrintSetupController : ControllerBase
    {
        private readonly string _sqliteDbPath = System.IO.Path.Combine(System.AppContext.BaseDirectory, "Data", "ShreeRam.sqlite");

        public class BillPrintSetupModel
        {
            public string Format { get; set; }
            public string Heading { get; set; }
            public bool Bldg { get; set; }
            public bool Srno { get; set; }
            public bool Newpage { get; set; }
            public bool Arrears { get; set; }
            public bool Receipt { get; set; }
            public bool Blankhead { get; set; }
            public string Qr { get; set; }
            public string Sign { get; set; }
        }

        private SqliteConnection GetConn()
        {
            var cs = new SqliteConnectionStringBuilder { DataSource = _sqliteDbPath, Mode = SqliteOpenMode.ReadWriteCreate }.ToString();
            return new SqliteConnection(cs);
        }

        private string S(SqliteDataReader r, string n) { try { return r[n]?.ToString() ?? ""; } catch { return ""; } }
        private bool B(SqliteDataReader r, string n) { try { return r[n] != DBNull.Value && Convert.ToInt32(r[n]) != 0; } catch { return false; } }

        [HttpGet]
        public IActionResult GetConfig()
        {
            try
            {
                using var conn = GetConn(); conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM BillPrintSetup LIMIT 1";
                using var r = cmd.ExecuteReader();
                if (r.Read())
                {
                    var config = new BillPrintSetupModel
                    {
                        Format = S(r, "Format"),
                        Heading = S(r, "Heading"),
                        Bldg = B(r, "Bldg"),
                        Srno = B(r, "Srno"),
                        Newpage = B(r, "Newpage"),
                        Arrears = B(r, "Arrears"),
                        Receipt = B(r, "Receipt"),
                        Blankhead = B(r, "Blankhead"),
                        Qr = S(r, "Qr"),
                        Sign = S(r, "Sign")
                    };
                    return Ok(config);
                }

                // Default fallback
                var defaults = new BillPrintSetupModel
                {
                    Format = "G01",
                    Heading = "MAINTENANCE BILL",
                    Bldg = true,
                    Srno = true,
                    Newpage = false,
                    Arrears = true,
                    Receipt = false,
                    Blankhead = false,
                    Qr = "upi",
                    Sign = "sig"
                };
                return Ok(defaults);
            }
            catch (Exception ex) { return Ok(new { success = false, message = ex.Message }); }
        }

        [HttpPost]
        public IActionResult SaveConfig([FromBody] BillPrintSetupModel req)
        {
            try
            {
                using var conn = GetConn(); conn.Open();
                
                using (var deleteCmd = conn.CreateCommand())
                {
                    deleteCmd.CommandText = "DELETE FROM BillPrintSetup";
                    deleteCmd.ExecuteNonQuery();
                }

                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"INSERT INTO BillPrintSetup (Format, Heading, Bldg, Srno, Newpage, Arrears, Receipt, Blankhead, Qr, Sign)
                    VALUES(@Format, @Heading, @Bldg, @Srno, @Newpage, @Arrears, @Receipt, @Blankhead, @Qr, @Sign)";
                
                cmd.Parameters.AddWithValue("@Format", req.Format ?? "G01");
                cmd.Parameters.AddWithValue("@Heading", req.Heading ?? "MAINTENANCE BILL");
                cmd.Parameters.AddWithValue("@Bldg", req.Bldg ? 1 : 0);
                cmd.Parameters.AddWithValue("@Srno", req.Srno ? 1 : 0);
                cmd.Parameters.AddWithValue("@Newpage", req.Newpage ? 1 : 0);
                cmd.Parameters.AddWithValue("@Arrears", req.Arrears ? 1 : 0);
                cmd.Parameters.AddWithValue("@Receipt", req.Receipt ? 1 : 0);
                cmd.Parameters.AddWithValue("@Blankhead", req.Blankhead ? 1 : 0);
                cmd.Parameters.AddWithValue("@Qr", req.Qr ?? "upi");
                cmd.Parameters.AddWithValue("@Sign", req.Sign ?? "sig");
                cmd.ExecuteNonQuery();

                return Ok(new { success = true, message = "Bill print settings saved successfully.", data = req });
            }
            catch (Exception ex) { return BadRequest(new { success = false, message = ex.Message }); }
        }
    }
}
