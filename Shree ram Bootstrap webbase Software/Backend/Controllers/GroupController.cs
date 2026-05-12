using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;

namespace Backend
{
    [ApiController]
    [Route("api/group")]
    public class GroupController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var list = new List<object>();
                using var c = DbHelper.GetConn();
                using var cmd = c.CreateCommand();
                cmd.CommandText = "SELECT * FROM SocGroup ORDER BY GrpMainId, GrpName";
                using var r = cmd.ExecuteReader();
                while (r.Read())
                    list.Add(new {
                        SocGroupId   = Convert.ToInt32(r["SocGroupId"]),
                        GrpName      = r["GrpName"].ToString(),
                        GrpMainId    = r["GrpMainId"] != DBNull.Value ? Convert.ToInt32(r["GrpMainId"]) : 0,
                        GrpPrimaryId = r["GrpPrimaryId"] != DBNull.Value ? Convert.ToInt32(r["GrpPrimaryId"]) : 0,
                        GrpPrimaryName = r["GrpPrimaryName"]?.ToString() ?? "",
                        Grpmarname   = r["Grpmarname"]?.ToString() ?? "",
                        Grpsubtotal  = r["Grpsubtotal"]?.ToString() ?? "False",
                        GrpType      = r["GrpType"] != DBNull.Value ? Convert.ToInt32(r["GrpType"]) : 1
                    });
                return Ok(new { success = true, data = list });
            }
            catch (Exception ex) { return Ok(new { success = false, message = ex.Message, data = new List<object>() }); }
        }

        [HttpPost]
        public IActionResult Create([FromBody] GrpReq req)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(req.GrpName)) return BadRequest(new { success = false, message = "Group Name required" });
                if (req.GrpMainId <= 0) return BadRequest(new { success = false, message = "Main group required" });

                using var c = DbHelper.GetConn();
                using var ins = c.CreateCommand();
                ins.CommandText = @"INSERT INTO SocGroup(GrpName,GrpMainId,GrpType,GrpPrimaryName,Grpmarname,Grpsubtotal)
                    VALUES(@n,@m,1,@pn,@mn,@st);
                    UPDATE SocGroup SET GrpPrimaryId=last_insert_rowid() WHERE SocGroupId=last_insert_rowid();";
                ins.Parameters.AddWithValue("@n",  req.GrpName.Trim());
                ins.Parameters.AddWithValue("@m",  req.GrpMainId);
                ins.Parameters.AddWithValue("@pn", string.IsNullOrWhiteSpace(req.GrpPrimaryName) ? req.GrpName.Trim() : req.GrpPrimaryName.Trim());
                ins.Parameters.AddWithValue("@mn", req.Grpmarname ?? "");
                ins.Parameters.AddWithValue("@st", req.Grpsubtotal ?? "False");
                ins.ExecuteNonQuery();
                return Ok(new { success = true, message = "Group created" });
            }
            catch (Exception ex) { return BadRequest(new { success = false, message = ex.Message }); }
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] GrpReq req)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(req.GrpName)) return BadRequest(new { success = false, message = "Group Name required" });
                using var c = DbHelper.GetConn();
                using var upd = c.CreateCommand();
                upd.CommandText = @"UPDATE SocGroup SET GrpName=@n,GrpMainId=@m,
                    GrpPrimaryName=@pn,Grpmarname=@mn,Grpsubtotal=@st WHERE SocGroupId=@id";
                upd.Parameters.AddWithValue("@n",  req.GrpName.Trim());
                upd.Parameters.AddWithValue("@m",  req.GrpMainId);
                upd.Parameters.AddWithValue("@pn", string.IsNullOrWhiteSpace(req.GrpPrimaryName) ? req.GrpName.Trim() : req.GrpPrimaryName.Trim());
                upd.Parameters.AddWithValue("@mn", req.Grpmarname ?? "");
                upd.Parameters.AddWithValue("@st", req.Grpsubtotal ?? "False");
                upd.Parameters.AddWithValue("@id", id);
                return upd.ExecuteNonQuery() > 0
                    ? Ok(new { success = true, message = "Group updated" })
                    : NotFound(new { success = false, message = "Group not found" });
            }
            catch (Exception ex) { return BadRequest(new { success = false, message = ex.Message }); }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                using var c = DbHelper.GetConn();

                // Check linked accounts
                using (var chk = c.CreateCommand())
                {
                    chk.CommandText = "SELECT COUNT(*) FROM SocAccount WHERE SocSubGroupId=@id AND IsDeleted=0";
                    chk.Parameters.AddWithValue("@id", id);
                    if (Convert.ToInt32(chk.ExecuteScalar()) > 0)
                        return BadRequest(new { success = false, message = "Cannot delete — group has linked accounts" });
                }
                // Check child groups
                using (var chk2 = c.CreateCommand())
                {
                    chk2.CommandText = "SELECT COUNT(*) FROM SocGroup WHERE GrpPrimaryId=@id AND SocGroupId!=@id";
                    chk2.Parameters.AddWithValue("@id", id);
                    if (Convert.ToInt32(chk2.ExecuteScalar()) > 0)
                        return BadRequest(new { success = false, message = "Cannot delete — group has child groups" });
                }

                using var cmd = c.CreateCommand();
                cmd.CommandText = "DELETE FROM SocGroup WHERE SocGroupId=@id";
                cmd.Parameters.AddWithValue("@id", id);
                return cmd.ExecuteNonQuery() > 0
                    ? Ok(new { success = true, message = "Group deleted" })
                    : NotFound(new { success = false, message = "Not found" });
            }
            catch (Exception ex) { return BadRequest(new { success = false, message = ex.Message }); }
        }

        [HttpDelete("bulk")]
        public IActionResult BulkDelete([FromBody] int[] ids)
        {
            if (ids == null || ids.Length == 0) return BadRequest(new { success = false, message = "No IDs" });
            var errors = new List<string>();
            int done = 0;
            try
            {
                using var c = DbHelper.GetConn();
                foreach (var id in ids)
                {
                    try
                    {
                        using var chk = c.CreateCommand();
                        chk.CommandText = "SELECT COUNT(*) FROM SocAccount WHERE SocSubGroupId=@id AND IsDeleted=0";
                        chk.Parameters.AddWithValue("@id", id);
                        if (Convert.ToInt32(chk.ExecuteScalar()) > 0) { errors.Add($"Group {id} has linked accounts"); continue; }

                        using var del = c.CreateCommand();
                        del.CommandText = "DELETE FROM SocGroup WHERE SocGroupId=@id";
                        del.Parameters.AddWithValue("@id", id);
                        done += del.ExecuteNonQuery();
                    }
                    catch (Exception ex) { errors.Add($"Group {id}: {ex.Message}"); }
                }
            }
            catch (Exception ex) { return BadRequest(new { success = false, message = ex.Message }); }

            return Ok(new { success = true, deleted = done, errors });
        }

        public class GrpReq
        {
            public string GrpName { get; set; }
            public int GrpMainId { get; set; }
            public string GrpPrimaryName { get; set; }
            public string Grpmarname { get; set; }
            public string Grpsubtotal { get; set; } = "False";
        }
    }
}
