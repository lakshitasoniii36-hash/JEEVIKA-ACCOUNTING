namespace Infrastructure.Repositories.Audit;

/// <summary>
/// Repository audit hooks interface for extensibility
/// </summary>
/// <typeparam name="TEntity">Entity type</typeparam>
public interface IRepositoryAuditHooks<TEntity> where TEntity : class
{
    /// <summary>
    /// Called before an entity is inserted
    /// </summary>
    /// <param name="entity">Entity to be inserted</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task BeforeInsertAsync(TEntity entity, CancellationToken cancellationToken = default);

    /// <summary>
    /// Called after an entity is inserted
    /// </summary>
    /// <param name="entity">Entity that was inserted</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task AfterInsertAsync(TEntity entity, CancellationToken cancellationToken = default);

    /// <summary>
    /// Called before an entity is updated
    /// </summary>
    /// <param name="entity">Entity to be updated</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task BeforeUpdateAsync(TEntity entity, CancellationToken cancellationToken = default);

    /// <summary>
    /// Called after an entity is updated
    /// </summary>
    /// <param name="entity">Entity that was updated</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task AfterUpdateAsync(TEntity entity, CancellationToken cancellationToken = default);

    /// <summary>
    /// Called before an entity is deleted
    /// </summary>
    /// <param name="entity">Entity to be deleted</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task BeforeDeleteAsync(TEntity entity, CancellationToken cancellationToken = default);

    /// <summary>
    /// Called after an entity is deleted
    /// </summary>
    /// <param name="entity">Entity that was deleted</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task AfterDeleteAsync(TEntity entity, CancellationToken cancellationToken = default);
}

/// <summary>
/// Default audit hooks implementation (no-op)
/// </summary>
/// <typeparam name="TEntity">Entity type</typeparam>
public class DefaultRepositoryAuditHooks<TEntity> : IRepositoryAuditHooks<TEntity> where TEntity : class
{
    public Task BeforeInsertAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        return Task.CompletedTask;
    }

    public Task AfterInsertAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        return Task.CompletedTask;
    }

    public Task BeforeUpdateAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        return Task.CompletedTask;
    }

    public Task AfterUpdateAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        return Task.CompletedTask;
    }

    public Task BeforeDeleteAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        return Task.CompletedTask;
    }

    public Task AfterDeleteAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        return Task.CompletedTask;
    }
}
