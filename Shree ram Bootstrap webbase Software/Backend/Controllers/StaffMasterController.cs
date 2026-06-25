using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;

namespace Backend.Controllers
{
    [ApiController]
    [Route("api/staff-master")]
    public class StaffMasterController : ControllerBase
    {
        private readonly string _sqliteDbPath = System.IO.Path.Combine(System.AppContext.BaseDirectory, "Data", "ShreeRam.sqlite");

        public class StaffMemberModel
        {
            public int StaffId { get; set; }
            public string Code { get; set; }
            public string Type { get; set; }
            public string Category { get; set; }
            public string Name { get; set; }
            public string Phone { get; set; }
            public string Phone2 { get; set; }
            public string Email { get; set; }
            public double Cost { get; set; }
            public string StartDate { get; set; }
            public string EndDate { get; set; }
            public string Status { get; set; }
            public string BankHolder { get; set; }
            public string BankAccount { get; set; }
            public string BankName { get; set; }
            public string BankIfsc { get; set; }
            public string BankBranch { get; set; }
            public string Pan { get; set; }
            public string Gstin { get; set; }
            public string TdsSection { get; set; }
            public double TdsRate { get; set; }
            public string PfNo { get; set; }
            public string EsicNo { get; set; }
            public bool IsAuthorized { get; set; }
            public string Notes { get; set; }
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

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var list = new List<StaffMemberModel>();
                using var conn = GetConn(); conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM StaffMember ORDER BY StaffId";
                using var r = cmd.ExecuteReader();
                while (r.Read())
                {
                    list.Add(new StaffMemberModel
                    {
                        StaffId = I(r, "StaffId"),
                        Code = S(r, "Code"),
                        Type = S(r, "Type"),
                        Category = S(r, "Category"),
                        Name = S(r, "Name"),
                        Phone = S(r, "Phone"),
                        Phone2 = S(r, "Phone2"),
                        Email = S(r, "Email"),
                        Cost = D(r, "Cost"),
                        StartDate = S(r, "StartDate"),
                        EndDate = S(r, "EndDate"),
                        Status = S(r, "Status"),
                        BankHolder = S(r, "BankHolder"),
                        BankAccount = S(r, "BankAccount"),
                        BankName = S(r, "BankName"),
                        BankIfsc = S(r, "BankIfsc"),
                        BankBranch = S(r, "BankBranch"),
                        Pan = S(r, "Pan"),
                        Gstin = S(r, "Gstin"),
                        TdsSection = S(r, "TdsSection"),
                        TdsRate = D(r, "TdsRate"),
                        PfNo = S(r, "PfNo"),
                        EsicNo = S(r, "EsicNo"),
                        IsAuthorized = B(r, "IsAuthorized"),
                        Notes = S(r, "Notes")
                    });
                }
                return Ok(list);
            }
            catch (Exception ex) { return Ok(new { success = false, message = ex.Message }); }
        }

