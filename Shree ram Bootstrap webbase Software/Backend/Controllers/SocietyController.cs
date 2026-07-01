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

        [HttpGet("previous-year-previews")]
        public IActionResult GetPreviousYearPreviews([FromQuery] int currentSocietyId)
        {
            try
            {
                using var conn = DbHelper.GetConn();
                conn.Open();

                string currentName = "";
                string currentYear = "";
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT SocietyName, StartingYear FROM SocietyInfo WHERE ID = @id";
                    cmd.Parameters.AddWithValue("@id", currentSocietyId);
                    using var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        currentName = reader.GetString(0);
                        currentYear = reader.IsDBNull(1) ? "" : reader.GetString(1);
                    }
                    else
                    {
                        return NotFound(new { success = false, message = "Society not found" });
                    }
                }

                string prevYear = GetPreviousYear(currentYear);
                if (string.IsNullOrEmpty(prevYear))
                {
                    return Ok(new { exists = false });
                }

                string prevFYStartStr = "";
                string prevFYEndStr = "";
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT FYYearStart, FYYearEnd FROM SocietyInfo WHERE TRIM(UPPER(SocietyName)) = TRIM(UPPER(@name)) AND StartingYear = @prevYear AND IsDeleted = 0 LIMIT 1";
                    cmd.Parameters.AddWithValue("@name", currentName);
                    cmd.Parameters.AddWithValue("@prevYear", prevYear);
                    using var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        prevFYStartStr = reader.IsDBNull(0) ? "" : reader.GetString(0);
                        prevFYEndStr = reader.IsDBNull(1) ? "" : reader.GetString(1);
                    }
                    else
                    {
                        return Ok(new { exists = false });
                    }
                }

                DateTime? start = ParseDate(prevFYStartStr);
                DateTime? end = ParseDate(prevFYEndStr);

                if (start == null || end == null)
                {
                    return Ok(new { exists = false });
                }

                int maxBill = 0;
                int maxReceipt = 0;
                int maxReversal = 0;
                int maxDebit = 0;
                int maxCredit = 0;
                int maxTransfer = 0;
                int maxOtherReceipt = 0;
                int maxPayCash = 0;
                int maxPayBank = 0;
                int maxPaySwiss = 0;
                int maxContra = 0;
                int maxJV = 0;

                // 1. Query bills
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT VoucherNo, BillDate FROM SocMemberBill";
                    using var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string vNo = reader.GetString(0);
                        string bDate = reader.IsDBNull(1) ? "" : reader.GetString(1);
                        DateTime? dt = ParseDate(bDate);
                        if (dt >= start && dt <= end)
                        {
                            int num = ParseLastNumeric(vNo);
                            if (num > maxBill) maxBill = num;
                        }
                    }
                }

                // 2. Query vouchers (Receipts, Reversals, OtherReceipts, Payments, Contras, JVs)
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT VoucherNo, VoucherDate, VoucherType FROM SocVoucherHeader";
                    using var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string vNo = reader.GetString(0);
                        string vDate = reader.IsDBNull(1) ? "" : reader.GetString(1);
                        string vType = reader.GetString(2);
                        DateTime? dt = ParseDate(vDate);
                        if (dt >= start && dt <= end)
                        {
                            int num = ParseLastNumeric(vNo);
                            if (vType == "Receipt") { if (num > maxReceipt) maxReceipt = num; }
                            else if (vType == "Reversal") { if (num > maxReversal) maxReversal = num; }
                            else if (vType == "OtherReceipt") { if (num > maxOtherReceipt) maxOtherReceipt = num; }
                            else if (vType == "Contra") { if (num > maxContra) maxContra = num; }
                            else if (vType == "JV") { if (num > maxJV) maxJV = num; }
                            else if (vType == "Payment")
                            {
                                if (vNo.Contains("CASH")) { if (num > maxPayCash) maxPayCash = num; }
                                else if (vNo.Contains("SWIF")) { if (num > maxPaySwiss) maxPaySwiss = num; }
                                else { if (num > maxPayBank) maxPayBank = num; }
                            }
                        }
                    }
                }

                // 3. Query notes (Debits, Credits)
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT NoteNo, NoteDate, NoteType FROM SocMemberNote";
                    using var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string nNo = reader.GetString(0);
                        string nDate = reader.IsDBNull(1) ? "" : reader.GetString(1);
                        string nType = reader.GetString(2);
                        DateTime? dt = ParseDate(nDate);
                        if (dt >= start && dt <= end)
                        {
                            int num = ParseLastNumeric(nNo);
                            if (nType == "Debit") { if (num > maxDebit) maxDebit = num; }
                            else if (nType == "Credit") { if (num > maxCredit) maxCredit = num; }
                        }
                    }
                }

                // 4. Query transfers
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT TransferNo, TransferDate FROM SocBillTransfer";
                    using var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string tNo = reader.GetString(0);
                        string tDate = reader.IsDBNull(1) ? "" : reader.GetString(1);
                        DateTime? dt = ParseDate(tDate);
                        if (dt >= start && dt <= end)
                        {
                            int num = ParseLastNumeric(tNo);
                            if (num > maxTransfer) maxTransfer = num;
                        }
                    }
                }

                return Ok(new
                {
                    success = true,
                    exists = true,
                    previousYear = prevYear,
                    nextNumbers = new
                    {
                        Bill = maxBill > 0 ? maxBill + 1 : 1,
                        Receipt = maxReceipt > 0 ? maxReceipt + 1 : 1,
                        Reversal = maxReversal > 0 ? maxReversal + 1 : 1,
                        Debit = maxDebit > 0 ? maxDebit + 1 : 1,
                        Credit = maxCredit > 0 ? maxCredit + 1 : 1,
                        Transfer = maxTransfer > 0 ? maxTransfer + 1 : 1,
                        OtherReceipt = maxOtherReceipt > 0 ? maxOtherReceipt + 1 : 1,
                        Payment_Cash = maxPayCash > 0 ? maxPayCash + 1 : 1,
                        Payment_Bank = maxPayBank > 0 ? maxPayBank + 1 : 1,
                        Payment_Swiss = maxPaySwiss > 0 ? maxPaySwiss + 1 : 1,
                        Contra = maxContra > 0 ? maxContra + 1 : 1,
                        JV = maxJV > 0 ? maxJV + 1 : 1
                    }
                });
            }
            catch (Exception ex)
            {
                return Ok(new { success = false, message = ex.Message });
            }
        }

        private static string GetPreviousYear(string startingYear)
        {
            if (string.IsNullOrEmpty(startingYear)) return "";
            var match = System.Text.RegularExpressions.Regex.Match(startingYear.Trim(), @"^(\d{4})-(\d{2})$");
            if (match.Success)
            {
                int y1 = int.Parse(match.Groups[1].Value) - 1;
                int y2 = int.Parse(match.Groups[2].Value) - 1;
                return $"{y1}-{y2:D2}";
            }
            match = System.Text.RegularExpressions.Regex.Match(startingYear.Trim(), @"^(\d{4})-(\d{4})$");
            if (match.Success)
            {
                int y1 = int.Parse(match.Groups[1].Value) - 1;
                int y2 = int.Parse(match.Groups[2].Value) - 1;
                return $"{y1}-{y2}";
            }
            return "";
        }

        private static DateTime? ParseDate(string? dateStr)
        {
            if (string.IsNullOrEmpty(dateStr)) return null;
            string[] formats = { "yyyy-MM-dd", "dd/MM/yyyy", "dd-MM-yyyy", "yyyy/MM/dd" };
            if (DateTime.TryParseExact(dateStr.Trim(), formats, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime dt))
            {
                return dt;
            }
            if (DateTime.TryParse(dateStr.Trim(), out dt))
            {
                return dt;
            }
            return null;
        }

        private static int ParseLastNumeric(string vNo)
        {
            if (string.IsNullOrEmpty(vNo)) return 0;
            int idx = vNo.Length - 1;
            while (idx >= 0 && char.IsDigit(vNo[idx]))
            {
                idx--;
            }
            string numStr = vNo.Substring(idx + 1);
            if (int.TryParse(numStr, out int result))
            {
                return result;
            }
            return 0;
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
             public string StartingYear { get; set; }
             public string UIDNumber { get; set; }
             public string HonChairman { get; set; }
             public string HonSecretary { get; set; }
             public string HonTreasurer { get; set; }
             public string ContactName1 { get; set; }
             public string ContactName2 { get; set; }
             public string ContactPhone1 { get; set; }
             public string ContactPhone2 { get; set; }
             public string ContactEmail1 { get; set; }
             public string ContactEmail2 { get; set; }
             public string CommWhatsApp { get; set; }
             public string CommSMS { get; set; }
             public string CommRCS { get; set; }
             public string CommEmail { get; set; }
             public string CommNotification { get; set; }
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
