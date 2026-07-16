using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Repositories;

/// <summary>
/// Repository factory for creating repository instances
/// </summary>
public interface IRepositoryFactory
{
    /// <summary>
    /// Creates a repository instance for the specified entity type
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    /// <typeparam name="TRepository">Repository type</typeparam>
    /// <returns>Repository instance</returns>
    TRepository CreateRepository<TEntity, TRepository>() where TEntity : class where TRepository : IRepository<TEntity>;

    /// <summary>
    /// Creates a repository instance for the specified entity type
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    /// <returns>Repository instance</returns>
    IRepository<TEntity> CreateRepository<TEntity>() where TEntity : class;
}

/// <summary>
/// Repository factory implementation using service provider
/// </summary>
public class RepositoryFactory : IRepositoryFactory
{
    private readonly IServiceProvider _serviceProvider;

    public RepositoryFactory(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public TRepository CreateRepository<TEntity, TRepository>() where TEntity : class where TRepository : IRepository<TEntity>
    {
        return _serviceProvider.GetRequiredService<TRepository>();
    }

    public IRepository<TEntity> CreateRepository<TEntity>() where TEntity : class
    {
        return _serviceProvider.GetRequiredService<IRepository<TEntity>>();
    }
}
