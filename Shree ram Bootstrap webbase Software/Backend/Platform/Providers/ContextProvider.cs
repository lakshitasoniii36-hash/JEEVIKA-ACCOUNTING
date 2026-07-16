using Platform.Contexts;
using Platform.Engines;

namespace Platform.Providers;

/// <summary>
/// Context Provider implementation for providing context to controllers and services
/// </summary>
public class ContextProvider : IContextProvider
{
    private readonly IApplicationContextManager _contextManager;

    public ContextProvider(IApplicationContextManager contextManager)
    {
        _contextManager = contextManager;
    }

    public string? CurrentUserId => _contextManager.UserContext.UserId;
    public string? CurrentUsername => _contextManager.UserContext.Username;
    public string? CurrentUserType => _contextManager.UserContext.UserType;
    public string? CurrentUserLevel => _contextManager.UserContext.UserLevel;
    public string? CurrentCompanyId => _contextManager.CompanyContext.CompanyId;
    public string? CurrentCompanyCode => _contextManager.CompanyContext.CompanyCode;
    public string? CurrentCompanyName => _contextManager.CompanyContext.CompanyName;
    public string? CurrentYearId => _contextManager.AssessmentYearContext.YearId;
    public string? CurrentYear => _contextManager.AssessmentYearContext.Year;
    public DateTime? CurrentYearStart => _contextManager.AssessmentYearContext.YearStart;
    public DateTime? CurrentYearEnd => _contextManager.AssessmentYearContext.YearEnd;
    public string? CurrentBranch => _contextManager.EnvironmentContext.Branch;
    public string CurrentLanguage => _contextManager.EnvironmentContext.Language;
    public string CurrentCurrency => _contextManager.EnvironmentContext.Currency;
    public string CurrentTimezone => _contextManager.EnvironmentContext.Timezone;
    public string? CurrentDatabaseName => _contextManager.DatabaseContext.DatabaseName;
    public IEnumerable<string> CurrentRoles => _contextManager.PermissionContext.Roles;
    public IEnumerable<string> CurrentPermissions => _contextManager.PermissionContext.Permissions;

    public bool HasPermission(string permissionCode)
    {
        return _contextManager.PermissionContext.HasPermission(permissionCode);
    }

    public bool HasAnyPermission(params string[] permissionCodes)
    {
        return _contextManager.PermissionContext.HasAnyPermission(permissionCodes);
    }

    public bool HasAllPermissions(params string[] permissionCodes)
    {
        return permissionCodes.All(HasPermission);
    }
}
