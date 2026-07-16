using Microsoft.Extensions.DependencyInjection;
using Platform.Contexts;
using Platform.Engines;
using Platform.Middleware;
using Platform.Providers;
using Platform.Validators;

namespace Platform.DependencyInjection;

/// <summary>
/// Extension methods for registering platform context services
/// </summary>
public static class PlatformServiceCollectionExtensions
{
    /// <summary>
    /// Registers platform context services
    /// </summary>
    public static IServiceCollection AddPlatformContext(this IServiceCollection services)
    {
        // Register context implementations (Singleton)
        services.AddSingleton<ICurrentUserContext, CurrentUserContext>();
        services.AddSingleton<ICompanyContext, CompanyContext>();
        services.AddSingleton<IAssessmentYearContext, AssessmentYearContext>();
        services.AddSingleton<IPermissionContext, PermissionContext>();
        services.AddSingleton<IEnvironmentContext, EnvironmentContext>();

        // Register database context (Singleton)
        services.AddSingleton<IDatabaseContext, DatabaseContext>();

        // Register engines (Singleton)
        services.AddSingleton<ICompanyEngine, CompanyEngine>();
        services.AddSingleton<IAssessmentYearEngine, AssessmentYearEngine>();

        // Register application context manager (Singleton)
        services.AddSingleton<IApplicationContextManager, ApplicationContextManager>();

        // Register context resolver (Scoped - per request)
        services.AddScoped<IContextResolver, ContextResolver>();

        // Register context validator (Scoped - per request)
        services.AddScoped<IContextValidator, ContextValidator>();

        // Register context provider (Scoped - per request)
        services.AddScoped<IContextProvider, ContextProvider>();

        return services;
    }

    /// <summary>
    /// Registers platform context services with existing application context
    /// </summary>
    public static IServiceCollection AddPlatformContextWithApplicationContext(this IServiceCollection services)
    {
        // Register context services
        services.AddPlatformContext();

        // Register global application context (Singleton)
        services.AddSingleton<IApplicationContext, ApplicationContext>();

        return services;
    }
}
