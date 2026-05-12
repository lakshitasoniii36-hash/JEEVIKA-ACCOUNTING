// Stub — replaced by DbHelper.cs
namespace Backend
{
    public class DatabaseMigrator
    {
        public async Task<bool> MigrateIfNeededAsync() => await Task.FromResult(true);
        public async Task TestSqliteConnectionAsync() => await DbHelper.TestConnectionAsync();
        public async Task<List<string>> GetAllTablesAsync() => await Task.FromResult(new List<string>());
        public async Task<Dictionary<string, List<string>>> GetTableColumnsAsync(string t) => await Task.FromResult(new Dictionary<string, List<string>>());
    }
}
