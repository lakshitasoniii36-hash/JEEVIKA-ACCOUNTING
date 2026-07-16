namespace Application.Behaviors;

/// <summary>
/// Logging behavior for logging request/response
/// </summary>
/// <typeparam name="TRequest">Request type</typeparam>
/// <typeparam name="TResponse">Response type</typeparam>
public class LoggingBehavior<TRequest, TResponse> : IBehavior<TRequest, TResponse>
{
    public async Task<TResponse> HandleAsync(TRequest request, Func<Task<TResponse>> next, CancellationToken cancellationToken = default)
    {
        // Infrastructure placeholder - will log request
        // Future: Log request details before processing
        var response = await next();
        // Future: Log response details after processing
        return response;
    }
}
