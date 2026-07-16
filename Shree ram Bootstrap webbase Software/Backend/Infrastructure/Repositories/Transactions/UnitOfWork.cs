using Infrastructure.Data;
using Microsoft.Data.Sqlite;

namespace Infrastructure.Repositories.Transactions;

/// <summary>
/// Unit of Work implementation for transaction management
/// </summary>
public class UnitOfWork : IUnitOfWork
{
    private readonly IDbConnectionFactory _connectionFactory;
    private SqliteConnection? _connection;
    private SqliteTransaction? _transaction;
    private bool _disposed;

    public UnitOfWork(IDbConnectionFactory connectionFactory)
    {
        _connectionFactory = connectionFactory;
    }

    public TransactionStatus TransactionStatus { get; private set; } = TransactionStatus.None;
    public bool HasActiveTransaction => _transaction != null && TransactionStatus == TransactionStatus.InProgress;

    public async Task BeginTransactionAsync(CancellationToken cancellationToken = default)
    {
        if (HasActiveTransaction)
            throw new InvalidOperationException("Transaction already in progress");

        _connection = _connectionFactory.CreateConnection();
        _transaction = _connection.BeginTransaction();
        TransactionStatus = TransactionStatus.InProgress;

        await Task.CompletedTask;
    }

    public async Task CommitAsync(CancellationToken cancellationToken = default)
    {
        if (!HasActiveTransaction)
            throw new InvalidOperationException("No transaction in progress");

        try
        {
            await _transaction.CommitAsync(cancellationToken);
            TransactionStatus = TransactionStatus.Committed;
        }
        catch
        {
            TransactionStatus = TransactionStatus.Failed;
            throw;
        }
        finally
        {
            await DisposeTransactionAsync();
        }
    }

    public async Task RollbackAsync(CancellationToken cancellationToken = default)
    {
        if (!HasActiveTransaction)
            throw new InvalidOperationException("No transaction in progress");

        try
        {
            await _transaction.RollbackAsync(cancellationToken);
            TransactionStatus = TransactionStatus.RolledBack;
        }
        catch
        {
            TransactionStatus = TransactionStatus.Failed;
            throw;
        }
        finally
        {
            await DisposeTransactionAsync();
        }
    }

    public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        // Infrastructure placeholder - will be implemented with actual data context
        // For now, returns 0 to support architecture without business logic
        return await Task.FromResult(0);
    }

    private async Task DisposeTransactionAsync()
    {
        if (_transaction != null)
        {
            await _transaction.DisposeAsync();
            _transaction = null;
        }

        if (_connection != null)
        {
            await _connection.DisposeAsync();
            _connection = null;
        }

        TransactionStatus = TransactionStatus.None;
    }

    public void Dispose()
    {
        if (_disposed) return;

        if (_transaction != null)
        {
            _transaction.Dispose();
            _transaction = null;
        }

        if (_connection != null)
        {
            _connection.Dispose();
            _connection = null;
        }

        _disposed = true;
        GC.SuppressFinalize(this);
    }
}
