using Infrastructure.Configuration;
using Platform.Engines;

namespace Platform.Contexts;

/// <summary>
/// Global application context holding all contextual information
/// </summary>
public interface IApplicationContext
{
    /// <summary>
    /// Current user context
    /// </summary>
    ICurrentUserContext CurrentUser { get; }

    /// <summary>
    /// Current company context
    /// </summary>
    ICompanyContext Company { get; }

    /// <summary>
    /// Current assessment year context
    /// </summary>
    IAssessmentYearContext AssessmentYear { get; }

    /// <summary>
    /// Current permission context
    /// </summary>
    IPermissionContext Permissions { get; }

    /// <summary>
    /// Environment context
    /// </summary>
    IEnvironmentContext Environment { get; }

    /// <summary>
    /// Configuration manager
    /// </summary>
    IPlatformConfigurationManager Configuration { get; }

    /// <summary>
    /// Database context
    /// </summary>
    IDatabaseContext Database { get; }

    /// <summary>
    /// Initializes the application context
    /// </summary>
    void Initialize();
}
