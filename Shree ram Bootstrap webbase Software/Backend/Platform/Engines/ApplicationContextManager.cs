using Platform.Contexts;

namespace Platform.Engines;

/// <summary>
/// Application Context Manager implementation for centralized context management
/// </summary>
public class ApplicationContextManager : IApplicationContextManager
{
    private readonly ICurrentUserContext _userContext;
    private readonly ICompanyContext _companyContext;
    private readonly IAssessmentYearContext _assessmentYearContext;
    private readonly IPermissionContext _permissionContext;
    private readonly IEnvironmentContext _environmentContext;
    private readonly IDatabaseContext _databaseContext;

    public ApplicationContextManager(
        ICurrentUserContext userContext,
        ICompanyContext companyContext,
        IAssessmentYearContext assessmentYearContext,
        IPermissionContext permissionContext,
        IEnvironmentContext environmentContext,
        IDatabaseContext databaseContext)
    {
        _userContext = userContext;
        _companyContext = companyContext;
        _assessmentYearContext = assessmentYearContext;
        _permissionContext = permissionContext;
        _environmentContext = environmentContext;
        _databaseContext = databaseContext;
    }

    public ICurrentUserContext UserContext => _userContext;
    public ICompanyContext CompanyContext => _companyContext;
    public IAssessmentYearContext AssessmentYearContext => _assessmentYearContext;
    public IPermissionContext PermissionContext => _permissionContext;
    public IEnvironmentContext EnvironmentContext => _environmentContext;
    public IDatabaseContext DatabaseContext => _databaseContext;

    public async Task InitializeAsync()
    {
        // Initialize environment context with defaults
        _environmentContext.SetEnvironment(
            environmentName: "Development",
            databaseName: "ShreeRam",
            language: "en-US",
            currency: "INR",
            timezone: "Asia/Kolkata",
            branch: "Main"
        );

        // Initialize database context with default
        await _databaseContext.SetDatabaseAsync(
            databaseName: "ShreeRam",
            databasePath: "",
            connectionString: ""
        );

        await Task.CompletedTask;
    }

    public async Task<bool> ValidateContextsAsync()
    {
        // Basic validation - infrastructure only, no business logic
        // Future: Add validation for company existence, year existence, etc.
        return await Task.FromResult(true);
    }

    public async Task<ContextSnapshot> GetContextSnapshotAsync()
    {
        return await Task.FromResult(new ContextSnapshot
        {
            UserId = _userContext.UserId,
            Username = _userContext.Username,
            UserType = _userContext.UserType,
            UserLevel = _userContext.UserLevel,
            CompanyId = _companyContext.CompanyId,
            CompanyCode = _companyContext.CompanyCode,
            CompanyName = _companyContext.CompanyName,
            YearId = _assessmentYearContext.YearId,
            Year = _assessmentYearContext.Year,
            YearStart = _assessmentYearContext.YearStart,
            YearEnd = _assessmentYearContext.YearEnd,
            Roles = _permissionContext.Roles.ToList(),
            Permissions = _permissionContext.Permissions.ToList(),
            EnvironmentName = _environmentContext.EnvironmentName,
            DatabaseName = _environmentContext.DatabaseName,
            Language = _environmentContext.Language,
            Currency = _environmentContext.Currency,
            Timezone = _environmentContext.Timezone,
            Branch = _environmentContext.Branch
        });
    }

    public async Task SetContextFromSnapshotAsync(ContextSnapshot snapshot)
    {
        // Set user context
        if (!string.IsNullOrEmpty(snapshot.UserId))
        {
            _userContext.SetUser(
                snapshot.UserId,
                snapshot.Username ?? string.Empty,
                snapshot.UserType ?? string.Empty,
                snapshot.UserLevel ?? string.Empty
            );
        }

        // Set company context
        if (!string.IsNullOrEmpty(snapshot.CompanyId))
        {
            _companyContext.SetCompany(
                snapshot.CompanyId,
                snapshot.CompanyCode ?? string.Empty,
                snapshot.CompanyName ?? string.Empty
            );
        }

        // Set assessment year context
        if (!string.IsNullOrEmpty(snapshot.YearId) && snapshot.YearStart.HasValue && snapshot.YearEnd.HasValue)
        {
            _assessmentYearContext.SetAssessmentYear(
                snapshot.YearId,
                snapshot.Year,
                snapshot.YearStart.Value,
                snapshot.YearEnd.Value
            );
        }

        // Set permission context
        _permissionContext.SetPermissions(snapshot.Roles, snapshot.Permissions);

        // Set environment context
        _environmentContext.SetEnvironment(
            snapshot.EnvironmentName ?? "Development",
            snapshot.DatabaseName ?? string.Empty,
            snapshot.Language ?? "en-US",
            snapshot.Currency ?? "INR",
            snapshot.Timezone ?? "Asia/Kolkata",
            snapshot.Branch ?? "Main"
        );

        // Set database context
        if (!string.IsNullOrEmpty(snapshot.DatabaseName))
        {
            await _databaseContext.SetDatabaseAsync(
                snapshot.DatabaseName,
                string.Empty,
                string.Empty
            );
        }

        await Task.CompletedTask;
    }

    public async Task ClearAllContextsAsync()
    {
        _userContext.Clear();
        _companyContext.Clear();
        _assessmentYearContext.Clear();
        _permissionContext.Clear();
        await _databaseContext.ClearDatabaseAsync();
        await Task.CompletedTask;
    }
}
