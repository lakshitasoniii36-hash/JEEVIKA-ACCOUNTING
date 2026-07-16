namespace Migration.Adapters;

/// <summary>
/// Legacy controller adapter interface for bridging legacy controllers with new services
/// </summary>
public interface ILegacyControllerAdapter
{
    /// <summary>
    /// Gets whether to use new implementation
    /// </summary>
    /// <param name="moduleName">Module name</param>
    /// <returns>True if new implementation should be used</returns>
    bool UseNewImplementation(string moduleName);

    /// <summary>
    /// Adapts legacy controller response to new service response
    /// </summary>
    /// <typeparam name="TLegacy">Legacy response type</typeparam>
    /// <typeparam name="TNew">New response type</typeparam>
    /// <param name="legacyResponse">Legacy response</param>
    /// <returns>New response</returns>
    TNew AdaptResponse<TLegacy, TNew>(TLegacy legacyResponse) where TNew : class;

    /// <summary>
    /// Adapts new service request to legacy controller request
    /// </summary>
    /// <typeparam name="TNew">New request type</typeparam>
    /// <typeparam name="TLegacy">Legacy request type</typeparam>
    /// <param name="newRequest">New request</param>
    /// <returns>Legacy request</returns>
    TLegacy AdaptRequest<TNew, TLegacy>(TNew newRequest) where TLegacy : class;
}

/// <summary>
/// Default legacy controller adapter implementation
/// </summary>
public class LegacyControllerAdapter : ILegacyControllerAdapter
{
    private readonly Migration.IFeatureFlags _featureFlags;

    public LegacyControllerAdapter(Migration.IFeatureFlags featureFlags)
    {
        _featureFlags = featureFlags;
    }

    public bool UseNewImplementation(string moduleName)
    {
        var featureFlag = string.Format(Migration.MigrationFeatureFlags.UseNewImplementation, moduleName);
        return _featureFlags.IsEnabled(featureFlag);
    }

    public TNew AdaptResponse<TLegacy, TNew>(TLegacy legacyResponse) where TNew : class
    {
        // Infrastructure placeholder - will adapt legacy response to new response
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
