using Infrastructure.Caching;
using Infrastructure.Configuration;
using Infrastructure.Data;
using Infrastructure.Logging;
using Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.DependencyInjection;

/// <summary>
/// Extension methods for registering infrastructure services
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Registers infrastructure services
    /// </summary>
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, string databasePath)
    {
        // Register database connection factory
        services.AddSingleton<IDbConnectionFactory>(sp => 
            new SqliteConnectionFactory(databasePath));

        // Register caching services
        services.AddSingleton<IPlatformCache, InMemoryCache>();
        services.AddSingleton<IPlatformMemoryCache, InMemoryCache>();

        // Register logging service
        services.AddSingleton<IPlatformLogger, ConsoleLogger>();

        // Register configuration manager
        services.AddSingleton<IPlatformConfigurationManager, ConfigurationManager>();

        return services;
    }
}

/// <summary>
/// In-memory cache implementation (placeholder)
/// </summary>
internal class InMemoryCache : IPlatformMemoryCache
{
    private readonly Dictionary<string, object> _cache = new();

    public Task<T?> GetAsync<T>(string key)
    {
        if (_cache.TryGetValue(key, out var value))
        {
            return Task.FromResult((T?)value);
        }
        return Task.FromResult(default(T));
    }

    public Task SetAsync<T>(string key, T value, TimeSpan? expiration = null)
    {
        _cache[key] = value;
        return Task.CompletedTask;
    }

    public Task RemoveAsync(string key)
    {
        _cache.Remove(key);
        return Task.CompletedTask;
    }

    public Task<bool> ExistsAsync(string key)
    {
        return Task.FromResult(_cache.ContainsKey(key));
    }

    public Task ClearAsync()
    {
        _cache.Clear();
        return Task.CompletedTask;
    }
}

/// <summary>
/// Console logger implementation (placeholder)
/// </summary>
internal class ConsoleLogger : IPlatformLogger
{
    public void LogDebug(string message, params object[] args)
    {
        Console.WriteLine($"[DEBUG] {string.Format(message, args)}");
    }

    public void LogInfo(string message, params object[] args)
    {
        Console.WriteLine($"[INFO] {string.Format(message, args)}");
    }

    public void LogWarning(string message, params object[] args)
    {
        Console.WriteLine($"[WARN] {string.Format(message, args)}");
    }

    public void LogError(string message, params object[] args)
    {
        Console.WriteLine($"[ERROR] {string.Format(message, args)}");
    }

    public void LogError(Exception exception, string message, params object[] args)
    {
        Console.WriteLine($"[ERROR] {string.Format(message, args)} - {exception.Message}");
    }

    public void LogCritical(string message, params object[] args)
    {
        Console.WriteLine($"[CRITICAL] {string.Format(message, args)}");
    }
}

/// <summary>
/// Configuration manager implementation (placeholder)
/// </summary>
internal class ConfigurationManager : IPlatformConfigurationManager
{
    private readonly Dictionary<string, string> _config = new();

    public string GetValue(string key)
    {
        return _config.TryGetValue(key, out var value) ? value : string.Empty;
    }

    public string GetValue(string key, string defaultValue)
    {
        return _config.TryGetValue(key, out var value) ? value : defaultValue;
    }

    public IPlatformConfigurationSection GetSection(string key)
    {
        return new ConfigurationSection(key, GetValue(key));
    }

    public void SetValue(string key, string value)
    {
        _config[key] = value;
    }

    private class ConfigurationSection : IPlatformConfigurationSection
    {
        private readonly string _key;
        private readonly string _value;

        public ConfigurationSection(string key, string value)
        {
            _key = key;
            _value = value;
        }

        public string Key => _key;
        public string Value => _value;
        public string this[string key] => string.Empty;
    }
}
