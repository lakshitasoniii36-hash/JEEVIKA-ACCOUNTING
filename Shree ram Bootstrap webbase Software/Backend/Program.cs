using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(o => o.AddDefaultPolicy(
    p => p.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();

Console.WriteLine("=== Jeevika ERP Backend Starting ===");
try { Backend.DbHelper.InitAll(); }
catch (Exception ex) { Console.WriteLine($"[DB INIT ERROR] {ex.Message}"); }

app.UseCors();
app.UseAuthorization();
app.MapControllers();
Console.WriteLine("=== Running at http://localhost:5002 ===");
app.Run("http://localhost:5002");
