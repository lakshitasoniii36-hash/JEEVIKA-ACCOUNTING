using Core.Exceptions;

namespace Platform.Engines;

/// <summary>
/// Database Context implementation for future database switching
/// </summary>
public class DatabaseContext : IDatabaseContext
{
    private string? _databaseName;
    private string? _databasePath;
    private string? _connectionString;

    public string? DatabaseName => _databaseName;
    public string? DatabasePath => _databasePath;
    public string? ConnectionString => _connectionString;
    public bool HasDatabaseContext => !string.IsNullOrEmpty(_databaseName);

    public Task SetDatabaseAsync(string databaseName, string databasePath, string connectionString)
    {
        if (string.IsNullOrWhiteSpace(databaseName))
            throw new ValidationException("Database name cannot be empty");

        _databaseName = databaseName.Trim();
        _databasePath = databasePath?.Trim();
        _connectionString = connectionString?.Trim();

        return Task.CompletedTask;
    }

    public Task ClearDatabaseAsync()
    {
        _databaseName = null;
        _databasePath = null;
        _connectionString = null;

        return Task.CompletedTask;
    }
}
