using Infrastructure.Repositories.Queries;
using Infrastructure.Repositories.Specifications;

namespace Infrastructure.Repositories;

/// <summary>
/// Read-only repository interface for querying entities
/// </summary>
/// <typeparam name="TEntity">Entity type</typeparam>
public interface IReadRepository<TEntity> where TEntity : class
{
    /// <summary>
    /// Gets an entity by its ID
    /// </summary>
    /// <param name="id">Entity ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Entity or null if not found</returns>
    Task<TEntity?> GetByIdAsync(object id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets all entities
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>All entities</returns>
    Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Finds entities matching a specification
    /// </summary>
    /// <param name="specification">Query specification</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Matching entities</returns>
    Task<IEnumerable<TEntity>> FindAsync(ISpecification<TEntity> specification, CancellationToken cancellationToken = default);

    /// <summary>
    /// Finds the first entity matching a specification
    /// </summary>
    /// <param name="specification">Query specification</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>First matching entity or null</returns>
    Task<TEntity?> FirstOrDefaultAsync(ISpecification<TEntity> specification, CancellationToken cancellationToken = default);

    /// <summary>
    /// Checks if any entity matches a specification
    /// </summary>
    /// <param name="specification">Query specification</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if any entity matches</returns>
    Task<bool> AnyAsync(ISpecification<TEntity> specification, CancellationToken cancellationToken = default);

    /// <summary>
    /// Counts entities matching a specification
    /// </summary>
    /// <param name="specification">Query specification</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Count of matching entities</returns>
    Task<int> CountAsync(ISpecification<TEntity> specification, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets paged results
    /// </summary>
    /// <param name="query">Query object</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Paged result</returns>
    Task<PagedResult<TEntity>> GetPagedAsync(Query<TEntity> query, CancellationToken cancellationToken = default);

    /// <summary>
    /// Projects entities to a different type
    /// </summary>
    /// <typeparam name="TProjection">Projection type</typeparam>
    /// <param name="specification">Query specification</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Projected entities</returns>
    Task<IEnumerable<TProjection>> ProjectAsync<TProjection>(ISpecification<TEntity> specification, CancellationToken cancellationToken = default);
}
