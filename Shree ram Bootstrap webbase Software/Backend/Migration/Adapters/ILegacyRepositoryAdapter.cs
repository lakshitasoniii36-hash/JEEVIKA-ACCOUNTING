namespace Migration.Adapters;

/// <summary>
/// Legacy repository adapter interface for bridging legacy repositories with new repositories
/// </summary>
public interface ILegacyRepositoryAdapter
{
    /// <summary>
    /// Gets whether to use new repository
    /// </summary>
    /// <param name="moduleName">Module name</param>
    /// <returns>True if new repository should be used</returns>
    bool UseNewRepository(string moduleName);

    /// <summary>
    /// Adapts legacy entity to new entity
    /// </summary>
    /// <typeparam name="TLegacy">Legacy entity type</typeparam>
    /// <typeparam name="TNew">New entity type</typeparam>
    /// <param name="legacyEntity">Legacy entity</param>
    /// <returns>New entity</returns>
    TNew AdaptEntity<TLegacy, TNew>(TLegacy legacyEntity) where TNew : class;

    /// <summary>
    /// Adapts new entity to legacy entity
    /// </summary>
    /// <typeparam name="TNew">New entity type</typeparam>
    /// <typeparam name="TLegacy">Legacy entity type</typeparam>
    /// <param name="newEntity">New entity</param>
    /// <returns>Legacy entity</returns>
    TLegacy AdaptEntityReverse<TNew, TLegacy>(TNew newEntity) where TLegacy : class;
}

/// <summary>
/// Default legacy repository adapter implementation
/// </summary>
public class LegacyRepositoryAdapter : ILegacyRepositoryAdapter
{
    private readonly Migration.IFeatureFlags _featureFlags;

    public LegacyRepositoryAdapter(Migration.IFeatureFlags featureFlags)
    {
        _featureFlags = featureFlags;
    }

    public bool UseNewRepository(string moduleName)
    {
        var featureFlag = string.Format(Migration.MigrationFeatureFlags.UseNewRepository, moduleName);
        return _featureFlags.IsEnabled(featureFlag);
    }

    public TNew AdaptEntity<TLegacy, TNew>(TLegacy legacyEntity) where TNew : class
    {
        // Infrastructure placeholder - will adapt legacy entity to new entity
        // Future: Implement actual adaptation logic
        return default!;
    }

    public TLegacy AdaptEntityReverse<TNew, TLegacy>(TNew newEntity) where TLegacy : class
    {
        // Infrastructure placeholder - will adapt new entity to legacy entity
        // Future: Implement actual adaptation logic
        return default!;
    }
}
