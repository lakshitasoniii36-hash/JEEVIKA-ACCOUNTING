using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

namespace Backend
{
    [ApiController]
    [Route("api/society")]
    public class SocietyController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var list = new List<object>();
                using var c = DbHelper.GetConn();
                using var cmd = c.CreateCommand();
                cmd.CommandText = "SELECT * FROM SocietyInfo WHERE IsDeleted=0 ORDER BY SocietyName";
                using var r = cmd.ExecuteReader();
                while (r.Read()) list.Add(ReadRow(r));
                return Ok(new { success = true, data = list });
            }
            catch (Exception ex) { return Ok(new { success = false, message = ex.Message, data = new List<object>() }); }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                using var c = DbHelper.GetConn();
                using var cmd = c.CreateCommand();
                cmd.CommandText = "SELECT * FROM SocietyInfo WHERE ID=@id";
                cmd.Parameters.AddWithValue("@id", id);
                using var r = cmd.ExecuteReader();
                if (r.Read()) return Ok(new { success = true, data = ReadRow(r) });
                return NotFound(new { success = false, message = "Society not found" });
            }
            catch (Exception ex) { return BadRequest(new { success = false, message = ex.Message }); }
        }

        [HttpPost]
        public IActionResult Create([FromBody] SocReq req)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(req.SocietyName)) return BadRequest(new { success = false, message = "Society Name required" });
                if (string.IsNullOrWhiteSpace(req.SocietyCode)) return BadRequest(new { success = false, message = "Society Code required" });

                // PAN validation (if provided)
                if (!string.IsNullOrWhiteSpace(req.PANNumber) &&
                    !System.Text.RegularExpressions.Regex.IsMatch(req.PANNumber.Trim(), @"^[A-Z]{5}[0-9]{4}[A-Z]{1}$"))
                    return BadRequest(new { success = false, message = "Invalid PAN format (e.g. AABCS1234D)" });

                // Phone validation (if provided)
                if (!string.IsNullOrWhiteSpace(req.Phone) &&
                    !System.Text.RegularExpressions.Regex.IsMatch(req.Phone.Trim(), @"^\d{10}$"))
                    return BadRequest(new { success = false, message = "Phone must be 10 digits" });

                using var c = DbHelper.GetConn();

                // Duplicate check
                using (var chk = c.CreateCommand())
                {
                    chk.CommandText = "SELECT COUNT(*) FROM SocietyInfo WHERE TRIM(UPPER(SocietyCode))=TRIM(UPPER(@cd)) AND IsDeleted=0";
                    chk.Parameters.AddWithValue("@cd", req.SocietyCode.Trim());
                    if (Convert.ToInt32(chk.ExecuteScalar()) > 0)
                        return BadRequest(new { success = false, message = "Society Code already exists" });
                }

                using var ins = c.CreateCommand();
                ins.CommandText = BuildInsert(req);
                AddParams(ins, req);
                ins.ExecuteNonQuery();

                return Ok(new { success = true, message = "Society saved successfully" });
            }
            catch (Exception ex) { return BadRequest(new { success = false, message = ex.Message }); }
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] SocReq req)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(req.SocietyName)) return BadRequest(new { success = false, message = "Society Name required" });

                using var c = DbHelper.GetConn();
                using var upd = c.CreateCommand();
                upd.CommandText = BuildUpdate(req);
                AddParams(upd, req);
                upd.Parameters.AddWithValue("@id", id);
                return upd.ExecuteNonQuery() > 0
                    ? Ok(new { success = true, message = "Society updated" })
                    : NotFound(new { success = false, message = "Society not found" });
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
                cmd.CommandText = "UPDATE SocietyInfo SET IsDeleted=1,ModifiedDate=datetime('now') WHERE ID=@id";
                cmd.Parameters.AddWithValue("@id", id);
                return cmd.ExecuteNonQuery() > 0
                    ? Ok(new { success = true, message = "Society deleted" })
                    : NotFound(new { success = false, message = "Not found" });
            }
            catch (Exception ex) { return BadRequest(new { success = false, message = ex.Message }); }
        }

        // ── Helpers ──

        static object ReadRow(SqliteDataReader r)
        {
            var d = new Dictionary<string, object>();
            for (int i = 0; i < r.FieldCount; i++)
                d[r.GetName(i)] = r.IsDBNull(i) ? null : r.GetValue(i);
            return d;
        }

        static string BuildInsert(SocReq req)
        {
            var cols = GetCols();
            var parms = cols.Select(c => "@" + c);
            return $"INSERT INTO SocietyInfo({string.Join(",", cols)},CreatedDate,ModifiedDate) VALUES({string.Join(",", parms)},datetime('now'),datetime('now'))";
        }

        static string BuildUpdate(SocReq req)
        {
            var cols = GetCols();
            var sets = cols.Select(c => $"{c}=@{c}");
            return $"UPDATE SocietyInfo SET {string.Join(",", sets)},ModifiedDate=datetime('now') WHERE ID=@id AND IsDeleted=0";
        }

        static IEnumerable<string> GetCols() => typeof(SocReq)
            .GetProperties(BindingFlags.Public | BindingFlags.Instance)
            .Select(p => p.Name);

        static void AddParams(SqliteCommand cmd, SocReq req)
        {
            foreach (var p in typeof(SocReq).GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                var val = p.GetValue(req);
                cmd.Parameters.AddWithValue("@" + p.Name, val == null ? DBNull.Value : (object)val);
            }
        }

        public class SocReq
        {
            public string SocietyCode { get; set; }
            public string SocietyName { get; set; }
            public string ClientID { get; set; }
            public string SocMarName { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string Pincode { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }
            public string RegistrationNo { get; set; }
            public string PANNumber { get; set; }
            public string TAN { get; set; }
            public string GSTNumber { get; set; }
            public string GSTApplicable { get; set; }
            public string ChairmanName { get; set; }
            public string SecretaryName { get; set; }
            public string TreasurerName { get; set; }
            public string BankName { get; set; }
            public string BankAccountNo { get; set; }
            public string BankBranch { get; set; }
            public string IFSCCode { get; set; }
            public string FYYearStart { get; set; }
            public string FYYearEnd { get; set; }
            public string IsOnline { get; set; }
            public string OnlineSrNo { get; set; }
            public string Status { get; set; }
            public string Remarks { get; set; }
            public string RemarksCol1_L1 { get; set; } public string RemarksCol1_L1_IsBold { get; set; }
            public string RemarksCol1_L2 { get; set; } public string RemarksCol1_L2_IsBold { get; set; }
            public string RemarksCol1_L3 { get; set; } public string RemarksCol1_L3_IsBold { get; set; }
            public string RemarksCol1_L4 { get; set; } public string RemarksCol1_L4_IsBold { get; set; }
            public string RemarksCol1_L5 { get; set; } public string RemarksCol1_L5_IsBold { get; set; }
            public string RemarksCol1_L6 { get; set; } public string RemarksCol1_L6_IsBold { get; set; }
            public string RemarksCol2_L1 { get; set; } public string RemarksCol2_L1_IsBold { get; set; }
            public string RemarksCol2_L2 { get; set; } public string RemarksCol2_L2_IsBold { get; set; }
            public string RemarksCol2_L3 { get; set; } public string RemarksCol2_L3_IsBold { get; set; }
            public string RemarksCol2_L4 { get; set; } public string RemarksCol2_L4_IsBold { get; set; }
            public string RemarksCol2_L5 { get; set; } public string RemarksCol2_L5_IsBold { get; set; }
            public string RemarksCol2_L6 { get; set; } public string RemarksCol2_L6_IsBold { get; set; }
            public string BSFooter_L1 { get; set; } public string BSFooter_L1_IsBold { get; set; }
            public string BSFooter_L2 { get; set; } public string BSFooter_L2_IsBold { get; set; }
            public string BSFooter_L3 { get; set; } public string BSFooter_L3_IsBold { get; set; }
            public string BSFooter_L4 { get; set; } public string BSFooter_L4_IsBold { get; set; }
            public string BSFooter_L5 { get; set; } public string BSFooter_L5_IsBold { get; set; }
            public string BSFooter_L6 { get; set; } public string BSFooter_L6_IsBold { get; set; }
            public string AuditFooter_L1 { get; set; } public string AuditFooter_L1_IsBold { get; set; }
            public string AuditFooter_L2 { get; set; } public string AuditFooter_L2_IsBold { get; set; }
            public string AuditFooter_L3 { get; set; } public string AuditFooter_L3_IsBold { get; set; }
            public string AuditFooter_L4 { get; set; } public string AuditFooter_L4_IsBold { get; set; }
            public string AuditFooter_L5 { get; set; } public string AuditFooter_L5_IsBold { get; set; }
            public string AuditFooter_L6 { get; set; } public string AuditFooter_L6_IsBold { get; set; }
        }
    }
}
