using Microsoft.AspNetCore.Http;

namespace Platform.Providers;

/// <summary>
/// Context Resolver implementation for resolving context from HTTP requests
/// </summary>
public class ContextResolver : IContextResolver
{
    public Task<UserContextInfo?> ResolveUserContextAsync(HttpContext context)
    {
        // Infrastructure placeholder - will resolve from headers, cookies, or JWT
        // For now, returns null to support architecture without business logic
        return Task.FromResult<UserContextInfo?>(null);
    }

    public Task<CompanyContextInfo?> ResolveCompanyContextAsync(HttpContext context)
    {
        // Infrastructure placeholder - will resolve from headers, cookies, or session
        // For now, returns null to support architecture without business logic
        return Task.FromResult<CompanyContextInfo?>(null);
    }

    public Task<AssessmentYearContextInfo?> ResolveAssessmentYearContextAsync(HttpContext context)
    {
        // Infrastructure placeholder - will resolve from headers, cookies, or session
        // For now, returns null to support architecture without business logic
        return Task.FromResult<AssessmentYearContextInfo?>(null);
    }

    public Task<BranchContextInfo?> ResolveBranchContextAsync(HttpContext context)
    {
        // Infrastructure placeholder - will resolve from headers, cookies, or session
        // For now, returns null to support architecture without business logic
        return Task.FromResult<BranchContextInfo?>(null);
    }

    public Task<string> ResolveLanguageAsync(HttpContext context)
    {
        // Infrastructure placeholder - will resolve from Accept-Language header or cookie
        // For now, returns default to support architecture without business logic
        return Task.FromResult("en-US");
    }

    public Task<string> ResolveCurrencyAsync(HttpContext context)
    {
        // Infrastructure placeholder - will resolve from header, cookie, or company settings
        // For now, returns default to support architecture without business logic
        return Task.FromResult("INR");
    }

    public Task<string> ResolveTimezoneAsync(HttpContext context)
    {
        // Infrastructure placeholder - will resolve from header, cookie, or user settings
        // For now, returns default to support architecture without business logic
        return Task.FromResult("Asia/Kolkata");
    }
}
