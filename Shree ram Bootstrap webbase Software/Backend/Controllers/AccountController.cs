using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;

namespace Backend
{
    [ApiController]
    [Route("api/account")]
    public class AccountController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var list = new List<object>();
                using var c = DbHelper.GetConn();
                using var cmd = c.CreateCommand();
                cmd.CommandText = @"SELECT a.*, g.GrpName as GroupName 
                    FROM SocAccount a
                    LEFT JOIN SocGroup g ON g.SocGroupId = a.SocSubGroupId
                    WHERE a.IsDeleted = 0 ORDER BY a.AccCode";
                using var r = cmd.ExecuteReader();
                while (r.Read())
                {
                    decimal opBal = r["Op_Bal"] != DBNull.Value ? Convert.ToDecimal(r["Op_Bal"]) : 0;
                    decimal prBal = r["Pr_Bal"] != DBNull.Value ? Convert.ToDecimal(r["Pr_Bal"]) : 0;
                    string opDrCr = r["OpDrCr"] != DBNull.Value ? r["OpDrCr"].ToString() : (opBal < 0 ? "Cr." : "Dr.");
                    string prDrCr = r["PrDrCr"] != DBNull.Value ? r["PrDrCr"].ToString() : (prBal < 0 ? "Cr." : "Dr.");
                    list.Add(new {
                        SocAccId = Convert.ToInt32(r["SocAccId"]),
                        AccCode = r["AccCode"].ToString(),
                        AccName = r["AccName"].ToString(),
                        AccName1 = r["AccName1"]?.ToString() ?? "",
                        AccName2 = r["AccName2"]?.ToString() ?? "",
                        SocSubGroupId = r["SocSubGroupId"] != DBNull.Value ? Convert.ToInt32(r["SocSubGroupId"]) : 0,
                        GrpMainId = r["GrpMainId"] != DBNull.Value ? Convert.ToInt32(r["GrpMainId"]) : 0,
                        GroupName = r["GroupName"]?.ToString() ?? "",
                        OpBal = Math.Abs(opBal),
                        PrBal = Math.Abs(prBal),
                        ClBal = r["Cl_Bal"] != DBNull.Value ? Convert.ToDecimal(r["Cl_Bal"]) : 0,
                        OpDrCr = opDrCr,
                        PrDrCr = prDrCr,
                        AccAdd = r["AccAdd"]?.ToString() ?? "",
                        AccPAN = r["AccPAN"]?.ToString() ?? "",
                        AccTAN = r["AccTAN"]?.ToString() ?? "",
                        AccContact = r["AccContact"]?.ToString() ?? "",
                        AccEmail = r["AccEmail"]?.ToString() ?? ""
                    });
                }
                return Ok(new { success = true, data = list });
            }
            catch (Exception ex) { return Ok(new { success = false, message = ex.Message, data = new List<object>() }); }
        }

        [HttpPost]
        public IActionResult Create([FromBody] AccReq req)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(req.AccCode)) return BadRequest(new { success = false, message = "Account Code required" });
                if (string.IsNullOrWhiteSpace(req.AccName)) return BadRequest(new { success = false, message = "Account Name required" });
                if (req.SocSubGroupId <= 0) return BadRequest(new { success = false, message = "Group required" });

                using var c = DbHelper.GetConn();

                // Duplicate check
                using var chk = c.CreateCommand();
                chk.CommandText = "SELECT COUNT(*) FROM SocAccount WHERE TRIM(UPPER(AccCode))=TRIM(UPPER(@c)) AND IsDeleted=0";
                chk.Parameters.AddWithValue("@c", req.AccCode.Trim());
                if (Convert.ToInt32(chk.ExecuteScalar()) > 0)
                    return BadRequest(new { success = false, message = "Duplicate Account Code" });

                // Get group info
                int grpMainId = 0, socGroupId = req.SocSubGroupId;
                using (var gCmd = c.CreateCommand())
                {
                    gCmd.CommandText = "SELECT GrpMainId, SocGroupId FROM SocGroup WHERE SocGroupId=@id";
                    gCmd.Parameters.AddWithValue("@id", req.SocSubGroupId);
                    using var gr = gCmd.ExecuteReader();
                    if (gr.Read()) { grpMainId = gr["GrpMainId"] != DBNull.Value ? Convert.ToInt32(gr["GrpMainId"]) : 0; }
                }

                decimal opBal = req.OpDrCr == "Cr." ? -Math.Abs(req.OpeningBalance) : Math.Abs(req.OpeningBalance);
                decimal prBal = req.PrDrCr == "Cr." ? -Math.Abs(req.PreviousBalance) : Math.Abs(req.PreviousBalance);
                string n1 = string.IsNullOrWhiteSpace(req.AccName1) ? req.AccName.Trim() : req.AccName1.Trim();
                string n2 = string.IsNullOrWhiteSpace(req.AccName2) ? req.AccName.Trim() : req.AccName2.Trim();

                using var ins = c.CreateCommand();
                ins.CommandText = @"INSERT INTO SocAccount(AccCode,AccName,AccName1,AccName2,Op_Bal,Tr_Db,Tr_Cr,Cl_Bal,Pr_Bal,
                    AccAdd,AccPAN,AccTAN,AccSTAX,AccVAT,AccContact,AccEmail,
                    SocSubGroupId,SocGroupId,GrpMainId,SocAccountType,OpDrCr,PrDrCr,IsDeleted)
                    VALUES(@c,@n,@n1,@n2,@ob,0,0,@ob,@pb,@add,@pan,@tan,'','',@con,@em,@sg,@sg,@gm,1,@odc,@pdc,0)";
                ins.Parameters.AddWithValue("@c", req.AccCode.Trim());
                ins.Parameters.AddWithValue("@n", req.AccName.Trim());
                ins.Parameters.AddWithValue("@n1", n1);
                ins.Parameters.AddWithValue("@n2", n2);
                ins.Parameters.AddWithValue("@ob", Math.Round(opBal, 2));
                ins.Parameters.AddWithValue("@pb", Math.Round(prBal, 2));
                ins.Parameters.AddWithValue("@add", req.AccAdd ?? "");
                ins.Parameters.AddWithValue("@pan", req.AccPAN ?? "");
                ins.Parameters.AddWithValue("@tan", req.AccTAN ?? "");
                ins.Parameters.AddWithValue("@con", req.AccContact ?? "");
                ins.Parameters.AddWithValue("@em", req.AccEmail ?? "");
                ins.Parameters.AddWithValue("@sg", req.SocSubGroupId);
                ins.Parameters.AddWithValue("@gm", grpMainId);
                ins.Parameters.AddWithValue("@odc", req.OpDrCr ?? "Dr.");
                ins.Parameters.AddWithValue("@pdc", req.PrDrCr ?? "Dr.");
                ins.ExecuteNonQuery();

                return Ok(new { success = true, message = "Account created" });
            }
            catch (Exception ex) { return BadRequest(new { success = false, message = ex.Message }); }
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] AccReq req)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(req.AccName)) return BadRequest(new { success = false, message = "Account Name required" });

                using var c = DbHelper.GetConn();

                // Duplicate code check (exclude self)
                using var chk = c.CreateCommand();
                chk.CommandText = "SELECT COUNT(*) FROM SocAccount WHERE TRIM(UPPER(AccCode))=TRIM(UPPER(@c)) AND SocAccId!=@id AND IsDeleted=0";
                chk.Parameters.AddWithValue("@c", req.AccCode?.Trim() ?? "");
                chk.Parameters.AddWithValue("@id", id);
                if (Convert.ToInt32(chk.ExecuteScalar()) > 0)
                    return BadRequest(new { success = false, message = "Duplicate Account Code" });

                int grpMainId = 0;
                if (req.SocSubGroupId > 0)
                {
                    using var gCmd = c.CreateCommand();
                    gCmd.CommandText = "SELECT GrpMainId FROM SocGroup WHERE SocGroupId=@id";
                    gCmd.Parameters.AddWithValue("@id", req.SocSubGroupId);
                    using var gr = gCmd.ExecuteReader();
                    if (gr.Read()) grpMainId = gr["GrpMainId"] != DBNull.Value ? Convert.ToInt32(gr["GrpMainId"]) : 0;
                }

                decimal opBal = req.OpDrCr == "Cr." ? -Math.Abs(req.OpeningBalance) : Math.Abs(req.OpeningBalance);
                decimal prBal = req.PrDrCr == "Cr." ? -Math.Abs(req.PreviousBalance) : Math.Abs(req.PreviousBalance);

                using var upd = c.CreateCommand();
                upd.CommandText = @"UPDATE SocAccount SET AccCode=@c,AccName=@n,AccName1=@n1,AccName2=@n2,
                    Op_Bal=@ob,Cl_Bal=@ob,Pr_Bal=@pb,AccAdd=@add,AccPAN=@pan,AccTAN=@tan,
                    AccContact=@con,AccEmail=@em,SocSubGroupId=@sg,SocGroupId=@sg,GrpMainId=@gm,
                    OpDrCr=@odc,PrDrCr=@pdc WHERE SocAccId=@id AND IsDeleted=0";
                upd.Parameters.AddWithValue("@c", req.AccCode?.Trim() ?? "");
                upd.Parameters.AddWithValue("@n", req.AccName.Trim());
                upd.Parameters.AddWithValue("@n1", string.IsNullOrWhiteSpace(req.AccName1) ? req.AccName.Trim() : req.AccName1.Trim());
                upd.Parameters.AddWithValue("@n2", string.IsNullOrWhiteSpace(req.AccName2) ? req.AccName.Trim() : req.AccName2.Trim());
                upd.Parameters.AddWithValue("@ob", Math.Round(opBal, 2));
                upd.Parameters.AddWithValue("@pb", Math.Round(prBal, 2));
                upd.Parameters.AddWithValue("@add", req.AccAdd ?? "");
                upd.Parameters.AddWithValue("@pan", req.AccPAN ?? "");
                upd.Parameters.AddWithValue("@tan", req.AccTAN ?? "");
                upd.Parameters.AddWithValue("@con", req.AccContact ?? "");
                upd.Parameters.AddWithValue("@em", req.AccEmail ?? "");
                upd.Parameters.AddWithValue("@sg", req.SocSubGroupId);
                upd.Parameters.AddWithValue("@gm", grpMainId);
                upd.Parameters.AddWithValue("@odc", req.OpDrCr ?? "Dr.");
                upd.Parameters.AddWithValue("@pdc", req.PrDrCr ?? "Dr.");
                upd.Parameters.AddWithValue("@id", id);

                return upd.ExecuteNonQuery() > 0
                    ? Ok(new { success = true, message = "Account updated" })
                    : NotFound(new { success = false, message = "Account not found" });
            }
            catch (Exception ex) { return BadRequest(new { success = false, message = ex.Message }); }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                using var c = DbHelper.GetConn();
                using var cmd = c.CreateCommand();
                cmd.CommandText = "UPDATE SocAccount SET IsDeleted=1 WHERE SocAccId=@id";
                cmd.Parameters.AddWithValue("@id", id);
                return cmd.ExecuteNonQuery() > 0
                    ? Ok(new { success = true, message = "Account deleted" })
                    : NotFound(new { success = false, message = "Not found" });
            }
            catch (Exception ex) { return BadRequest(new { success = false, message = ex.Message }); }
        }

        [HttpDelete("bulk")]
        public IActionResult BulkDelete([FromBody] int[] ids)
        {
            if (ids == null || ids.Length == 0) return BadRequest(new { success = false, message = "No IDs provided" });
            try
            {
                using var c = DbHelper.GetConn();
                int done = 0;
                foreach (var id in ids)
                {
                    using var cmd = c.CreateCommand();
                    cmd.CommandText = "UPDATE SocAccount SET IsDeleted=1 WHERE SocAccId=@id";
                    cmd.Parameters.AddWithValue("@id", id);
                    done += cmd.ExecuteNonQuery();
                }
                return Ok(new { success = true, message = $"{done} accounts deleted" });
            }
            catch (Exception ex) { return BadRequest(new { success = false, message = ex.Message }); }
        }

        public class AccReq
        {
            public string AccCode { get; set; }
            public string AccName { get; set; }
            public string AccName1 { get; set; }
            public string AccName2 { get; set; }
            public int SocSubGroupId { get; set; }
            public decimal OpeningBalance { get; set; }
            public string OpDrCr { get; set; } = "Dr.";
            public decimal PreviousBalance { get; set; }
            public string PrDrCr { get; set; } = "Dr.";
            public string AccAdd { get; set; }
            public string AccPAN { get; set; }
            public string AccTAN { get; set; }
            public string AccSTAX { get; set; }
            public string AccContact { get; set; }
            public string AccEmail { get; set; }
        }
    }
}
