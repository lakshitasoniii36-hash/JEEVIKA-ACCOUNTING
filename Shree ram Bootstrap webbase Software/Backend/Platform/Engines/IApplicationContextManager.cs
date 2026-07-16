using Platform.Contexts;

namespace Platform.Engines;

/// <summary>
/// Application Context Manager interface for centralized context management
/// </summary>
public interface IApplicationContextManager
{
    /// <summary>
    /// Gets the current user context
    /// </summary>
    ICurrentUserContext UserContext { get; }

    /// <summary>
    /// Gets the current company context
    /// </summary>
    ICompanyContext CompanyContext { get; }

    /// <summary>
    /// Gets the current assessment year context
    /// </summary>
    IAssessmentYearContext AssessmentYearContext { get; }

    /// <summary>
    /// Gets the current permission context
    /// </summary>
    IPermissionContext PermissionContext { get; }

    /// <summary>
    /// Gets the current environment context
    /// </summary>
    IEnvironmentContext EnvironmentContext { get; }

    /// <summary>
    /// Gets the current database context
    /// </summary>
    IDatabaseContext DatabaseContext { get; }

    /// <summary>
    /// Initializes the application context with default values
    /// </summary>
    Task InitializeAsync();

    /// <summary>
    /// Validates that all required contexts are initialized
    /// </summary>
    /// <returns>True if all contexts are valid, false otherwise</returns>
    Task<bool> ValidateContextsAsync();

    /// <summary>
    /// Gets the current context snapshot
    /// </summary>
    /// <returns>Context snapshot containing all current context information</returns>
    Task<ContextSnapshot> GetContextSnapshotAsync();

    /// <summary>
    /// Sets the complete context from a snapshot
    /// </summary>
    /// <param name="snapshot">Context snapshot to apply</param>
    Task SetContextFromSnapshotAsync(ContextSnapshot snapshot);

    /// <summary>
    /// Clears all contexts
    /// </summary>
    Task ClearAllContextsAsync();
}

/// <summary>
/// Database context interface for future database switching
/// </summary>
public interface IDatabaseContext
{
    /// <summary>
    /// Gets the current database name
    /// </summary>
    string? DatabaseName { get; }

    /// <summary>
    /// Gets the current database path
    /// </summary>
    string? DatabasePath { get; }

    /// <summary>
    /// Gets the current database connection string
    /// </summary>
    string? ConnectionString { get; }

    /// <summary>
    /// Checks if a database context is set
    /// </summary>
    bool HasDatabaseContext { get; }

    /// <summary>
    /// Sets the current database context
    /// </summary>
    /// <param name="databaseName">Database name</param>
    /// <param name="databasePath">Database path</param>
    /// <param name="connectionString">Connection string</param>
    Task SetDatabaseAsync(string databaseName, string databasePath, string connectionString);

    /// <summary>
    /// Clears the current database context
    /// </summary>
    Task ClearDatabaseAsync();
}

/// <summary>
/// Context snapshot model containing all context information
/// </summary>
public class ContextSnapshot
{
    public string? UserId { get; set; }
    public string? Username { get; set; }
    public string? UserType { get; set; }
    public string? UserLevel { get; set; }
    public string? CompanyId { get; set; }
    public string? CompanyCode { get; set; }
    public string? CompanyName { get; set; }
    public string? YearId { get; set; }
    public string? Year { get; set; }
    public DateTime? YearStart { get; set; }
    public DateTime? YearEnd { get; set; }
    public List<string> Roles { get; set; } = new();
    public List<string> Permissions { get; set; } = new();
    public string? EnvironmentName { get; set; }
    public string? DatabaseName { get; set; }
    public string? Language { get; set; }
    public string? Currency { get; set; }
    public string? Timezone { get; set; }
    public string? Branch { get; set; }
    public DateTime SnapshotTime { get; set; } = DateTime.UtcNow;
}
