namespace Application.Mappings;

/// <summary>
/// Interface for object mapping
/// </summary>
public interface IMapper
{
    /// <summary>
    /// Maps source to destination
    /// </summary>
    /// <typeparam name="TSource">Source type</typeparam>
    /// <typeparam name="TDestination">Destination type</typeparam>
    /// <param name="source">Source object</param>
    /// <returns>Mapped destination object</returns>
    TDestination Map<TSource, TDestination>(TSource source) where TDestination : class;

    /// <summary>
    /// Maps source collection to destination collection
    /// </summary>
    /// <typeparam name="TSource">Source type</typeparam>
    /// <typeparam name="TDestination">Destination type</typeparam>
    /// <param name="source">Source collection</param>
    /// <returns>Mapped destination collection</returns>
    IEnumerable<TDestination> MapCollection<TSource, TDestination>(IEnumerable<TSource> source) where TDestination : class;
}

/// <summary>
/// Default mapper implementation (placeholder)
/// </summary>
public class DefaultMapper : IMapper
{
    public TDestination Map<TSource, TDestination>(TSource source) where TDestination : class
    {
        // Infrastructure placeholder - will use AutoMapper or similar
        // Future: Implement actual mapping logic
        return default!;
    }

    public IEnumerable<TDestination> MapCollection<TSource, TDestination>(IEnumerable<TSource> source) where TDestination : class
    {
        // Infrastructure placeholder - will use AutoMapper or similar
        // Future: Implement actual collection mapping logic
        return default!;
    }
}
