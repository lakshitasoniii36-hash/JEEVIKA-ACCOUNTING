namespace Migration.Adapters;

/// <summary>
/// Legacy service adapter interface for bridging legacy services with new services
/// </summary>
public interface ILegacyServiceAdapter
{
    /// <summary>
    /// Gets whether to use new service
    /// </summary>
    /// <param name="moduleName">Module name</param>
    /// <returns>True if new service should be used</returns>
    bool UseNewService(string moduleName);

    /// <summary>
    /// Adapts legacy service result to new service result
    /// </summary>
    /// <typeparam name="TLegacy">Legacy result type</typeparam>
    /// <typeparam name="TNew">New result type</typeparam>
    /// <param name="legacyResult">Legacy result</param>
    /// <returns>New result</returns>
    TNew AdaptResult<TLegacy, TNew>(TLegacy legacyResult) where TNew : class;

    /// <summary>
    /// Adapts new service request to legacy service request
    /// </summary>
    /// <typeparam name="TNew">New request type</typeparam>
    /// <typeparam name="TLegacy">Legacy request type</typeparam>
    /// <param name="newRequest">New request</param>
    /// <returns>Legacy request</returns>
    TLegacy AdaptRequest<TNew, TLegacy>(TNew newRequest) where TLegacy : class;
}

/// <summary>
/// Default legacy service adapter implementation
/// </summary>
public class LegacyServiceAdapter : ILegacyServiceAdapter
{
    private readonly Migration.IFeatureFlags _featureFlags;

    public LegacyServiceAdapter(Migration.IFeatureFlags featureFlags)
    {
        _featureFlags = featureFlags;
    }

    public bool UseNewService(string moduleName)
    {
        var featureFlag = string.Format(Migration.MigrationFeatureFlags.UseNewService, moduleName);
        return _featureFlags.IsEnabled(featureFlag);
    }

    public TNew AdaptResult<TLegacy, TNew>(TLegacy legacyResult) where TNew : class
    {
        // Infrastructure placeholder - will adapt legacy result to new result
        // Future: Implement actual adaptation logic
        return default!;
    }

    public TLegacy AdaptRequest<TNew, TLegacy>(TNew newRequest) where TLegacy : class
    {
        // Infrastructure placeholder - will adapt new request to legacy request
        // Future: Implement actual adaptation logic
        return default!;
    }
}
