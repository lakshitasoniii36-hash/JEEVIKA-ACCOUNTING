using Infrastructure.Repositories.Queries;

namespace Infrastructure.Repositories;

/// <summary>
/// Base repository interface with common CRUD operations (legacy - kept for backward compatibility)
/// </summary>
/// <typeparam name="T">Entity type</typeparam>
/// <typeparam name="TId">ID type</typeparam>
public interface IRepository<T, TId> where T : class
{
    /// <summary>
    /// Gets entity by ID
    /// </summary>
    Task<T?> GetByIdAsync(TId id);

    /// <summary>
    /// Gets all entities
    /// </summary>
    Task<IEnumerable<T>> GetAllAsync();

    /// <summary>
    /// Adds a new entity
    /// </summary>
    Task AddAsync(T entity);

    /// <summary>
    /// Updates an existing entity
    /// </summary>
    Task UpdateAsync(T entity);

    /// <summary>
    /// Deletes an entity
    /// </summary>
    Task DeleteAsync(T entity);

    /// <summary>
    /// Checks if entity exists
    /// </summary>
    Task<bool> ExistsAsync(TId id);
}

/// <summary>
/// Combined repository interface inheriting from read and write repositories
/// </summary>
/// <typeparam name="TEntity">Entity type</typeparam>
public interface IRepository<TEntity> : IReadRepository<TEntity>, IWriteRepository<TEntity> where TEntity : class
{
}
