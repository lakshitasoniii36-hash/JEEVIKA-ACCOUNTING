using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;

namespace Backend
{
    [Route("api/workspace")]
    [ApiController]
    public class WorkspaceController : ControllerBase
    {
        [HttpGet("society/active")]
        public IActionResult GetActiveSociety()
        {
            try
            {
                using var c = DbHelper.GetConn();
                using var cmd = c.CreateCommand();
                cmd.CommandText = "SELECT * FROM SocietyInfo WHERE IsDeleted=0 ORDER BY ID LIMIT 1";
                using var r = cmd.ExecuteReader();
                if (r.Read())
                    return Ok(new {
                        name = r["SocietyName"]?.ToString() ?? "Sai Ram Society",
                        code = r["SocietyCode"]?.ToString() ?? "SRS001",
                        year = "2025-26",
                        gstin = r["GSTNumber"]?.ToString() ?? "",
                        address = r["Address"]?.ToString() ?? ""
                    });
            }
            catch { }
            return Ok(new { name = "Sai Ram Society", code = "SRS001", year = "2025-26", gstin = "", address = "" });
        }

        [HttpGet("groups")]
        public IActionResult GetGroups()
        {
            var list = new List<object>();
            try
            {
                using var c = DbHelper.GetConn();
                using var cmd = c.CreateCommand();
                cmd.CommandText = "SELECT SocGroupId,GrpName,GrpMainId FROM SocGroup ORDER BY GrpMainId,GrpName";
                using var r = cmd.ExecuteReader();
                while (r.Read())
                    list.Add(new {
                        id = r["SocGroupId"].ToString(),
                        name = r["GrpName"].ToString(),
                        mainId = r["GrpMainId"].ToString()
                    });
            }
            catch { }
            return Ok(list);
        }

        [HttpGet("accounts")]
        public IActionResult GetAccounts()
        {
            var list = new List<object>();
            try
            {
                using var c = DbHelper.GetConn();
                using var cmd = c.CreateCommand();
                cmd.CommandText = "SELECT AccCode,AccName,SocSubGroupId,GrpMainId FROM SocAccount WHERE IsDeleted=0 ORDER BY AccCode LIMIT 100";
                using var r = cmd.ExecuteReader();
                while (r.Read())
                    list.Add(new {
                        code = r["AccCode"].ToString(),
                        name = r["AccName"].ToString(),
                        groupId = r["SocSubGroupId"].ToString(),
                        mainId = r["GrpMainId"].ToString()
                    });
            }
            catch { }
            return Ok(list);
        }

        [HttpGet("members")]
        public IActionResult GetMembers()
        {
            var list = new List<object>();
            try
            {
                using var c = DbHelper.GetConn();
                using var cmd = c.CreateCommand();
                cmd.CommandText = "SELECT MemberCode,MemberName,FlatNo,Wing,ContactNo FROM SocMember WHERE IsDeleted=0 LIMIT 50";
                using var r = cmd.ExecuteReader();
                while (r.Read())
                    list.Add(new {
                        code = r["MemberCode"].ToString(),
                        name = r["MemberName"].ToString(),
                        flat = r["FlatNo"]?.ToString() ?? "",
                        wing = r["Wing"]?.ToString() ?? "",
                        contact = r["ContactNo"]?.ToString() ?? ""
                    });
            }
            catch { }
            return Ok(list);
        }

        [HttpPost("society/switch")]
        public IActionResult SwitchSociety([FromBody] SwitchReq req)
        {
            if (string.IsNullOrWhiteSpace(req?.societyCode))
                return BadRequest(new { success = false, message = "Society code required" });
            return Ok(new { success = true, message = "Switched", societyCode = req.societyCode, societyName = req.societyName });
        }

        [HttpGet("modules/list")]
        public IActionResult GetModules()
        {
            return Ok(new[] {
                new { id = "society-master", name = "Society Master", category = "master" },
                new { id = "group-master",   name = "Group Master",   category = "master" },
                new { id = "account-master", name = "Account Master", category = "master" },
                new { id = "member-master",  name = "Member Master",  category = "master" },
                new { id = "trial-balance",  name = "Trial Balance",  category = "account-report" },
                new { id = "balance-sheet",  name = "Balance Sheet",  category = "account-report" },
                new { id = "cash-book",      name = "Cash Book",      category = "account-report" },
                new { id = "member-receipt", name = "Member Receipt", category = "transaction" }
            });
        }

        public class SwitchReq { public string societyCode { get; set; } public string societyName { get; set; } }
    }
}
