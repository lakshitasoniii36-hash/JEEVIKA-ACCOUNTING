using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Backend
{
    [ApiController]
    [Route("api/member")]
    public class MemberController : ControllerBase
    {
        private readonly string _sqliteDbPath = System.IO.Path.Combine(System.AppContext.BaseDirectory, "Data", "ShreeRam.sqlite");

        public class SocMemberModel
        {
            [JsonPropertyName("SocMemId")]
            public int SocMemberId { get; set; }
            
            [JsonPropertyName("SocAccountMainId")]
            public int SocAccountMainId { get; set; }
            
            [JsonPropertyName("MemCode")]
            public string? MemberCode { get; set; }
            
            [JsonPropertyName("Bldg")]
            public string? Bldg { get; set; }
            
            [JsonPropertyName("Wing")]
            public string? Wing { get; set; }
            
            [JsonPropertyName("FlatType")]
            public string? FlatType { get; set; }
            
            [JsonPropertyName("FlatNo")]
            public string? FlatNo { get; set; }
            
            [JsonPropertyName("Floor")]
            public string? Floor { get; set; }
            
            [JsonPropertyName("Sqft")]
            public double Sqft { get; set; }
            
            [JsonPropertyName("MemName")]
            public string? MemberName { get; set; }

            [JsonPropertyName("MemName1")]
            public string? MemName1 { get => MemberName; set => MemberName = value; }
            
            [JsonPropertyName("MemName2")]
            public string? MemName2 { get; set; }
            
            [JsonPropertyName("MemName3")]
            public string? MemName3 { get; set; }
            
            [JsonPropertyName("MemName4")]
            public string? MemName4 { get; set; }
            
            [JsonPropertyName("DefaPart")]
            public string? DefaPart { get; set; }
            
            [JsonPropertyName("NocDetail")]
            public string? NocDetail { get; set; }
            
            [JsonPropertyName("ParkDetail")]
            public string? ParkDetail { get; set; }
            
            [JsonPropertyName("LaonDetail")]
            public string? LaonDetail { get; set; }
            
            [JsonPropertyName("Poss_Date")]
            public string? Poss_Date { get; set; }
            
            [JsonPropertyName("MemEmail")]
            public string? Email { get; set; }
            
            [JsonPropertyName("MemMobile")]
            public string? ContactNo { get; set; }
            
            [JsonPropertyName("FamilyDetail")]
            public string? FamilyDetail { get; set; }
            
            [JsonPropertyName("ServantDetail")]
            public string? ServantDetail { get; set; }
            
            [JsonPropertyName("BankName")]
            public string? BankName { get; set; }
            
            [JsonPropertyName("BankAccountNo")]
            public string? BankAccountNo { get; set; }
            
            [JsonPropertyName("IFSCCode")]
            public string? IFSCCode { get; set; }
            
            [JsonPropertyName("Op_Prin")]
            public double Op_Prin { get; set; }
            
            [JsonPropertyName("Op_Int")]
            public double Op_Int { get; set; }
            
            [JsonPropertyName("DrTR_Prin")]
            public double DrTR_Prin { get; set; }
            
            [JsonPropertyName("DrTR_Int")]
            public double DrTR_Int { get; set; }
            
            [JsonPropertyName("CrTR_Prin")]
            public double CrTR_Prin { get; set; }
            
            [JsonPropertyName("CrTR_Int")]
            public double CrTR_Int { get; set; }
            
            [JsonPropertyName("Cl_Prin")]
            public double Cl_Prin { get; set; }
            
            [JsonPropertyName("Cl_Int")]
            public double Cl_Int { get; set; }
            
            [JsonPropertyName("IsTransfer")]
            public string? IsTransfer { get; set; }
            
            [JsonPropertyName("MemAddress")]
            public string? MemAddress { get; set; }
            
            [JsonPropertyName("UnitType")]
            public string? UnitType { get; set; }
            
            [JsonPropertyName("AreaType")]
            public string? AreaType { get; set; }
            
            [JsonPropertyName("AreaUnit")]
            public string? AreaUnit { get; set; }
            
            [JsonPropertyName("AreaCategory")]
            public string? AreaCategory { get; set; }
            
            [JsonPropertyName("MemMobile2")]
            public string? MemMobile2 { get; set; }
            
            [JsonPropertyName("MemEmail2")]
            public string? MemEmail2 { get; set; }
            
            [JsonPropertyName("Gstin")]
            public string? Gstin { get; set; }
            
            [JsonPropertyName("DuesFromMember")]
            public string? DuesFromMember { get; set; }
            
            [JsonPropertyName("LienMark")]
            public string? LienMark { get; set; }
            
            [JsonPropertyName("IsDeleted")]
            public int IsDeleted { get; set; }
        }

        private SqliteConnection GetConn()
        {
            var cs = new SqliteConnectionStringBuilder { DataSource = _sqliteDbPath, Mode = SqliteOpenMode.ReadWriteCreate }.ToString();
            return new SqliteConnection(cs);
        }

        private void EnsureTable()
        {
            // Database schema generation remains global on startup in DbHelper.cs to avoid concurrent sqlite write locks.
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
                cmd.CommandText = "SELECT * FROM SocMember WHERE IsDeleted = 0 ORDER BY FlatNo, MemberName";
                using var r = cmd.ExecuteReader();
                while (r.Read())
                {
                    list.Add(new SocMemberModel
                    {
                        SocMemberId = I(r, "SocMemberId"),
                        SocAccountMainId = I(r, "SocAccountMainId"),
                        MemberCode = S(r, "MemberCode"),
                        Bldg = S(r, "Bldg"),
                        Wing = S(r, "Wing"),
                        FlatType = S(r, "FlatType"),
                        FlatNo = S(r, "FlatNo"),
                        Floor = S(r, "Floor"),
                        Sqft = D(r, "Sqft"),
                        MemberName = S(r, "MemberName"),
                        MemName2 = S(r, "MemName2"),
                        MemName3 = S(r, "MemName3"),
                        MemName4 = S(r, "MemName4"),
                        DefaPart = S(r, "DefaPart"),
                        NocDetail = S(r, "NocDetail"),
                        ParkDetail = S(r, "ParkDetail"),
                        LaonDetail = S(r, "LaonDetail"),
                        Poss_Date = S(r, "Poss_Date"),
                        Email = S(r, "Email"),
                        ContactNo = S(r, "ContactNo"),
                        FamilyDetail = S(r, "FamilyDetail"),
                        ServantDetail = S(r, "ServantDetail"),
                        BankName = S(r, "BankName"),
                        BankAccountNo = S(r, "BankAccountNo"),
                        IFSCCode = S(r, "IFSCCode"),
                        Op_Prin = D(r, "Op_Prin"),
                        Op_Int = D(r, "Op_Int"),
                        DrTR_Prin = D(r, "DrTR_Prin"),
                        DrTR_Int = D(r, "DrTR_Int"),
                        CrTR_Prin = D(r, "CrTR_Prin"),
                        CrTR_Int = D(r, "CrTR_Int"),
                        Cl_Prin = D(r, "Cl_Prin"),
                        Cl_Int = D(r, "Cl_Int"),
                        IsTransfer = S(r, "IsTransfer"),
                        MemAddress = S(r, "MemAddress"),
                        UnitType = S(r, "UnitType"),
                        AreaType = S(r, "AreaType"),
                        AreaUnit = S(r, "AreaUnit"),
                        AreaCategory = S(r, "AreaCategory"),
                        MemMobile2 = S(r, "MemMobile2"),
                        MemEmail2 = S(r, "MemEmail2"),
                        Gstin = S(r, "Gstin"),
                        DuesFromMember = S(r, "DuesFromMember"),
                        LienMark = S(r, "LienMark"),
                        IsDeleted = I(r, "IsDeleted")
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
                cmd.CommandText = "SELECT * FROM SocMember WHERE SocMemberId=@id";
                cmd.Parameters.Add(new SqliteParameter("@id", id));
                using var r = cmd.ExecuteReader();
                if (r.Read())
                {
                    var m = new SocMemberModel
                    {
                        SocMemberId = I(r, "SocMemberId"),
                        SocAccountMainId = I(r, "SocAccountMainId"),
                        MemberCode = S(r, "MemberCode"),
                        Bldg = S(r, "Bldg"),
                        Wing = S(r, "Wing"),
                        FlatType = S(r, "FlatType"),
                        FlatNo = S(r, "FlatNo"),
                        Floor = S(r, "Floor"),
                        Sqft = D(r, "Sqft"),
                        MemberName = S(r, "MemberName"),
                        MemName2 = S(r, "MemName2"),
                        MemName3 = S(r, "MemName3"),
                        MemName4 = S(r, "MemName4"),
                        DefaPart = S(r, "DefaPart"),
                        NocDetail = S(r, "NocDetail"),
                        ParkDetail = S(r, "ParkDetail"),
                        LaonDetail = S(r, "LaonDetail"),
                        Poss_Date = S(r, "Poss_Date"),
                        Email = S(r, "Email"),
                        ContactNo = S(r, "ContactNo"),
                        FamilyDetail = S(r, "FamilyDetail"),
                        ServantDetail = S(r, "ServantDetail"),
                        BankName = S(r, "BankName"),
                        BankAccountNo = S(r, "BankAccountNo"),
                        IFSCCode = S(r, "IFSCCode"),
                        Op_Prin = D(r, "Op_Prin"),
                        Op_Int = D(r, "Op_Int"),
                        DrTR_Prin = D(r, "DrTR_Prin"),
                        DrTR_Int = D(r, "DrTR_Int"),
                        CrTR_Prin = D(r, "CrTR_Prin"),
                        CrTR_Int = D(r, "CrTR_Int"),
                        Cl_Prin = D(r, "Cl_Prin"),
                        Cl_Int = D(r, "Cl_Int"),
                        IsTransfer = S(r, "IsTransfer"),
                        MemAddress = S(r, "MemAddress"),
                        UnitType = S(r, "UnitType"),
                        AreaType = S(r, "AreaType"),
                        AreaUnit = S(r, "AreaUnit"),
                        AreaCategory = S(r, "AreaCategory"),
                        MemMobile2 = S(r, "MemMobile2"),
                        MemEmail2 = S(r, "MemEmail2"),
                        Gstin = S(r, "Gstin"),
                        DuesFromMember = S(r, "DuesFromMember"),
                        LienMark = S(r, "LienMark"),
                        IsDeleted = I(r, "IsDeleted")
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
                if (string.IsNullOrWhiteSpace(req.MemberName)) return BadRequest(new { success = false, message = "Member Name required" });
                if (string.IsNullOrWhiteSpace(req.FlatNo)) return BadRequest(new { success = false, message = "Flat No required" });
                EnsureTable();
                using var conn = GetConn(); conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"INSERT INTO SocMember (SocAccountMainId,MemberCode,Bldg,Wing,FlatType,FlatNo,Floor,Sqft,
                    MemberName,MemName2,MemName3,MemName4,NocDetail,ParkDetail,LaonDetail,Poss_Date,
                    Email,ContactNo,FamilyDetail,ServantDetail,BankName,DefaPart,
                    Op_Prin,Op_Int,DrTR_Prin,DrTR_Int,CrTR_Prin,CrTR_Int,Cl_Prin,Cl_Int,IsTransfer,MemAddress,
                    UnitType,AreaType,AreaUnit,AreaCategory,BankAccountNo,IFSCCode,MemMobile2,MemEmail2,Gstin,DuesFromMember,LienMark,IsDeleted)
                    VALUES(@ami,@mc,@b,@w,@ft,@fn,@fl,@sq,@mn,@mn2,@mn3,@mn4,@nd,@pd,@ld,@pdt,
                    @me,@mm,@fd,@sd,@bn,@dp,@op,@oi,@drp,@dri,@crp,@cri,@clp,@cli,@it,@ma,
                    @ut,@at,@au,@ac,@ba,@ifsc,@mm2,@me2,@gst,@dfm,@lm,@idld)";
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
                if (string.IsNullOrWhiteSpace(req.MemberName)) return BadRequest(new { success = false, message = "Member Name required" });
                EnsureTable();
                using var conn = GetConn(); conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"UPDATE SocMember SET SocAccountMainId=@ami,MemberCode=@mc,Bldg=@b,Wing=@w,
                    FlatType=@ft,FlatNo=@fn,Floor=@fl,Sqft=@sq,MemberName=@mn,MemName2=@mn2,
                    MemName3=@mn3,MemName4=@mn4,NocDetail=@nd,ParkDetail=@pd,LaonDetail=@ld,Poss_Date=@pdt,
                    Email=@me,ContactNo=@mm,FamilyDetail=@fd,ServantDetail=@sd,BankName=@bn,
                    DefaPart=@dp,Op_Prin=@op,Op_Int=@oi,DrTR_Prin=@drp,DrTR_Int=@dri,
                    CrTR_Prin=@crp,CrTR_Int=@cri,Cl_Prin=@clp,Cl_Int=@cli,IsTransfer=@it,MemAddress=@ma,
                    UnitType=@ut,AreaType=@at,AreaUnit=@au,AreaCategory=@ac,BankAccountNo=@ba,IFSCCode=@ifsc,
                    MemMobile2=@mm2,MemEmail2=@me2,Gstin=@gst,DuesFromMember=@dfm,LienMark=@lm,IsDeleted=@idld
                    WHERE SocMemberId=@id";
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

                // Transaction check
                using (var checkCmd = conn.CreateCommand())
                {
                    checkCmd.CommandText = "SELECT MemberName, DrTR_Prin, DrTR_Int, CrTR_Prin, CrTR_Int FROM SocMember WHERE SocMemberId=@id";
                    checkCmd.Parameters.Add(new SqliteParameter("@id", id));
                    using var r = checkCmd.ExecuteReader();
                    if (r.Read())
                    {
                        double drp = r["DrTR_Prin"] != DBNull.Value ? Convert.ToDouble(r["DrTR_Prin"]) : 0;
                        double dri = r["DrTR_Int"] != DBNull.Value ? Convert.ToDouble(r["DrTR_Int"]) : 0;
                        double crp = r["CrTR_Prin"] != DBNull.Value ? Convert.ToDouble(r["CrTR_Prin"]) : 0;
                        double cri = r["CrTR_Int"] != DBNull.Value ? Convert.ToDouble(r["CrTR_Int"]) : 0;
                        string memberName = r["MemberName"]?.ToString() ?? "";
                        if (drp != 0 || dri != 0 || crp != 0 || cri != 0)
                        {
                            return BadRequest(new { success = false, message = $"Member '{memberName}' cannot be deleted because they have transaction history (Debit: {drp}/{dri}, Credit: {crp}/{cri}). Only cleared members can be deleted." });
                        }
                    }
                }

                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM SocMember WHERE SocMemberId=@id";
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
            cmd.Parameters.Add(new SqliteParameter("@mc", r.MemberCode ?? ""));
            cmd.Parameters.Add(new SqliteParameter("@b", r.Bldg ?? ""));
            cmd.Parameters.Add(new SqliteParameter("@w", r.Wing ?? ""));
            cmd.Parameters.Add(new SqliteParameter("@ft", r.FlatType ?? ""));
            cmd.Parameters.Add(new SqliteParameter("@fn", r.FlatNo ?? ""));
            cmd.Parameters.Add(new SqliteParameter("@fl", r.Floor ?? ""));
            cmd.Parameters.Add(new SqliteParameter("@sq", r.Sqft));
            cmd.Parameters.Add(new SqliteParameter("@mn", r.MemberName ?? ""));
            cmd.Parameters.Add(new SqliteParameter("@mn2", r.MemName2 ?? ""));
            cmd.Parameters.Add(new SqliteParameter("@mn3", r.MemName3 ?? ""));
            cmd.Parameters.Add(new SqliteParameter("@mn4", r.MemName4 ?? ""));
            cmd.Parameters.Add(new SqliteParameter("@nd", r.NocDetail ?? ""));
            cmd.Parameters.Add(new SqliteParameter("@pd", r.ParkDetail ?? ""));
            cmd.Parameters.Add(new SqliteParameter("@ld", r.LaonDetail ?? ""));
            cmd.Parameters.Add(new SqliteParameter("@pdt", r.Poss_Date ?? ""));
            cmd.Parameters.Add(new SqliteParameter("@me", r.Email ?? ""));
            cmd.Parameters.Add(new SqliteParameter("@mm", r.ContactNo ?? ""));
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
            cmd.Parameters.Add(new SqliteParameter("@ac", r.AreaCategory ?? ""));
            cmd.Parameters.Add(new SqliteParameter("@ba", r.BankAccountNo ?? ""));
            cmd.Parameters.Add(new SqliteParameter("@ifsc", r.IFSCCode ?? ""));
            cmd.Parameters.Add(new SqliteParameter("@mm2", r.MemMobile2 ?? ""));
            cmd.Parameters.Add(new SqliteParameter("@me2", r.MemEmail2 ?? ""));
            cmd.Parameters.Add(new SqliteParameter("@gst", r.Gstin ?? ""));
            cmd.Parameters.Add(new SqliteParameter("@dfm", r.DuesFromMember ?? ""));
            cmd.Parameters.Add(new SqliteParameter("@lm", r.LienMark ?? ""));
            cmd.Parameters.Add(new SqliteParameter("@idld", r.IsDeleted));
        }
    }
}
