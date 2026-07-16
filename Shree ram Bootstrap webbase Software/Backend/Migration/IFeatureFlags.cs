namespace Migration;

/// <summary>
/// Feature flags interface for switching between legacy and new implementations
/// </summary>
public interface IFeatureFlags
{
    /// <summary>
    /// Checks if a feature is enabled
    /// </summary>
    /// <param name="featureName">Feature name</param>
    /// <returns>True if feature is enabled</returns>
    bool IsEnabled(string featureName);

    /// <summary>
    /// Enables a feature
    /// </summary>
    /// <param name="featureName">Feature name</param>
    void Enable(string featureName);

    /// <summary>
    /// Disables a feature
    /// </summary>
    /// <param name="featureName">Feature name</param>
    void Disable(string featureName);

    /// <summary>
    /// Gets all feature flags
    /// </summary>
    /// <returns>All feature flags</returns>
    IDictionary<string, bool> GetAllFlags();
}

/// <summary>
/// Default feature flags implementation
/// </summary>
public class FeatureFlags : IFeatureFlags
{
    private readonly Dictionary<string, bool> _flags = new();

    public bool IsEnabled(string featureName)
    {
        return _flags.TryGetValue(featureName, out var isEnabled) && isEnabled;
    }

    public void Enable(string featureName)
    {
        _flags[featureName] = true;
    }

    public void Disable(string featureName)
    {
        _flags[featureName] = false;
    }

    public IDictionary<string, bool> GetAllFlags()
    {
        return new Dictionary<string, bool>(_flags);
    }
}

/// <summary>
/// Feature flag names for migration
/// </summary>
public static class MigrationFeatureFlags
{
    /// <summary>
    /// Use new implementation for the specified module
    /// </summary>
    public const string UseNewImplementation = "UseNewImplementation_{0}";

    /// <summary>
    /// Enable new repository for the specified module
    /// </summary>
    public const string UseNewRepository = "UseNewRepository_{0}";

    /// <summary>
    /// Enable new service for the specified module
    /// </summary>
    public const string UseNewService = "UseNewService_{0}";

    /// <summary>
    /// Enable new validation for the specified module
    /// </summary>
    public const string UseNewValidation = "UseNewValidation_{0}";
}
