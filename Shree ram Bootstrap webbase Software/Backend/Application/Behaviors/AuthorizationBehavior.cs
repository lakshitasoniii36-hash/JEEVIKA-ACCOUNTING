namespace Application.Behaviors;

/// <summary>
/// Authorization behavior for checking permissions
/// </summary>
/// <typeparam name="TRequest">Request type</typeparam>
/// <typeparam name="TResponse">Response type</typeparam>
public class AuthorizationBehavior<TRequest, TResponse> : IBehavior<TRequest, TResponse>
{
    public async Task<TResponse> HandleAsync(TRequest request, Func<Task<TResponse>> next, CancellationToken cancellationToken = default)
    {
        // Infrastructure placeholder - will check authorization
        // Future: Check user permissions before processing
        return await next();
    }
}
