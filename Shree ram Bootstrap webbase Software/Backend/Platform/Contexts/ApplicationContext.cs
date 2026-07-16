using Infrastructure.Configuration;
using Platform.Engines;

namespace Platform.Contexts;

/// <summary>
/// Implementation of global application context
/// </summary>
public class ApplicationContext : IApplicationContext
{
    private readonly ICurrentUserContext _currentUser;
    private readonly ICompanyContext _company;
    private readonly IAssessmentYearContext _assessmentYear;
    private readonly IPermissionContext _permissions;
    private readonly IEnvironmentContext _environment;
    private readonly IPlatformConfigurationManager _configuration;
    private readonly IDatabaseContext _databaseContext;

    public ApplicationContext(
        ICurrentUserContext currentUser,
        ICompanyContext company,
        IAssessmentYearContext assessmentYear,
        IPermissionContext permissions,
        IEnvironmentContext environment,
        IPlatformConfigurationManager configuration,
        IDatabaseContext databaseContext)
    {
        _currentUser = currentUser;
        _company = company;
        _assessmentYear = assessmentYear;
        _permissions = permissions;
        _environment = environment;
        _configuration = configuration;
        _databaseContext = databaseContext;
    }

    public ICurrentUserContext CurrentUser => _currentUser;
    public ICompanyContext Company => _company;
    public IAssessmentYearContext AssessmentYear => _assessmentYear;
    public IPermissionContext Permissions => _permissions;
    public IEnvironmentContext Environment => _environment;
    public IPlatformConfigurationManager Configuration => _configuration;
    public IDatabaseContext Database => _databaseContext;

    public void Initialize()
    {
        // Initialize default environment context
        _environment.SetEnvironment(
            environmentName: "Development",
            databaseName: "ShreeRam",
            language: "en-US",
            currency: "INR",
            timezone: "Asia/Kolkata",
            branch: "Main"
        );

        // Initialize default database context
        _databaseContext.SetDatabaseAsync("ShreeRam", "", "").GetAwaiter().GetResult();
    }
}

/// <summary>
/// Implementation of current user context
/// </summary>
public class CurrentUserContext : ICurrentUserContext
{
    public string UserId { get; private set; } = string.Empty;
    public string Username { get; private set; } = string.Empty;
    public string UserType { get; private set; } = string.Empty;
    public string UserLevel { get; private set; } = string.Empty;
    public bool IsAuthenticated => !string.IsNullOrEmpty(UserId);

    public void SetUser(string userId, string username, string userType, string userLevel)
    {
        UserId = userId;
        Username = username;
        UserType = userType;
        UserLevel = userLevel;
    }

    public void Clear()
    {
        UserId = string.Empty;
        Username = string.Empty;
        UserType = string.Empty;
        UserLevel = string.Empty;
    }
}

/// <summary>
/// Implementation of company context
/// </summary>
public class CompanyContext : ICompanyContext
{
    public string CompanyId { get; private set; } = string.Empty;
    public string CompanyCode { get; private set; } = string.Empty;
    public string CompanyName { get; private set; } = string.Empty;
    public bool HasCompany => !string.IsNullOrEmpty(CompanyId);

    public void SetCompany(string companyId, string companyCode, string companyName)
    {
        CompanyId = companyId;
        CompanyCode = companyCode;
        CompanyName = companyName;
    }

    public void Clear()
    {
        CompanyId = string.Empty;
        CompanyCode = string.Empty;
        CompanyName = string.Empty;
    }
}

/// <summary>
/// Implementation of assessment year context
/// </summary>
public class AssessmentYearContext : IAssessmentYearContext
{
    public string YearId { get; private set; } = string.Empty;
    public string Year { get; private set; } = string.Empty;
    public DateTime YearStart { get; private set; }
    public DateTime YearEnd { get; private set; }
    public bool HasYear => !string.IsNullOrEmpty(YearId);

    public void SetAssessmentYear(string yearId, string year, DateTime yearStart, DateTime yearEnd)
    {
        YearId = yearId;
        Year = year;
        YearStart = yearStart;
        YearEnd = yearEnd;
    }

    public void Clear()
    {
        YearId = string.Empty;
        Year = string.Empty;
        YearStart = DateTime.MinValue;
        YearEnd = DateTime.MinValue;
    }
}

/// <summary>
/// Implementation of permission context
/// </summary>
public class PermissionContext : IPermissionContext
{
    private readonly List<string> _roles = new();
    private readonly List<string> _permissions = new();

    public IEnumerable<string> Roles => _roles.AsReadOnly();
    public IEnumerable<string> Permissions => _permissions.AsReadOnly();

    public bool HasPermission(string permissionCode)
    {
        return _permissions.Contains(permissionCode);
    }

    public bool HasAnyPermission(params string[] permissionCodes)
    {
        return permissionCodes.Any(code => _permissions.Contains(code));
    }

    public void SetPermissions(IEnumerable<string> roles, IEnumerable<string> permissions)
    {
        _roles.Clear();
        _permissions.Clear();
        _roles.AddRange(roles);
        _permissions.AddRange(permissions);
    }

    public void Clear()
    {
        _roles.Clear();
        _permissions.Clear();
    }
}

/// <summary>
/// Implementation of environment context
/// </summary>
public class EnvironmentContext : IEnvironmentContext
{
    public string EnvironmentName { get; private set; } = "Development";
    public string DatabaseName { get; private set; } = string.Empty;
    public string Language { get; private set; } = "en-US";
    public string Currency { get; private set; } = "INR";
    public string Timezone { get; private set; } = "Asia/Kolkata";
    public string Branch { get; private set; } = "Main";

    public void SetEnvironment(string environmentName, string databaseName, string language, string currency, string timezone, string branch)
    {
        EnvironmentName = environmentName;
        DatabaseName = databaseName;
        Language = language;
        Currency = currency;
        Timezone = timezone;
        Branch = branch;
    }
}
