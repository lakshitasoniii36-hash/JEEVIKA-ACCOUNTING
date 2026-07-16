using Microsoft.AspNetCore.Http;

namespace Platform.Providers;

/// <summary>
/// Context Resolver interface for resolving context from HTTP requests
/// </summary>
public interface IContextResolver
{
    /// <summary>
    /// Resolves user context from HTTP request
    /// </summary>
    /// <param name="context">HTTP context</param>
    /// <returns>User context information or null if not found</returns>
    Task<UserContextInfo?> ResolveUserContextAsync(HttpContext context);

    /// <summary>
    /// Resolves company context from HTTP request
    /// </summary>
    /// <param name="context">HTTP context</param>
    /// <returns>Company context information or null if not found</returns>
    Task<CompanyContextInfo?> ResolveCompanyContextAsync(HttpContext context);

    /// <summary>
    /// Resolves assessment year context from HTTP request
    /// </summary>
    /// <param name="context">HTTP context</param>
    /// <returns>Assessment year context information or null if not found</returns>
    Task<AssessmentYearContextInfo?> ResolveAssessmentYearContextAsync(HttpContext context);

    /// <summary>
    /// Resolves branch context from HTTP request
    /// </summary>
    /// <param name="context">HTTP context</param>
    /// <returns>Branch context information or null if not found</returns>
    Task<BranchContextInfo?> ResolveBranchContextAsync(HttpContext context);

    /// <summary>
    /// Resolves language context from HTTP request
    /// </summary>
    /// <param name="context">HTTP context</param>
    /// <returns>Language code or default if not found</returns>
    Task<string> ResolveLanguageAsync(HttpContext context);

    /// <summary>
    /// Resolves currency context from HTTP request
    /// </summary>
    /// <param name="context">HTTP context</param>
    /// <returns>Currency code or default if not found</returns>
    Task<string> ResolveCurrencyAsync(HttpContext context);

    /// <summary>
    /// Resolves timezone context from HTTP request
    /// </summary>
    /// <param name="context">HTTP context</param>
    /// <returns>Timezone or default if not found</returns>
    Task<string> ResolveTimezoneAsync(HttpContext context);
}

/// <summary>
/// User context information
/// </summary>
public class UserContextInfo
{
    public string UserId { get; set; } = string.Empty;
    public string Username { get; set; } = string.Empty;
    public string UserType { get; set; } = string.Empty;
    public string UserLevel { get; set; } = string.Empty;
}

/// <summary>
/// Company context information
/// </summary>
public class CompanyContextInfo
{
    public string CompanyId { get; set; } = string.Empty;
    public string CompanyCode { get; set; } = string.Empty;
    public string CompanyName { get; set; } = string.Empty;
}

/// <summary>
/// Assessment year context information
/// </summary>
public class AssessmentYearContextInfo
{
    public string YearId { get; set; } = string.Empty;
    public string Year { get; set; } = string.Empty;
    public DateTime YearStart { get; set; }
    public DateTime YearEnd { get; set; }
}

/// <summary>
/// Branch context information
/// </summary>
public class BranchContextInfo
{
    public string BranchId { get; set; } = string.Empty;
    public string BranchName { get; set; } = string.Empty;
    public string BranchCode { get; set; } = string.Empty;
}
