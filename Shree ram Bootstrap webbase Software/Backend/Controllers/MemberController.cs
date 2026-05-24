using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;

namespace Backend
{
    [ApiController]
    [Route("api/member")]
    public class MemberController : ControllerBase
    {
        private readonly string _sqliteDbPath = System.IO.Path.Combine(System.AppContext.BaseDirectory, "Data", "ShreeRam.sqlite");

        public class SocMemberModel
        {
            public int SocMemId { get; set; }
            public int SocAccountMainId { get; set; }
            public string MemCode { get; set; }
            public string Bldg { get; set; }
            public string Wing { get; set; }
            public string FlatType { get; set; }
            public string FlatNo { get; set; }
            public string Floor { get; set; }
            public double Sqft { get; set; }
            public string MemName { get; set; }
            public string MemName1 { get; set; }
            public string MemName2 { get; set; }
            public string MemName3 { get; set; }
            public string NocDetail { get; set; }
            public string ParkDetail { get; set; }
            public string LaonDetail { get; set; }
            public string Poss_Date { get; set; }
            public string MemEmail { get; set; }
            public string MemMobile { get; set; }
            public string FamilyDetail { get; set; }
            public string ServantDetail { get; set; }
            public string BankName { get; set; }
            public string DefaPart { get; set; }
            public double Op_Prin { get; set; }
            public double Op_Int { get; set; }
            public double DrTR_Prin { get; set; }
            public double DrTR_Int { get; set; }
            public double CrTR_Prin { get; set; }
            public double CrTR_Int { get; set; }
            public double Cl_Prin { get; set; }
            public double Cl_Int { get; set; }
            public string IsTransfer { get; set; }
            public string MemAddress { get; set; }
            public string UnitType { get; set; }
            public string AreaType { get; set; }
            public string AreaUnit { get; set; }
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
            cmd.CommandText = @"CREATE TABLE IF NOT EXISTS SocMember (
                SocMemId INTEGER PRIMARY KEY AUTOINCREMENT,
                SocAccountMainId INTEGER, MemCode TEXT, Bldg TEXT, Wing TEXT, FlatType TEXT,
                FlatNo TEXT, Floor TEXT, Sqft REAL, MemName TEXT, MemName1 TEXT, MemName2 TEXT,
                MemName3 TEXT, NocDetail TEXT, ParkDetail TEXT, LaonDetail TEXT, Poss_Date TEXT,
                MemEmail TEXT, MemMobile TEXT, FamilyDetail TEXT, ServantDetail TEXT, BankName TEXT,
                DefaPart TEXT, Op_Prin REAL, Op_Int REAL, DrTR_Prin REAL, DrTR_Int REAL,
                CrTR_Prin REAL, CrTR_Int REAL, Cl_Prin REAL, Cl_Int REAL,
                IsTransfer TEXT, MemAddress TEXT, UnitType TEXT, AreaType TEXT, AreaUnit TEXT)";
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
                var list = new List<SocMemberModel>();
                using var conn = GetConn(); conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM SocMember ORDER BY FlatNo, MemName";
                using var r = cmd.ExecuteReader();
                while (r.Read())
                {
                    list.Add(new SocMemberModel
                    {
                        SocMemId = I(r,"SocMemId"), SocAccountMainId = I(r,"SocAccountMainId"),
                        MemCode = S(r,"MemCode"), Bldg = S(r,"Bldg"), Wing = S(r,"Wing"),
                        FlatType = S(r,"FlatType"), FlatNo = S(r,"FlatNo"), Floor = S(r,"Floor"),
                        Sqft = D(r,"Sqft"), MemName = S(r,"MemName"), MemName1 = S(r,"MemName1"),
                        MemName2 = S(r,"MemName2"), MemName3 = S(r,"MemName3"),
                        NocDetail = S(r,"NocDetail"), ParkDetail = S(r,"ParkDetail"),
                        LaonDetail = S(r,"LaonDetail"), Poss_Date = S(r,"Poss_Date"),
                        MemEmail = S(r,"MemEmail"), MemMobile = S(r,"MemMobile"),
                        FamilyDetail = S(r,"FamilyDetail"), ServantDetail = S(r,"ServantDetail"),
                        BankName = S(r,"BankName"), DefaPart = S(r,"DefaPart"),
                        Op_Prin = D(r,"Op_Prin"), Op_Int = D(r,"Op_Int"),
                        DrTR_Prin = D(r,"DrTR_Prin"), DrTR_Int = D(r,"DrTR_Int"),
                        CrTR_Prin = D(r,"CrTR_Prin"), CrTR_Int = D(r,"CrTR_Int"),
                        Cl_Prin = D(r,"Cl_Prin"), Cl_Int = D(r,"Cl_Int"),
                        IsTransfer = S(r,"IsTransfer"), MemAddress = S(r,"MemAddress"),
                        UnitType = S(r,"UnitType"), AreaType = S(r,"AreaType"), AreaUnit = S(r,"AreaUnit")
                    });
                }
                return Ok(new { success = true, data = list, total = list.Count });
            }
            catch (Exception ex) { return Ok(new { success = false, message = ex.Message }); }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                EnsureTable();
                using var conn = GetConn(); conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM SocMember WHERE SocMemId=@id";
                cmd.Parameters.Add(new SqliteParameter("@id", id));
                using var r = cmd.ExecuteReader();
                if (r.Read())
                {
                    var m = new SocMemberModel
                    {
                        SocMemId = I(r,"SocMemId"), SocAccountMainId = I(r,"SocAccountMainId"),
                        MemCode = S(r,"MemCode"), Bldg = S(r,"Bldg"), Wing = S(r,"Wing"),
                        FlatType = S(r,"FlatType"), FlatNo = S(r,"FlatNo"), Floor = S(r,"Floor"),
                        Sqft = D(r,"Sqft"), MemName = S(r,"MemName"), MemName1 = S(r,"MemName1"),
                        MemName2 = S(r,"MemName2"), MemName3 = S(r,"MemName3"),
                        NocDetail = S(r,"NocDetail"), ParkDetail = S(r,"ParkDetail"),
                        LaonDetail = S(r,"LaonDetail"), Poss_Date = S(r,"Poss_Date"),
                        MemEmail = S(r,"MemEmail"), MemMobile = S(r,"MemMobile"),
                        FamilyDetail = S(r,"FamilyDetail"), ServantDetail = S(r,"ServantDetail"),
                        BankName = S(r,"BankName"), DefaPart = S(r,"DefaPart"),
                        Op_Prin = D(r,"Op_Prin"), Op_Int = D(r,"Op_Int"),
                        DrTR_Prin = D(r,"DrTR_Prin"), DrTR_Int = D(r,"DrTR_Int"),
                        CrTR_Prin = D(r,"CrTR_Prin"), CrTR_Int = D(r,"CrTR_Int"),
                        Cl_Prin = D(r,"Cl_Prin"), Cl_Int = D(r,"Cl_Int"),
                        IsTransfer = S(r,"IsTransfer"), MemAddress = S(r,"MemAddress"),
                        UnitType = S(r,"UnitType"), AreaType = S(r,"AreaType"), AreaUnit = S(r,"AreaUnit")
                    };
                    return Ok(new { success = true, data = m });
                }
                return NotFound(new { success = false, message = "Member not found" });
            }
            catch (Exception ex) { return Ok(new { success = false, message = ex.Message }); }
        }

        [HttpPost]
        public IActionResult Create([FromBody] SocMemberModel req)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(req.MemName)) return BadRequest(new { success = false, message = "Member Name required" });
                if (string.IsNullOrWhiteSpace(req.FlatNo)) return BadRequest(new { success = false, message = "Flat No required" });
                EnsureTable();
                using var conn = GetConn(); conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"INSERT INTO SocMember (SocAccountMainId,MemCode,Bldg,Wing,FlatType,FlatNo,Floor,Sqft,
                    MemName,MemName1,MemName2,MemName3,NocDetail,ParkDetail,LaonDetail,Poss_Date,
                    MemEmail,MemMobile,FamilyDetail,ServantDetail,BankName,DefaPart,
                    Op_Prin,Op_Int,DrTR_Prin,DrTR_Int,CrTR_Prin,CrTR_Int,Cl_Prin,Cl_Int,IsTransfer,MemAddress,
                    UnitType,AreaType,AreaUnit)
                    VALUES(@ami,@mc,@b,@w,@ft,@fn,@fl,@sq,@mn,@mn1,@mn2,@mn3,@nd,@pd,@ld,@pdt,
                    @me,@mm,@fd,@sd,@bn,@dp,@op,@oi,@drp,@dri,@crp,@cri,@clp,@cli,@it,@ma,
                    @ut,@at,@au)";
                AddParams(cmd, req);
                cmd.ExecuteNonQuery();
                var id = new SqliteCommand("SELECT last_insert_rowid()", conn).ExecuteScalar();
                return Ok(new { success = true, message = "Member created", id });
            }
            catch (Exception ex) { return BadRequest(new { success = false, message = ex.Message }); }
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] SocMemberModel req)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(req.MemName)) return BadRequest(new { success = false, message = "Member Name required" });
                EnsureTable();
                using var conn = GetConn(); conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"UPDATE SocMember SET SocAccountMainId=@ami,MemCode=@mc,Bldg=@b,Wing=@w,
                    FlatType=@ft,FlatNo=@fn,Floor=@fl,Sqft=@sq,MemName=@mn,MemName1=@mn1,MemName2=@mn2,
                    MemName3=@mn3,NocDetail=@nd,ParkDetail=@pd,LaonDetail=@ld,Poss_Date=@pdt,
                    MemEmail=@me,MemMobile=@mm,FamilyDetail=@fd,ServantDetail=@sd,BankName=@bn,
                    DefaPart=@dp,Op_Prin=@op,Op_Int=@oi,DrTR_Prin=@drp,DrTR_Int=@dri,
                    CrTR_Prin=@crp,CrTR_Int=@cri,Cl_Prin=@clp,Cl_Int=@cli,IsTransfer=@it,MemAddress=@ma,
                    UnitType=@ut,AreaType=@at,AreaUnit=@au
                    WHERE SocMemId=@id";
                AddParams(cmd, req);
                cmd.Parameters.Add(new SqliteParameter("@id", id));
                cmd.ExecuteNonQuery();
                return Ok(new { success = true, message = "Member updated" });
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
                cmd.CommandText = "DELETE FROM SocMember WHERE SocMemId=@id";
                cmd.Parameters.Add(new SqliteParameter("@id", id));
                var rows = cmd.ExecuteNonQuery();
                return rows > 0 ? Ok(new { success = true, message = "Deleted" })
                    : NotFound(new { success = false, message = "Not found" });
            }
            catch (Exception ex) { return BadRequest(new { success = false, message = ex.Message }); }
        }

        private void AddParams(SqliteCommand cmd, SocMemberModel r)
        {
            cmd.Parameters.Add(new SqliteParameter("@ami", r.SocAccountMainId));
            cmd.Parameters.Add(new SqliteParameter("@mc", r.MemCode ?? ""));
            cmd.Parameters.Add(new SqliteParameter("@b", r.Bldg ?? ""));
            cmd.Parameters.Add(new SqliteParameter("@w", r.Wing ?? ""));
            cmd.Parameters.Add(new SqliteParameter("@ft", r.FlatType ?? ""));
            cmd.Parameters.Add(new SqliteParameter("@fn", r.FlatNo ?? ""));
            cmd.Parameters.Add(new SqliteParameter("@fl", r.Floor ?? ""));
            cmd.Parameters.Add(new SqliteParameter("@sq", r.Sqft));
            cmd.Parameters.Add(new SqliteParameter("@mn", r.MemName ?? ""));
            cmd.Parameters.Add(new SqliteParameter("@mn1", r.MemName1 ?? ""));
            cmd.Parameters.Add(new SqliteParameter("@mn2", r.MemName2 ?? ""));
            cmd.Parameters.Add(new SqliteParameter("@mn3", r.MemName3 ?? ""));
            cmd.Parameters.Add(new SqliteParameter("@nd", r.NocDetail ?? ""));
            cmd.Parameters.Add(new SqliteParameter("@pd", r.ParkDetail ?? ""));
            cmd.Parameters.Add(new SqliteParameter("@ld", r.LaonDetail ?? ""));
            cmd.Parameters.Add(new SqliteParameter("@pdt", r.Poss_Date ?? ""));
            cmd.Parameters.Add(new SqliteParameter("@me", r.MemEmail ?? ""));
            cmd.Parameters.Add(new SqliteParameter("@mm", r.MemMobile ?? ""));
            cmd.Parameters.Add(new SqliteParameter("@fd", r.FamilyDetail ?? ""));
            cmd.Parameters.Add(new SqliteParameter("@sd", r.ServantDetail ?? ""));
            cmd.Parameters.Add(new SqliteParameter("@bn", r.BankName ?? ""));
            cmd.Parameters.Add(new SqliteParameter("@dp", r.DefaPart ?? ""));
            cmd.Parameters.Add(new SqliteParameter("@op", r.Op_Prin));
            cmd.Parameters.Add(new SqliteParameter("@oi", r.Op_Int));
            cmd.Parameters.Add(new SqliteParameter("@drp", r.DrTR_Prin));
            cmd.Parameters.Add(new SqliteParameter("@dri", r.DrTR_Int));
            cmd.Parameters.Add(new SqliteParameter("@crp", r.CrTR_Prin));
            cmd.Parameters.Add(new SqliteParameter("@cri", r.CrTR_Int));
            cmd.Parameters.Add(new SqliteParameter("@clp", r.Cl_Prin));
            cmd.Parameters.Add(new SqliteParameter("@cli", r.Cl_Int));
            cmd.Parameters.Add(new SqliteParameter("@it", r.IsTransfer ?? ""));
            cmd.Parameters.Add(new SqliteParameter("@ma", r.MemAddress ?? ""));
            cmd.Parameters.Add(new SqliteParameter("@ut", r.UnitType ?? ""));
            cmd.Parameters.Add(new SqliteParameter("@at", r.AreaType ?? ""));
            cmd.Parameters.Add(new SqliteParameter("@au", r.AreaUnit ?? ""));
        }
    }
}
