namespace Migration.Compatibility;

/// <summary>
/// Compatibility layer interface for ensuring old and new architectures coexist safely
/// </summary>
public interface ICompatibilityLayer
{
    /// <summary>
    /// Checks if the module is compatible with both architectures
    /// </summary>
    /// <param name="moduleName">Module name</param>
    /// <returns>True if module is compatible</returns>
    bool IsCompatible(string moduleName);

    /// <summary>
    /// Validates that both legacy and new implementations produce the same result
    /// </summary>
    /// <typeparam name="T">Result type</typeparam>
    /// <param name="moduleName">Module name</param>
    /// <param name="legacyResult">Legacy implementation result</param>
    /// <param name="newResult">New implementation result</param>
    /// <returns>True if results are compatible</returns>
    bool ValidateCompatibility<T>(string moduleName, T legacyResult, T newResult);

    /// <summary>
    /// Gets compatibility issues for a module
    /// </summary>
    /// <param name="moduleName">Module name</param>
    /// <returns>Compatibility issues</returns>
    IEnumerable<string> GetCompatibilityIssues(string moduleName);
}

/// <summary>
/// Default compatibility layer implementation
/// </summary>
public class CompatibilityLayer : ICompatibilityLayer
{
    public bool IsCompatible(string moduleName)
    {
        // Infrastructure placeholder - will check module compatibility
        // Future: Implement actual compatibility check logic
        return true;
    }

    public bool ValidateCompatibility<T>(string moduleName, T legacyResult, T newResult)
    {
        // Infrastructure placeholder - will validate result compatibility
        // Future: Implement actual validation logic
        return true;
    }

    public IEnumerable<string> GetCompatibilityIssues(string moduleName)
    {
        // Infrastructure placeholder - will return compatibility issues
        // Future: Implement actual issue detection logic
        return Enumerable.Empty<string>();
    }
}
