namespace Application;

/// <summary>
/// Base interface for all application services
/// </summary>
public interface IApplicationService
{
    /// <summary>
    /// Gets the service name for logging and identification
    /// </summary>
    string ServiceName { get; }
}
