namespace Application.Behaviors;

/// <summary>
/// Validation behavior for validating requests
/// </summary>
/// <typeparam name="TRequest">Request type</typeparam>
/// <typeparam name="TResponse">Response type</typeparam>
public class ValidationBehavior<TRequest, TResponse> : IBehavior<TRequest, TResponse>
{
    public async Task<TResponse> HandleAsync(TRequest request, Func<Task<TResponse>> next, CancellationToken cancellationToken = default)
    {
        // Infrastructure placeholder - will validate request
        // Future: Use validation framework to validate request
        return await next();
    }
}
