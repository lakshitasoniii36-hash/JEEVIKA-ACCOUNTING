using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Collections.Generic;

namespace Backend
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            try
            {
                using var conn = DbHelper.GetConn();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM SoftUser";
                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string dbUser = null, dbPass = null, dbType = "USER", dbLevel = "1";
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        var col = reader.GetName(i).Trim().ToLower();
                        var val = reader.GetValue(i)?.ToString()?.Trim() ?? "";
                        if (col == "username")     dbUser  = val;
                        else if (col == "userpassword") dbPass  = val;
                        else if (col == "usertype")     dbType  = val;
                        else if (col == "userlevel")    dbLevel = val;
                    }

                    if (dbUser == request.Username?.Trim() && dbPass == request.Password?.Trim())
                    {
                        var token = GenerateJwtToken(dbUser);
                        return Ok(new { success = true, token, userName = dbUser, userType = dbType, userLevel = dbLevel });
                    }
                }

                return Unauthorized(new { success = false, message = "Invalid credentials" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { success = false, message = $"Database error: {ex.Message}" });
            }
        }

        [HttpGet("debug-tables")]
        public IActionResult DebugTables()
        {
            try
            {
                using var conn = DbHelper.GetConn();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT name FROM sqlite_master WHERE type='table' ORDER BY name";
                using var r = cmd.ExecuteReader();
                var tables = new List<string>();
                while (r.Read()) tables.Add(r.GetString(0));
                return Ok(new { success = true, tables });
            }
            catch (Exception ex) { return Ok(new { success = false, error = ex.Message }); }
        }

        [HttpGet("debug-users")]
        public IActionResult DebugUsers()
        {
            try
            {
                using var conn = DbHelper.GetConn();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT LogId, UserName, UserType, UserLevel FROM SoftUser";
                using var r = cmd.ExecuteReader();
                var users = new List<object>();
                while (r.Read())
                    users.Add(new { id = r["LogId"], user = r["UserName"], type = r["UserType"], level = r["UserLevel"] });
                return Ok(new { success = true, users });
            }
            catch (Exception ex) { return Ok(new { success = false, error = ex.Message }); }
        }

        private static string GenerateJwtToken(string username)
        {
            var key = Encoding.ASCII.GetBytes("jeevika_erp_secret_key_12345678901234");
            var descriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, username) }),
                Expires = DateTime.UtcNow.AddHours(8),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var handler = new JwtSecurityTokenHandler();
            return handler.WriteToken(handler.CreateToken(descriptor));
        }
    }

    public class LoginRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
