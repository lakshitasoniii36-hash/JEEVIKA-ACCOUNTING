namespace Infrastructure.Configuration;

/// <summary>
/// Interface for configuration management
/// </summary>
public interface IPlatformConfigurationManager
{
    /// <summary>
    /// Gets a configuration value
    /// </summary>
    string GetValue(string key);

    /// <summary>
    /// Gets a configuration value with default
    /// </summary>
    string GetValue(string key, string defaultValue);

    /// <summary>
    /// Gets a configuration section
    /// </summary>
    IPlatformConfigurationSection GetSection(string key);

    /// <summary>
    /// Sets a configuration value
    /// </summary>
    void SetValue(string key, string value);
}

/// <summary>
/// Configuration section interface
/// </summary>
public interface IPlatformConfigurationSection
{
    string Key { get; }
    string Value { get; }
    string this[string key] { get; }
}
