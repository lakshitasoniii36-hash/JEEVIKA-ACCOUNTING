using Microsoft.Extensions.DependencyInjection;
using Infrastructure.Repositories;
using Infrastructure.Repositories.Audit;
using Infrastructure.Repositories.Transactions;

namespace Infrastructure.DependencyInjection;

/// <summary>
/// Extension methods for registering repository services
/// </summary>
public static class RepositoryServiceCollectionExtensions
{
    /// <summary>
    /// Registers repository infrastructure services
    /// </summary>
    public static IServiceCollection AddRepositoryInfrastructure(this IServiceCollection services)
    {
        // Register repository context
        services.AddSingleton<IRepositoryContext, RepositoryContext>();

        // Register unit of work
        services.AddScoped<IUnitOfWork, UnitOfWork>();

        // Register repository factory
        services.AddSingleton<IRepositoryFactory, RepositoryFactory>();

        // Register repository registry
        services.AddSingleton<IRepositoryRegistry, RepositoryRegistry>();

        // Register repository resolver
        services.AddScoped<IRepositoryResolver, RepositoryResolver>();

        // Register default audit hooks
        services.AddTransient(typeof(IRepositoryAuditHooks<>), typeof(DefaultRepositoryAuditHooks<>));

        // Register default logger
        services.AddSingleton<IRepositoryLogger, DefaultRepositoryLogger>();

        // Register repository cache configuration
        services.AddSingleton<RepositoryCacheConfiguration>();

        return services;
    }

    /// <summary>
    /// Registers a repository for an entity type
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    /// <typeparam name="TRepository">Repository type</typeparam>
    /// <param name="services">Service collection</param>
    /// <param name="lifetime">Service lifetime</param>
    /// <returns>Service collection</returns>
    public static IServiceCollection AddRepository<TEntity, TRepository>(
        this IServiceCollection services,
        ServiceLifetime lifetime = ServiceLifetime.Scoped)
        where TEntity : class
        where TRepository : class, IRepository<TEntity>
    {
        // Register the repository
        services.Add(new ServiceDescriptor(
            typeof(IRepository<TEntity>),
            typeof(TRepository),
            lifetime));

        // Register the repository in the registry
        var serviceProvider = services.BuildServiceProvider();
        var registry = serviceProvider.GetRequiredService<IRepositoryRegistry>();
        registry.Register<TEntity, TRepository>();

        return services;
    }

    /// <summary>
    /// Registers a repository with scoped lifetime
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    /// <typeparam name="TRepository">Repository type</typeparam>
    /// <param name="services">Service collection</param>
    /// <returns>Service collection</returns>
    public static IServiceCollection AddScopedRepository<TEntity, TRepository>(this IServiceCollection services)
        where TEntity : class
        where TRepository : class, IRepository<TEntity>
    {
        return services.AddRepository<TEntity, TRepository>(ServiceLifetime.Scoped);
    }

    /// <summary>
    /// Registers a repository with transient lifetime
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    /// <typeparam name="TRepository">Repository type</typeparam>
    /// <param name="services">Service collection</param>
    /// <returns>Service collection</returns>
    public static IServiceCollection AddTransientRepository<TEntity, TRepository>(this IServiceCollection services)
        where TEntity : class
        where TRepository : class, IRepository<TEntity>
    {
        return services.AddRepository<TEntity, TRepository>(ServiceLifetime.Transient);
    }

    /// <summary>
    /// Registers a repository with singleton lifetime
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    /// <typeparam name="TRepository">Repository type</typeparam>
    /// <param name="services">Service collection</param>
    /// <returns>Service collection</returns>
    public static IServiceCollection AddSingletonRepository<TEntity, TRepository>(this IServiceCollection services)
        where TEntity : class
        where TRepository : class, IRepository<TEntity>
    {
        return services.AddRepository<TEntity, TRepository>(ServiceLifetime.Singleton);
    }
}
