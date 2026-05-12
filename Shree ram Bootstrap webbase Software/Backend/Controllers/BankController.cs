using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;

namespace Backend
{
    [ApiController]
    [Route("api/bankreco")]
    public class BankController : ControllerBase
    {
        private readonly string _sqliteDbPath = "Data/ShreeRam.sqlite";

        public class BankRecoModel
        {
            public int Id { get; set; }
            public string CashBankName { get; set; }
            public DateTime TranDate { get; set; }
            public string TranType { get; set; }
            public decimal AmountFrom { get; set; }
            public decimal AmountTo { get; set; }
            public string ChqNo { get; set; }
            public string ChqDate { get; set; }
            public string BankName { get; set; }
            public string Person { get; set; }
            public string Particular2 { get; set; }
            public string Particular3 { get; set; }
            public string Particular4 { get; set; }
            public string ClearType { get; set; }
        }

        public class BankRecoRequest
        {
            public string CashBankName { get; set; }
            public DateTime TranDate { get; set; }
            public string TranType { get; set; }
            public decimal AmountFrom { get; set; }
            public decimal AmountTo { get; set; }
            public string ChqNo { get; set; }
            public string ChqDate { get; set; }
            public string BankName { get; set; }
            public string Person { get; set; }
            public string Particular2 { get; set; }
            public string Particular3 { get; set; }
            public string Particular4 { get; set; }
            public string ClearType { get; set; }
        }

        private SqliteConnection GetConn()
        {
            var cs = new SqliteConnectionStringBuilder { DataSource = _sqliteDbPath, Mode = SqliteOpenMode.ReadWriteCreate }.ToString();
            return new SqliteConnection(cs);
        }

        private void EnsureTable()
        {
            using var conn = GetConn(); conn.Open();
            var cmd = conn.CreateCommand();
            cmd.CommandText = @"CREATE TABLE IF NOT EXISTS SocBankReco (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                CashBankName TEXT, TranDate TEXT, TranType TEXT,
                AmountFrom REAL, AmountTo REAL, ChqNo TEXT, ChqDate TEXT,
                BankName TEXT, Person TEXT, Particular2 TEXT, Particular3 TEXT,
                Particular4 TEXT, ClearType TEXT)";
            cmd.ExecuteNonQuery();
        }

