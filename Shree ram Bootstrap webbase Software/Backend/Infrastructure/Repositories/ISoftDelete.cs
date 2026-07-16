namespace Infrastructure.Repositories;

/// <summary>
/// Soft delete interface for entities that support soft deletion
/// </summary>
public interface ISoftDelete
{
    /// <summary>
    /// Gets or sets whether the entity is deleted
    /// </summary>
    bool IsDeleted { get; set; }

    /// <summary>
    /// Gets or sets the deletion date
    /// </summary>
    DateTime? DeletedAt { get; set; }

    /// <summary>
    /// Gets or sets the ID of the user who deleted the entity
    /// </summary>
    string? DeletedBy { get; set; }
}

/// <summary>
/// Soft delete repository interface
/// </summary>
/// <typeparam name="TEntity">Entity type</typeparam>
public interface ISoftDeleteRepository<TEntity> where TEntity : class, ISoftDelete
{
    /// <summary>
    /// Soft deletes an entity
    /// </summary>
    /// <param name="entity">Entity to soft delete</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task SoftDeleteAsync(TEntity entity, CancellationToken cancellationToken = default);

    /// <summary>
    /// Restores a soft deleted entity
    /// </summary>
    /// <param name="entity">Entity to restore</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task RestoreAsync(TEntity entity, CancellationToken cancellationToken = default);

    /// <summary>
    /// Permanently deletes a soft deleted entity
    /// </summary>
    /// <param name="entity">Entity to permanently delete</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task PermanentDeleteAsync(TEntity entity, CancellationToken cancellationToken = default);
}
