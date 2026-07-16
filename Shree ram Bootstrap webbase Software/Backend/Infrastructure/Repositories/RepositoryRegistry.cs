namespace Infrastructure.Repositories;

/// <summary>
/// Repository registry for tracking registered repositories
/// </summary>
public interface IRepositoryRegistry
{
    /// <summary>
    /// Registers a repository type
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    /// <typeparam name="TRepository">Repository type</typeparam>
    void Register<TEntity, TRepository>() where TEntity : class where TRepository : IRepository<TEntity>;

    /// <summary>
    /// Gets the repository type for an entity type
    /// </summary>
    /// <param name="entityType">Entity type</param>
    /// <returns>Repository type or null if not registered</returns>
    Type? GetRepositoryType(Type entityType);

    /// <summary>
    /// Checks if a repository is registered for an entity type
    /// </summary>
    /// <param name="entityType">Entity type</param>
    /// <returns>True if registered</returns>
    bool IsRegistered(Type entityType);

    /// <summary>
    /// Gets all registered entity types
    /// </summary>
    /// <returns>Registered entity types</returns>
    IEnumerable<Type> GetRegisteredEntityTypes();
}

/// <summary>
/// Repository registry implementation
/// </summary>
public class RepositoryRegistry : IRepositoryRegistry
{
    private readonly Dictionary<Type, Type> _repositoryTypes = new();

    public void Register<TEntity, TRepository>() where TEntity : class where TRepository : IRepository<TEntity>
    {
        _repositoryTypes[typeof(TEntity)] = typeof(TRepository);
    }

    public Type? GetRepositoryType(Type entityType)
    {
        return _repositoryTypes.TryGetValue(entityType, out var repositoryType) ? repositoryType : null;
    }

    public bool IsRegistered(Type entityType)
    {
        return _repositoryTypes.ContainsKey(entityType);
    }

    public IEnumerable<Type> GetRegisteredEntityTypes()
    {
        return _repositoryTypes.Keys;
    }
}
