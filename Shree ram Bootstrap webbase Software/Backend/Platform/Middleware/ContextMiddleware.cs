using Microsoft.AspNetCore.Http;
using Platform.Engines;
using Platform.Providers;
using Platform.Validators;

namespace Platform.Middleware;

/// <summary>
/// Middleware for automatic context resolution and validation
/// </summary>
public class ContextMiddleware
{
    private readonly RequestDelegate _next;
    private readonly IContextResolver _contextResolver;
    private readonly IContextValidator _contextValidator;
    private readonly IApplicationContextManager _contextManager;

    public ContextMiddleware(
        RequestDelegate next,
        IContextResolver contextResolver,
        IContextValidator contextValidator,
        IApplicationContextManager contextManager)
    {
        _next = next;
        _contextResolver = contextResolver;
        _contextValidator = contextValidator;
        _contextManager = contextManager;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        // Resolve context from HTTP request
        await ResolveContextAsync(context);

        // Validate context
        var validationResult = await _contextValidator.ValidateAllContextsAsync();
        if (validationResult.IsFailure)
        {
            // Context validation failed - return error response
            context.Response.StatusCode = 400;
            await context.Response.WriteAsJsonAsync(new
            {
                success = false,
                message = "Context validation failed",
                errors = validationResult.Errors
            });
            return;
        }

        // Continue to next middleware
        await _next(context);
    }

    private async Task ResolveContextAsync(HttpContext context)
    {
        // Resolve user context
        var userContext = await _contextResolver.ResolveUserContextAsync(context);
        if (userContext != null)
        {
            _contextManager.UserContext.SetUser(
                userContext.UserId,
                userContext.Username,
                userContext.UserType,
                userContext.UserLevel
            );
        }

        // Resolve company context
        var companyContext = await _contextResolver.ResolveCompanyContextAsync(context);
        if (companyContext != null)
        {
            _contextManager.CompanyContext.SetCompany(
                companyContext.CompanyId,
                companyContext.CompanyCode,
                companyContext.CompanyName
            );
        }

        // Resolve assessment year context
        var yearContext = await _contextResolver.ResolveAssessmentYearContextAsync(context);
        if (yearContext != null)
        {
            _contextManager.AssessmentYearContext.SetAssessmentYear(
                yearContext.YearId,
                yearContext.Year,
                yearContext.YearStart,
                yearContext.YearEnd
            );
        }

        // Resolve branch context
        var branchContext = await _contextResolver.ResolveBranchContextAsync(context);
        if (branchContext != null)
        {
            // Update environment context with branch
            var currentEnv = _contextManager.EnvironmentContext;
            currentEnv.SetEnvironment(
                currentEnv.EnvironmentName,
                currentEnv.DatabaseName,
                currentEnv.Language,
                currentEnv.Currency,
                currentEnv.Timezone,
                branchContext.BranchName
            );
        }

        // Resolve language
        var language = await _contextResolver.ResolveLanguageAsync(context);
        // Update environment context with language

        // Resolve currency
        var currency = await _contextResolver.ResolveCurrencyAsync(context);
        // Update environment context with currency

        // Resolve timezone
        var timezone = await _contextResolver.ResolveTimezoneAsync(context);
        // Update environment context with timezone

        await Task.CompletedTask;
    }
}

/// <summary>
/// Extension method to register context middleware
/// </summary>
public static class ContextMiddlewareExtensions
{
    public static IApplicationBuilder UseContext(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<ContextMiddleware>();
    }
}
