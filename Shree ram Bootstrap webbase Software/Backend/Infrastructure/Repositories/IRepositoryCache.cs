namespace Infrastructure.Repositories;

/// <summary>
/// Repository cache interface for caching repository operations
/// </summary>
public interface IRepositoryCache
{
    /// <summary>
    /// Gets a cached value
    /// </summary>
    /// <typeparam name="T">Value type</typeparam>
    /// <param name="key">Cache key</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Cached value or null if not found</returns>
    Task<T?> GetAsync<T>(string key, CancellationToken cancellationToken = default) where T : class;

    /// <summary>
    /// Sets a cached value
    /// </summary>
    /// <typeparam name="T">Value type</typeparam>
    /// <param name="key">Cache key</param>
    /// <param name="value">Value to cache</param>
    /// <param name="expiration">Expiration time</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task SetAsync<T>(string key, T value, TimeSpan? expiration = null, CancellationToken cancellationToken = default) where T : class;

    /// <summary>
    /// Removes a cached value
    /// </summary>
    /// <param name="key">Cache key</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task RemoveAsync(string key, CancellationToken cancellationToken = default);

    /// <summary>
    /// Removes cached values by pattern
    /// </summary>
    /// <param name="pattern">Key pattern</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task RemoveByPatternAsync(string pattern, CancellationToken cancellationToken = default);

    /// <summary>
    /// Clears all cached values
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    Task ClearAsync(CancellationToken cancellationToken = default);
}

/// <summary>
/// Repository cache configuration
/// </summary>
public class RepositoryCacheConfiguration
{
    /// <summary>
    /// Gets or sets whether caching is enabled
    /// </summary>
    public bool IsEnabled { get; set; } = false;

    /// <summary>
    /// Gets or sets the default cache expiration
    /// </summary>
    public TimeSpan DefaultExpiration { get; set; } = TimeSpan.FromMinutes(30);

    /// <summary>
    /// Gets or sets the cache key prefix
    /// </summary>
    public string KeyPrefix { get; set; } = "Repository:";

    /// <summary>
    /// Gets or sets whether to include company context in cache key
    /// </summary>
    public bool IncludeCompanyContext { get; set; } = true;

    /// <summary>
    /// Gets or sets whether to include year context in cache key
    /// </summary>
    public bool IncludeYearContext { get; set; } = true;

    /// <summary>
    /// Gets or sets whether to include user context in cache key
    /// </summary>
    public bool IncludeUserContext { get; set; } = false;
}
