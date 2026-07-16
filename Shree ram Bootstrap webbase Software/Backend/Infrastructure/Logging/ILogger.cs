namespace Infrastructure.Logging;

/// <summary>
/// Interface for logging operations
/// </summary>
public interface IPlatformLogger
{
    /// <summary>
    /// Logs a debug message
    /// </summary>
    void LogDebug(string message, params object[] args);

    /// <summary>
    /// Logs an information message
    /// </summary>
    void LogInfo(string message, params object[] args);

    /// <summary>
    /// Logs a warning message
    /// </summary>
    void LogWarning(string message, params object[] args);

    /// <summary>
    /// Logs an error message
    /// </summary>
    void LogError(string message, params object[] args);

    /// <summary>
    /// Logs an error message with exception
    /// </summary>
    void LogError(Exception exception, string message, params object[] args);

    /// <summary>
    /// Logs a critical error message
    /// </summary>
    void LogCritical(string message, params object[] args);
}
