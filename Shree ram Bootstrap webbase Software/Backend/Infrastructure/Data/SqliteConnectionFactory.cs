using Microsoft.Data.Sqlite;

namespace Infrastructure.Data;

/// <summary>
/// SQLite connection factory with connection pooling, shared cache, WAL, and busy timeout
/// </summary>
public class SqliteConnectionFactory : IDbConnectionFactory
{
    private readonly string _defaultDatabasePath;
    private readonly int _busyTimeoutMs;

    public SqliteConnectionFactory(string defaultDatabasePath, int busyTimeoutMs = 5000)
    {
        _defaultDatabasePath = defaultDatabasePath;
        _busyTimeoutMs = busyTimeoutMs;
        
        // Ensure directory exists
        var directory = System.IO.Path.GetDirectoryName(_defaultDatabasePath);
        if (!string.IsNullOrEmpty(directory) && !System.IO.Directory.Exists(directory))
        {
            System.IO.Directory.CreateDirectory(directory);
        }
    }

    public SqliteConnection CreateConnection()
    {
        return CreateConnection(_defaultDatabasePath);
    }

    public SqliteConnection CreateConnection(string databasePath)
    {
        var connectionStringBuilder = new SqliteConnectionStringBuilder
        {
            DataSource = databasePath,
            Mode = SqliteOpenMode.ReadWriteCreate,
            Cache = SqliteCacheMode.Shared,
            Pooling = true
        };

        var connection = new SqliteConnection(connectionStringBuilder.ToString());
        connection.Open();

        // Configure WAL mode for better concurrency
        using var command = connection.CreateCommand();
        command.CommandText = "PRAGMA journal_mode=WAL;";
        command.ExecuteNonQuery();

        // Configure busy timeout
        command.CommandText = $"PRAGMA busy_timeout={_busyTimeoutMs};";
        command.ExecuteNonQuery();

        // Configure synchronous mode for better performance
        command.CommandText = "PRAGMA synchronous=NORMAL;";
        command.ExecuteNonQuery();

        // Configure cache size (default -2000KB, increase for better performance)
        command.CommandText = "PRAGMA cache_size=-10000;";
        command.ExecuteNonQuery();

        // Configure temp store to memory for better performance
        command.CommandText = "PRAGMA temp_store=MEMORY;";
        command.ExecuteNonQuery();

        return connection;
    }

    public string GetDefaultDatabasePath()
    {
        return _defaultDatabasePath;
    }
}
