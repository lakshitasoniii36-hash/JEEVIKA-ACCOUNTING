namespace Core.Utilities;

/// <summary>
/// Guard clauses for parameter validation
/// </summary>
public static class Guard
{
    /// <summary>
    /// Throws if value is null
    /// </summary>
    public static T NotNull<T>(T? value, string paramName) where T : class
    {
        if (value is null)
            throw new ArgumentNullException(paramName);
        return value;
    }

    /// <summary>
    /// Throws if string is null or whitespace
    /// </summary>
    public static string NotNullOrWhiteSpace(string? value, string paramName)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException($"{paramName} cannot be null or whitespace", paramName);
        return value;
    }

    /// <summary>
    /// Throws if value is null or empty
    /// </summary>
    public static string NotNullOrEmpty(string? value, string paramName)
    {
        if (string.IsNullOrEmpty(value))
            throw new ArgumentException($"{paramName} cannot be null or empty", paramName);
        return value;
    }

    /// <summary>
    /// Throws if value is less than minimum
    /// </summary>
    public static int GreaterThan(int value, int minimum, string paramName)
    {
        if (value <= minimum)
            throw new ArgumentException($"{paramName} must be greater than {minimum}", paramName);
        return value;
    }

    /// <summary>
    /// Throws if value is less than or equal to zero
    /// </summary>
    public static int Positive(int value, string paramName)
    {
        if (value <= 0)
            throw new ArgumentException($"{paramName} must be positive", paramName);
        return value;
    }

    /// <summary>
    /// Throws if value is less than or equal to zero
    /// </summary>
    public static decimal Positive(decimal value, string paramName)
    {
        if (value <= 0)
            throw new ArgumentException($"{paramName} must be positive", paramName);
        return value;
    }

    /// <summary>
    /// Throws if collection is null or empty
    /// </summary>
    public static IEnumerable<T> NotNullOrEmpty<T>(IEnumerable<T>? value, string paramName)
    {
        if (value is null || !value.Any())
            throw new ArgumentException($"{paramName} cannot be null or empty", paramName);
        return value;
    }
}