        private string S(SqliteDataReader r, string n) { try { return r[n]?.ToString() ?? ""; } catch { return ""; } }
        private double D(SqliteDataReader r, string n) { try { return r[n] != DBNull.Value ? Convert.ToDouble(r[n]) : 0; } catch { return 0; } }
        private int I(SqliteDataReader r, string n) { try { return r[n] != DBNull.Value ? Convert.ToInt32(r[n]) : 0; } catch { return 0; } }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                EnsureTable();
                var list = new List<BankRecoModel>();
                using var conn = GetConn(); conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM SocBankReco ORDER BY TranDate DESC";
                using var r = cmd.ExecuteReader();
                while (r.Read())
                {
                    list.Add(new BankRecoModel
                    {
                        Id = I(r,"Id"),
                        CashBankName = S(r,"CashBankName"),
                        TranDate = DateTime.TryParse(S(r,"TranDate"), out var td) ? td : DateTime.Now,
                        TranType = S(r,"TranType"),
                        AmountFrom = (decimal)D(r,"AmountFrom"),
                        AmountTo = (decimal)D(r,"AmountTo"),
                        ChqNo = S(r,"ChqNo"),
                        ChqDate = S(r,"ChqDate"),
                        BankName = S(r,"BankName"),
                        Person = S(r,"Person"),
                        Particular2 = S(r,"Particular2"),
                        Particular3 = S(r,"Particular3"),
                        Particular4 = S(r,"Particular4"),
                        ClearType = S(r,"ClearType")
                    });
                }
                return Ok(new { success = true, data = list });
            }
            catch (Exception ex) { return Ok(new { success = false, message = ex.Message }); }
        }

        [HttpPost]
        public IActionResult Create([FromBody] BankRecoRequest req)
        {
            try
            {
                EnsureTable();
                using var conn = GetConn(); conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"INSERT INTO SocBankReco 
                    (CashBankName,TranDate,TranType,AmountFrom,AmountTo,ChqNo,ChqDate,
                     BankName,Person,Particular2,Particular3,Particular4,ClearType)
                    VALUES(@cb,@td,@tt,@af,@at,@cn,@cd,@bn,@p,@p2,@p3,@p4,@ct)";
                cmd.Parameters.Add(new SqliteParameter("@cb", req.CashBankName ?? ""));
                cmd.Parameters.Add(new SqliteParameter("@td", req.TranDate.ToString("yyyy-MM-dd")));
                cmd.Parameters.Add(new SqliteParameter("@tt", req.TranType ?? ""));
                cmd.Parameters.Add(new SqliteParameter("@af", req.AmountFrom));
                cmd.Parameters.Add(new SqliteParameter("@at", req.AmountTo));
                cmd.Parameters.Add(new SqliteParameter("@cn", req.ChqNo ?? ""));
                cmd.Parameters.Add(new SqliteParameter("@cd", req.ChqDate ?? ""));
                cmd.Parameters.Add(new SqliteParameter("@bn", req.BankName ?? ""));
                cmd.Parameters.Add(new SqliteParameter("@p", req.Person ?? ""));
                cmd.Parameters.Add(new SqliteParameter("@p2", req.Particular2 ?? ""));
                cmd.Parameters.Add(new SqliteParameter("@p3", req.Particular3 ?? ""));
                cmd.Parameters.Add(new SqliteParameter("@p4", req.Particular4 ?? ""));
                cmd.Parameters.Add(new SqliteParameter("@ct", req.ClearType ?? "Unclear"));
                cmd.ExecuteNonQuery();
                return Ok(new { success = true, message = "Bank Reconciliation entry created" });
            }
            catch (Exception ex) { return BadRequest(new { success = false, message = ex.Message }); }
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] BankRecoRequest req)
        {
            try
            {
                EnsureTable();
                using var conn = GetConn(); conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"UPDATE SocBankReco SET 
                    CashBankName=@cb,TranDate=@td,TranType=@tt,AmountFrom=@af,AmountTo=@at,
                    ChqNo=@cn,ChqDate=@cd,BankName=@bn,Person=@p,Particular2=@p2,
                    Particular3=@p3,Particular4=@p4,ClearType=@ct WHERE Id=@id";
                cmd.Parameters.Add(new SqliteParameter("@cb", req.CashBankName ?? ""));
                cmd.Parameters.Add(new SqliteParameter("@td", req.TranDate.ToString("yyyy-MM-dd")));
                cmd.Parameters.Add(new SqliteParameter("@tt", req.TranType ?? ""));
                cmd.Parameters.Add(new SqliteParameter("@af", req.AmountFrom));
                cmd.Parameters.Add(new SqliteParameter("@at", req.AmountTo));
                cmd.Parameters.Add(new SqliteParameter("@cn", req.ChqNo ?? ""));
                cmd.Parameters.Add(new SqliteParameter("@cd", req.ChqDate ?? ""));
                cmd.Parameters.Add(new SqliteParameter("@bn", req.BankName ?? ""));
                cmd.Parameters.Add(new SqliteParameter("@p", req.Person ?? ""));
                cmd.Parameters.Add(new SqliteParameter("@p2", req.Particular2 ?? ""));
                cmd.Parameters.Add(new SqliteParameter("@p3", req.Particular3 ?? ""));
                cmd.Parameters.Add(new SqliteParameter("@p4", req.Particular4 ?? ""));
                cmd.Parameters.Add(new SqliteParameter("@ct", req.ClearType ?? "Unclear"));
                cmd.Parameters.Add(new SqliteParameter("@id", id));
                var rows = cmd.ExecuteNonQuery();
                return rows > 0 ? Ok(new { success = true, message = "Updated" })
                    : NotFound(new { success = false, message = "Not found" });
            }
            catch (Exception ex) { return BadRequest(new { success = false, message = ex.Message }); }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                EnsureTable();
                using var conn = GetConn(); conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM SocBankReco WHERE Id=@id";
                cmd.Parameters.Add(new SqliteParameter("@id", id));
                var rows = cmd.ExecuteNonQuery();
                return rows > 0 ? Ok(new { success = true, message = "Deleted" })
                    : NotFound(new { success = false, message = "Not found" });
            }
            catch (Exception ex) { return BadRequest(new { success = false, message = ex.Message }); }
        }
    }
}
