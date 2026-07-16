using Platform.Contexts;
using Platform.Engines;

namespace Infrastructure.Repositories;

/// <summary>
/// Repository context interface for automatic context injection
/// </summary>
public interface IRepositoryContext
{
    /// <summary>
    /// Gets the current user context
    /// </summary>
    ICurrentUserContext UserContext { get; }

    /// <summary>
    /// Gets the current company context
    /// </summary>
    ICompanyContext CompanyContext { get; }

    /// <summary>
    /// Gets the current assessment year context
    /// </summary>
    IAssessmentYearContext AssessmentYearContext { get; }

    /// <summary>
    /// Gets the current database context
    /// </summary>
    IDatabaseContext DatabaseContext { get; }

    /// <summary>
    /// Gets the current environment context
    /// </summary>
    IEnvironmentContext EnvironmentContext { get; }

    /// <summary>
    /// Gets the current company ID
    /// </summary>
    string? CurrentCompanyId { get; }

    /// <summary>
    /// Gets the current assessment year ID
    /// </summary>
    string? CurrentYearId { get; }

    /// <summary>
    /// Gets the current user ID
    /// </summary>
    string? CurrentUserId { get; }

    /// <summary>
    /// Gets the current branch
    /// </summary>
    string? CurrentBranch { get; }
}

/// <summary>
/// Repository context implementation with automatic context injection
/// </summary>
public class RepositoryContext : IRepositoryContext
{
    private readonly IApplicationContextManager _contextManager;

    public RepositoryContext(IApplicationContextManager contextManager)
    {
        _contextManager = contextManager;
    }

    public ICurrentUserContext UserContext => _contextManager.UserContext;
    public ICompanyContext CompanyContext => _contextManager.CompanyContext;
    public IAssessmentYearContext AssessmentYearContext => _contextManager.AssessmentYearContext;
    public IDatabaseContext DatabaseContext => _contextManager.DatabaseContext;
    public IEnvironmentContext EnvironmentContext => _contextManager.EnvironmentContext;

    public string? CurrentCompanyId => _contextManager.CompanyContext.CompanyId;
    public string? CurrentYearId => _contextManager.AssessmentYearContext.YearId;
    public string? CurrentUserId => _contextManager.UserContext.UserId;
    public string? CurrentBranch => _contextManager.EnvironmentContext.Branch;
}
