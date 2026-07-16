namespace Application.Behaviors;

/// <summary>
/// Base interface for pipeline behaviors
/// </summary>
/// <typeparam name="TRequest">Request type</typeparam>
/// <typeparam name="TResponse">Response type</typeparam>
public interface IBehavior<TRequest, TResponse>
{
    /// <summary>
    /// Processes the request through the behavior pipeline
    /// </summary>
    /// <param name="request">Request to process</param>
    /// <param name="next">Next behavior in pipeline</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<TResponse> HandleAsync(TRequest request, Func<Task<TResponse>> next, CancellationToken cancellationToken = default);
}
