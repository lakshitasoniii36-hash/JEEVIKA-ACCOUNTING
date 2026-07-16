namespace Core.Helpers;

/// <summary>
/// Helper methods for string operations
/// </summary>
public static class StringHelper
{
    /// <summary>
    /// Trims and normalizes whitespace in a string
    /// </summary>
    public static string TrimAndNormalize(string? value)
    {
        if (string.IsNullOrWhiteSpace(value))
            return string.Empty;
        
        return System.Text.RegularExpressions.Regex.Replace(value.Trim(), @"\s+", " ");
    }

    /// <summary>
    /// Converts string to uppercase for comparison
    /// </summary>
    public static string ToUpperInvariant(string? value)
    {
        return value?.ToUpperInvariant() ?? string.Empty;
    }

    /// <summary>
    /// Checks if two strings are equal ignoring case and whitespace
    /// </summary>
    public static bool EqualsIgnoreCase(string? a, string? b)
    {
        return string.Equals(
            TrimAndNormalize(a),
            TrimAndNormalize(b),
            StringComparison.OrdinalIgnoreCase
        );
    }

    /// <summary>
    /// Generates a unique identifier string
    /// </summary>
    public static string GenerateUniqueId()
    {
        return Guid.NewGuid().ToString("N");
    }

    /// <summary>
    /// Truncates a string to a maximum length
    /// </summary>
    public static string Truncate(string? value, int maxLength)
    {
        if (string.IsNullOrEmpty(value))
            return string.Empty;
        
        return value.Length <= maxLength ? value : value.Substring(0, maxLength);
    }
}