        [HttpPost]
        public IActionResult Create([FromBody] StaffMemberModel req)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(req.Name)) return BadRequest(new { success = false, message = "Name required" });
                if (string.IsNullOrWhiteSpace(req.Code)) return BadRequest(new { success = false, message = "Code required" });
                using var conn = GetConn(); conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"INSERT INTO StaffMember (Code, Type, Category, Name, Phone, Phone2, Email, Cost, StartDate, EndDate, Status, BankHolder, BankAccount, BankName, BankIfsc, BankBranch, Pan, Gstin, TdsSection, TdsRate, PfNo, EsicNo, IsAuthorized, Notes)
                    VALUES(@Code, @Type, @Category, @Name, @Phone, @Phone2, @Email, @Cost, @StartDate, @EndDate, @Status, @BankHolder, @BankAccount, @BankName, @BankIfsc, @BankBranch, @Pan, @Gstin, @TdsSection, @TdsRate, @PfNo, @EsicNo, @IsAuthorized, @Notes)";
                AddParams(cmd, req);
                cmd.ExecuteNonQuery();

                using var lastIdCmd = conn.CreateCommand();
                lastIdCmd.CommandText = "SELECT last_insert_rowid()";
                var id = Convert.ToInt32(lastIdCmd.ExecuteScalar());
                req.StaffId = id;
                return Ok(new { success = true, message = "Staff member created", data = req });
            }
            catch (Exception ex) { return BadRequest(new { success = false, message = ex.Message }); }
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] StaffMemberModel req)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(req.Name)) return BadRequest(new { success = false, message = "Name required" });
                using var conn = GetConn(); conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"UPDATE StaffMember SET Code=@Code, Type=@Type, Category=@Category, Name=@Name, Phone=@Phone, Phone2=@Phone2, Email=@Email, Cost=@Cost, StartDate=@StartDate, EndDate=@EndDate, Status=@Status, BankHolder=@BankHolder, BankAccount=@BankAccount, BankName=@BankName, BankIfsc=@BankIfsc, BankBranch=@BankBranch, Pan=@Pan, Gstin=@Gstin, TdsSection=@TdsSection, TdsRate=@TdsRate, PfNo=@PfNo, EsicNo=@EsicNo, IsAuthorized=@IsAuthorized, Notes=@Notes
                    WHERE StaffId=@id";
                AddParams(cmd, req);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                return Ok(new { success = true, message = "Staff member updated", data = req });
            }
            catch (Exception ex) { return BadRequest(new { success = false, message = ex.Message }); }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                using var conn = GetConn(); conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM StaffMember WHERE StaffId=@id";
                cmd.Parameters.AddWithValue("@id", id);
                var rows = cmd.ExecuteNonQuery();
                return rows > 0 ? Ok(new { success = true, message = "Deleted" })
                    : NotFound(new { success = false, message = "Not found" });
            }
            catch (Exception ex) { return BadRequest(new { success = false, message = ex.Message }); }
        }

        private void AddParams(SqliteCommand cmd, StaffMemberModel r)
        {
            cmd.Parameters.AddWithValue("@Code", r.Code ?? "");
            cmd.Parameters.AddWithValue("@Type", r.Type ?? "Staff");
            cmd.Parameters.AddWithValue("@Category", r.Category ?? "");
            cmd.Parameters.AddWithValue("@Name", r.Name ?? "");
            cmd.Parameters.AddWithValue("@Phone", r.Phone ?? "");
            cmd.Parameters.AddWithValue("@Phone2", r.Phone2 ?? "");
            cmd.Parameters.AddWithValue("@Email", r.Email ?? "");
            cmd.Parameters.AddWithValue("@Cost", r.Cost);
            cmd.Parameters.AddWithValue("@StartDate", r.StartDate ?? "");
            cmd.Parameters.AddWithValue("@EndDate", r.EndDate ?? "");
            cmd.Parameters.AddWithValue("@Status", r.Status ?? "Active");
            cmd.Parameters.AddWithValue("@BankHolder", r.BankHolder ?? "");
            cmd.Parameters.AddWithValue("@BankAccount", r.BankAccount ?? "");
            cmd.Parameters.AddWithValue("@BankName", r.BankName ?? "");
            cmd.Parameters.AddWithValue("@BankIfsc", r.BankIfsc ?? "");
            cmd.Parameters.AddWithValue("@BankBranch", r.BankBranch ?? "");
            cmd.Parameters.AddWithValue("@Pan", r.Pan ?? "");
            cmd.Parameters.AddWithValue("@Gstin", r.Gstin ?? "");
            cmd.Parameters.AddWithValue("@TdsSection", r.TdsSection ?? "None");
            cmd.Parameters.AddWithValue("@TdsRate", r.TdsRate);
            cmd.Parameters.AddWithValue("@PfNo", r.PfNo ?? "");
            cmd.Parameters.AddWithValue("@EsicNo", r.EsicNo ?? "");
            cmd.Parameters.AddWithValue("@IsAuthorized", r.IsAuthorized ? 1 : 0);
            cmd.Parameters.AddWithValue("@Notes", r.Notes ?? "");
        }
    }
}
