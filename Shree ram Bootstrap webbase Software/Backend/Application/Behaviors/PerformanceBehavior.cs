namespace Application.Behaviors;

/// <summary>
/// Performance behavior for measuring execution time
/// </summary>
/// <typeparam name="TRequest">Request type</typeparam>
/// <typeparam name="TResponse">Response type</typeparam>
public class PerformanceBehavior<TRequest, TResponse> : IBehavior<TRequest, TResponse>
{
    public async Task<TResponse> HandleAsync(TRequest request, Func<Task<TResponse>> next, CancellationToken cancellationToken = default)
    {
        var stopwatch = System.Diagnostics.Stopwatch.StartNew();
        
        try
        {
            var response = await next();
            stopwatch.Stop();
            
            // Infrastructure placeholder - will log performance metrics
            // Future: Log execution time, memory usage, etc.
            
            return response;
        }
        catch
        {
            stopwatch.Stop();
            throw;
        }
    }
}
