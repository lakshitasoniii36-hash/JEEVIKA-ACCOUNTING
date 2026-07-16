namespace Application.Behaviors;

/// <summary>
/// Audit behavior for logging audit trails
/// </summary>
/// <typeparam name="TRequest">Request type</typeparam>
/// <typeparam name="TResponse">Response type</typeparam>
public class AuditBehavior<TRequest, TResponse> : IBehavior<TRequest, TResponse>
{
    public async Task<TResponse> HandleAsync(TRequest request, Func<Task<TResponse>> next, CancellationToken cancellationToken = default)
    {
        // Infrastructure placeholder - will log audit trail
        // Future: Log who did what, when, and to what entity
        var response = await next();
        return response;
    }
}
