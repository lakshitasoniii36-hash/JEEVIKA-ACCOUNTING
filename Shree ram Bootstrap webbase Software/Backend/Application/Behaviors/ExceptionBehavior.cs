namespace Application.Behaviors;

/// <summary>
/// Exception behavior for handling exceptions
/// </summary>
/// <typeparam name="TRequest">Request type</typeparam>
/// <typeparam name="TResponse">Response type</typeparam>
public class ExceptionBehavior<TRequest, TResponse> : IBehavior<TRequest, TResponse>
{
    public async Task<TResponse> HandleAsync(TRequest request, Func<Task<TResponse>> next, CancellationToken cancellationToken = default)
    {
        try
        {
            return await next();
        }
        catch (Exception ex)
        {
            // Infrastructure placeholder - will handle exceptions
            // Future: Log exception, convert to appropriate error response
            throw;
        }
    }
}
