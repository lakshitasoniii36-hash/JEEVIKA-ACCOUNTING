using Microsoft.Data.Sqlite;

namespace Infrastructure.Data;

/// <summary>
/// Interface for database connection factory
/// </summary>
public interface IDbConnectionFactory
{
    /// <summary>
    /// Creates a new SQLite connection with configured settings
    /// </summary>
    SqliteConnection CreateConnection();

    /// <summary>
    /// Creates a new SQLite connection for a specific database
    /// </summary>
    SqliteConnection CreateConnection(string databasePath);

    /// <summary>
    /// Gets the default database path
    /// </summary>
    string GetDefaultDatabasePath();
}
