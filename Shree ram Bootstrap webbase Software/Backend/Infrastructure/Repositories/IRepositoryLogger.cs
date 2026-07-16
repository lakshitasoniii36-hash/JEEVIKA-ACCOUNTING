namespace Infrastructure.Repositories;

/// <summary>
/// Repository logger interface for logging repository operations
/// </summary>
public interface IRepositoryLogger
{
    /// <summary>
    /// Logs a repository operation
    /// </summary>
    /// <param name="operation">Operation type</param>
    /// <param name="entityType">Entity type</param>
    /// <param name="entityId">Entity ID</param>
    /// <param name="details">Operation details</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task LogOperationAsync(RepositoryOperation operation, string entityType, object? entityId, string? details = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Logs a repository error
    /// </summary>
    /// <param name="operation">Operation type</param>
    /// <param name="entityType">Entity type</param>
    /// <param name="exception">Exception that occurred</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task LogErrorAsync(RepositoryOperation operation, string entityType, Exception exception, CancellationToken cancellationToken = default);
}

/// <summary>
/// Repository operation types
/// </summary>
public enum RepositoryOperation
{
    /// <summary>
    /// Read operation (Get, Find, Query)
    /// </summary>
    Read,

    /// <summary>
    /// Insert operation (Add)
    /// </summary>
    Insert,

    /// <summary>
    /// Update operation
    /// </summary>
    Update,

    /// <summary>
    /// Delete operation
    /// </summary>
    Delete,

    /// <summary>
    /// Transaction operation (Begin, Commit, Rollback)
    /// </summary>
    Transaction,

    /// <summary>
    /// Cache operation (Get, Set, Remove)
    /// </summary>
    Cache
}

/// <summary>
/// Default repository logger implementation (no-op)
/// </summary>
public class DefaultRepositoryLogger : IRepositoryLogger
{
    public Task LogOperationAsync(RepositoryOperation operation, string entityType, object? entityId, string? details = null, CancellationToken cancellationToken = default)
    {
        return Task.CompletedTask;
    }

    public Task LogErrorAsync(RepositoryOperation operation, string entityType, Exception exception, CancellationToken cancellationToken = default)
    {
        return Task.CompletedTask;
    }
}
