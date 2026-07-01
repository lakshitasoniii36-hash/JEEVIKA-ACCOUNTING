using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Backend.Controllers
{
    [ApiController]
    [Route("api/bill-type-master")]
    public class BillTypeMasterController : ControllerBase
    {
        private readonly string _sqliteDbPath = System.IO.Path.Combine(System.AppContext.BaseDirectory, "Data", "ShreeRam.sqlite");

        public class BillHeadModel
        {
            [JsonPropertyName("no")]
            public int No { get; set; }
            [JsonPropertyName("accCode")]
            public string AccCode { get; set; }
            [JsonPropertyName("accName")]
            public string AccName { get; set; }
            [JsonPropertyName("gstApp")]
            public bool GstApp { get; set; }
            [JsonPropertyName("gstExm")]
            public bool GstExm { get; set; }
        }

        public class BillTypeDetailModel
        {
            [JsonPropertyName("heads")]
            public List<BillHeadModel> Heads { get; set; } = new List<BillHeadModel>();

            [JsonPropertyName("notes")]
            public List<string> Notes { get; set; } = new List<string>();

            [JsonPropertyName("qrImage")]
            public string QrImage { get; set; }

            [JsonPropertyName("signatureImage")]
            public string SignatureImage { get; set; }

            [JsonPropertyName("interestMethod")]
            public string InterestMethod { get; set; }

            [JsonPropertyName("interestRate")]
            public string InterestRate { get; set; }

            [JsonPropertyName("interestType")]
            public string InterestType { get; set; }

            [JsonPropertyName("grossDate")]
            public string GrossDate { get; set; }

            [JsonPropertyName("interestPriority")]
            public string InterestPriority { get; set; }

            [JsonPropertyName("billMethod")]
            public string BillMethod { get; set; }

            [JsonPropertyName("billMonths")]
            public string BillMonths { get; set; }

            [JsonPropertyName("billDate")]
            public string BillDate { get; set; }

            [JsonPropertyName("billDue")]
            public string BillDue { get; set; }

            [JsonPropertyName("billPeriod")]
            public string BillPeriod { get; set; }

            [JsonPropertyName("dynamicQR")]
            public bool DynamicQR { get; set; }

            [JsonPropertyName("showBillPeriodNotes")]
            public bool ShowBillPeriodNotes { get; set; } = false;
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
                var dict = new Dictionary<string, BillTypeDetailModel>();
                using var conn = GetConn(); conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM BillTypeConfig";
                using var r = cmd.ExecuteReader();
                while (r.Read())
                {
                    var typeName = S(r, "TypeName");
                    var headsJson = S(r, "HeadsJson");
                    var notesJson = S(r, "NotesJson");

                    var detail = new BillTypeDetailModel
                    {
                        QrImage = S(r, "QrImage"),
                        SignatureImage = S(r, "SignatureImage"),
                        InterestMethod = S(r, "InterestMethod"),
                        InterestRate = S(r, "InterestRate"),
                        InterestType = S(r, "InterestType"),
                        GrossDate = S(r, "GrossDate"),
                        InterestPriority = S(r, "InterestPriority"),
                        BillMethod = S(r, "BillMethod"),
                        BillMonths = S(r, "BillMonths"),
                        BillDate = S(r, "BillDate"),
                        BillDue = S(r, "BillDue"),
                        BillPeriod = S(r, "BillPeriod"),
                        DynamicQR = B(r, "DynamicQr"),
                        ShowBillPeriodNotes = B(r, "ShowBillPeriodNotes")
                    };

                    try
                    {
                        if (!string.IsNullOrWhiteSpace(headsJson))
                            detail.Heads = JsonSerializer.Deserialize<List<BillHeadModel>>(headsJson) ?? new List<BillHeadModel>();
                    }
                    catch { }

                    try
                    {
                        if (!string.IsNullOrWhiteSpace(notesJson))
                            detail.Notes = JsonSerializer.Deserialize<List<string>>(notesJson) ?? new List<string>();
                    }
                    catch { }

                    dict[typeName] = detail;
                }

                return Ok(dict);
            }
            catch (Exception ex) { return Ok(new { success = false, message = ex.Message }); }
        }

        [HttpPost]
        public IActionResult SaveConfig([FromBody] Dictionary<string, BillTypeDetailModel> req)
        {
            try
            {
                if (req == null || req.Count == 0) return BadRequest(new { success = false, message = "Invalid data" });
                using var conn = GetConn(); conn.Open();

                using (var deleteCmd = conn.CreateCommand())
                {
                    deleteCmd.CommandText = "DELETE FROM BillTypeConfig";
                    deleteCmd.ExecuteNonQuery();
                }

                foreach (var kvp in req)
                {
                    var typeName = kvp.Key;
                    var detail = kvp.Value;

                    var headsJson = JsonSerializer.Serialize(detail.Heads);
                    var notesJson = JsonSerializer.Serialize(detail.Notes);

                    using var cmd = conn.CreateCommand();
                    cmd.CommandText = @"INSERT INTO BillTypeConfig (TypeName, HeadsJson, NotesJson, QrImage, SignatureImage, InterestMethod, InterestRate, InterestType, GrossDate, InterestPriority, BillMethod, BillMonths, BillDate, BillDue, BillPeriod, DynamicQr, ShowBillPeriodNotes)
                        VALUES(@TypeName, @HeadsJson, @NotesJson, @QrImage, @SignatureImage, @InterestMethod, @InterestRate, @InterestType, @GrossDate, @InterestPriority, @BillMethod, @BillMonths, @BillDate, @BillDue, @BillPeriod, @DynamicQr, @ShowBillPeriodNotes)";
                    
                    cmd.Parameters.AddWithValue("@TypeName", typeName);
                    cmd.Parameters.AddWithValue("@HeadsJson", headsJson);
                    cmd.Parameters.AddWithValue("@NotesJson", notesJson);
                    cmd.Parameters.AddWithValue("@QrImage", detail.QrImage ?? "");
                    cmd.Parameters.AddWithValue("@SignatureImage", detail.SignatureImage ?? "");
                    cmd.Parameters.AddWithValue("@InterestMethod", detail.InterestMethod ?? "M-CM");
                    cmd.Parameters.AddWithValue("@InterestRate", detail.InterestRate ?? "21%");
                    cmd.Parameters.AddWithValue("@InterestType", detail.InterestType ?? "Simple");
                    cmd.Parameters.AddWithValue("@GrossDate", detail.GrossDate ?? "");
                    cmd.Parameters.AddWithValue("@InterestPriority", detail.InterestPriority ?? "Interest First");
                    cmd.Parameters.AddWithValue("@BillMethod", detail.BillMethod ?? "Monthly");
                    cmd.Parameters.AddWithValue("@BillMonths", detail.BillMonths ?? "1");
                    cmd.Parameters.AddWithValue("@BillDate", detail.BillDate ?? "01");
                    cmd.Parameters.AddWithValue("@BillDue", detail.BillDue ?? "15");
                    cmd.Parameters.AddWithValue("@BillPeriod", detail.BillPeriod ?? "");
                    cmd.Parameters.AddWithValue("@DynamicQr", detail.DynamicQR ? 1 : 0);
                    cmd.Parameters.AddWithValue("@ShowBillPeriodNotes", detail.ShowBillPeriodNotes ? 1 : 0);
                    
                    cmd.ExecuteNonQuery();
                }

                return Ok(new { success = true, message = "Bill type config saved successfully." });
            }
            catch (Exception ex) { return BadRequest(new { success = false, message = ex.Message }); }
        }
    }
}
