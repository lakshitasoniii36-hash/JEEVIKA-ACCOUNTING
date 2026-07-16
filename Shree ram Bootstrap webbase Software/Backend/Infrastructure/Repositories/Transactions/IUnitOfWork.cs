namespace Infrastructure.Repositories.Transactions;

/// <summary>
/// Unit of Work interface for transaction management
/// </summary>
public interface IUnitOfWork : IDisposable
{
    /// <summary>
    /// Begins a new transaction
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    Task BeginTransactionAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Commits the current transaction
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    Task CommitAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Rolls back the current transaction
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    Task RollbackAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets the current transaction status
    /// </summary>
    TransactionStatus TransactionStatus { get; }

    /// <summary>
    /// Gets whether a transaction is active
    /// </summary>
    bool HasActiveTransaction { get; }

    /// <summary>
    /// Saves all changes made in this unit of work
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Number of entities affected</returns>
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}

/// <summary>
/// Transaction status enumeration
/// </summary>
public enum TransactionStatus
{
    /// <summary>
    /// No transaction active
    /// </summary>
    None,

    /// <summary>
    /// Transaction in progress
    /// </summary>
    InProgress,

    /// <summary>
    /// Transaction committed
    /// </summary>
    Committed,

    /// <summary>
    /// Transaction rolled back
    /// </summary>
    RolledBack,

    /// <summary>
    /// Transaction failed
    /// </summary>
    Failed
}
