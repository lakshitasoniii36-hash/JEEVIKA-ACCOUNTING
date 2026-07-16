namespace Infrastructure.Repositories;

/// <summary>
/// Repository resolver for resolving repository instances
/// </summary>
public interface IRepositoryResolver
{
    /// <summary>
    /// Resolves a repository instance for the specified entity type
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    /// <returns>Repository instance</returns>
    IRepository<TEntity> Resolve<TEntity>() where TEntity : class;

    /// <summary>
    /// Resolves a repository instance for the specified entity type
    /// </summary>
    /// <param name="entityType">Entity type</param>
    /// <returns>Repository instance</returns>
    object? Resolve(Type entityType);
}

/// <summary>
/// Repository resolver implementation using factory and registry
/// </summary>
public class RepositoryResolver : IRepositoryResolver
{
    private readonly IRepositoryFactory _factory;
    private readonly IRepositoryRegistry _registry;

    public RepositoryResolver(IRepositoryFactory factory, IRepositoryRegistry registry)
    {
        _factory = factory;
        _registry = registry;
    }

    public IRepository<TEntity> Resolve<TEntity>() where TEntity : class
    {
        return _factory.CreateRepository<TEntity>();
    }

    public object? Resolve(Type entityType)
    {
        var repositoryType = _registry.GetRepositoryType(entityType);
        if (repositoryType == null)
            return null;

        var method = typeof(IRepositoryFactory).GetMethod(nameof(IRepositoryFactory.CreateRepository))?
            .MakeGenericMethod(entityType);

        return method?.Invoke(_factory, null);
    }
}
