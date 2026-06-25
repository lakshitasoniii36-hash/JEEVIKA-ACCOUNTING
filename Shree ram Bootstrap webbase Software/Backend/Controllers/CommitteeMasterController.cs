using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;

namespace Backend.Controllers
{
    [ApiController]
    [Route("api/committee-master")]
    public class CommitteeMasterController : ControllerBase
    {
        private readonly string _sqliteDbPath = System.IO.Path.Combine(System.AppContext.BaseDirectory, "Data", "ShreeRam.sqlite");

        public class CommitteeMemberModel
        {
            public int CommMemberId { get; set; }
            public string Name { get; set; }
            public string Designation { get; set; }
            public string UnitNo { get; set; }
            public string Phone { get; set; }
            public string StartDate { get; set; }
            public string EndDate { get; set; }
            public bool IsSignatory { get; set; }
            public bool IsActive { get; set; }
        }

        private SqliteConnection GetConn()
        {
            var cs = new SqliteConnectionStringBuilder { DataSource = _sqliteDbPath, Mode = SqliteOpenMode.ReadWriteCreate }.ToString();
            return new SqliteConnection(cs);
        }

        private string S(SqliteDataReader r, string n) { try { return r[n]?.ToString() ?? ""; } catch { return ""; } }
        private int I(SqliteDataReader r, string n) { try { return r[n] != DBNull.Value ? Convert.ToInt32(r[n]) : 0; } catch { return 0; } }
        private bool B(SqliteDataReader r, string n) { try { return r[n] != DBNull.Value && Convert.ToInt32(r[n]) != 0; } catch { return false; } }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var list = new List<CommitteeMemberModel>();
                using var conn = GetConn(); conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM CommitteeMember ORDER BY CommMemberId";
                using var r = cmd.ExecuteReader();
                while (r.Read())
                {
                    list.Add(new CommitteeMemberModel
                    {
                        CommMemberId = I(r, "CommMemberId"),
                        Name = S(r, "Name"),
                        Designation = S(r, "Designation"),
                        UnitNo = S(r, "UnitNo"),
                        Phone = S(r, "Phone"),
                        StartDate = S(r, "StartDate"),
                        EndDate = S(r, "EndDate"),
                        IsSignatory = B(r, "IsSignatory"),
                        IsActive = B(r, "IsActive")
                    });
                }
                return Ok(list);
            }
            catch (Exception ex) { return Ok(new { success = false, message = ex.Message }); }
        }

        [HttpPost]
        public IActionResult Create([FromBody] CommitteeMemberModel req)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(req.Name)) return BadRequest(new { success = false, message = "Member Name required" });
                using var conn = GetConn(); conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"INSERT INTO CommitteeMember (Name, Designation, UnitNo, Phone, StartDate, EndDate, IsSignatory, IsActive)
                    VALUES(@Name, @Designation, @UnitNo, @Phone, @StartDate, @EndDate, @IsSignatory, @IsActive)";
                cmd.Parameters.AddWithValue("@Name", req.Name ?? "");
                cmd.Parameters.AddWithValue("@Designation", req.Designation ?? "");
                cmd.Parameters.AddWithValue("@UnitNo", req.UnitNo ?? "");
                cmd.Parameters.AddWithValue("@Phone", req.Phone ?? "");
                cmd.Parameters.AddWithValue("@StartDate", req.StartDate ?? "");
                cmd.Parameters.AddWithValue("@EndDate", req.EndDate ?? "");
                cmd.Parameters.AddWithValue("@IsSignatory", req.IsSignatory ? 1 : 0);
                cmd.Parameters.AddWithValue("@IsActive", req.IsActive ? 1 : 0);
                cmd.ExecuteNonQuery();

                using var lastIdCmd = conn.CreateCommand();
                lastIdCmd.CommandText = "SELECT last_insert_rowid()";
                var id = Convert.ToInt32(lastIdCmd.ExecuteScalar());
                req.CommMemberId = id;
                return Ok(new { success = true, message = "Committee member created", data = req });
            }
            catch (Exception ex) { return BadRequest(new { success = false, message = ex.Message }); }
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] CommitteeMemberModel req)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(req.Name)) return BadRequest(new { success = false, message = "Member Name required" });
                using var conn = GetConn(); conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"UPDATE CommitteeMember SET Name=@Name, Designation=@Designation, UnitNo=@UnitNo,
                    Phone=@Phone, StartDate=@StartDate, EndDate=@EndDate, IsSignatory=@IsSignatory, IsActive=@IsActive
                    WHERE CommMemberId=@id";
                cmd.Parameters.AddWithValue("@Name", req.Name ?? "");
                cmd.Parameters.AddWithValue("@Designation", req.Designation ?? "");
                cmd.Parameters.AddWithValue("@UnitNo", req.UnitNo ?? "");
                cmd.Parameters.AddWithValue("@Phone", req.Phone ?? "");
                cmd.Parameters.AddWithValue("@StartDate", req.StartDate ?? "");
                cmd.Parameters.AddWithValue("@EndDate", req.EndDate ?? "");
                cmd.Parameters.AddWithValue("@IsSignatory", req.IsSignatory ? 1 : 0);
                cmd.Parameters.AddWithValue("@IsActive", req.IsActive ? 1 : 0);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                return Ok(new { success = true, message = "Committee member updated", data = req });
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
                cmd.CommandText = "DELETE FROM CommitteeMember WHERE CommMemberId=@id";
                cmd.Parameters.AddWithValue("@id", id);
                var rows = cmd.ExecuteNonQuery();
                return rows > 0 ? Ok(new { success = true, message = "Deleted" })
                    : NotFound(new { success = false, message = "Not found" });
            }
            catch (Exception ex) { return BadRequest(new { success = false, message = ex.Message }); }
        }
    }
}
