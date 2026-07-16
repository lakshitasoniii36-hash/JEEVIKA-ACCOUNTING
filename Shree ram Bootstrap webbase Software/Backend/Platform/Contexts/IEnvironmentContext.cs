namespace Platform.Contexts;

/// <summary>
/// Environment context information
/// </summary>
public interface IEnvironmentContext
{
    /// <summary>
    /// Environment name (Development, Staging, Production)
    /// </summary>
    string EnvironmentName { get; }

    /// <summary>
    /// Database name
    /// </summary>
    string DatabaseName { get; }

    /// <summary>
    /// Language code
    /// </summary>
    string Language { get; }

    /// <summary>
    /// Currency code
    /// </summary>
    string Currency { get; }

    /// <summary>
    /// Timezone
    /// </summary>
    string Timezone { get; }

    /// <summary>
    /// Branch identifier
    /// </summary>
    string Branch { get; }

    /// <summary>
    /// Sets environment context
    /// </summary>
    void SetEnvironment(string environmentName, string databaseName, string language, string currency, string timezone, string branch);
}
