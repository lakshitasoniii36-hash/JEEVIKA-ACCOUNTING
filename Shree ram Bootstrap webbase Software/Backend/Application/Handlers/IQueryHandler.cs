using Application.Queries;

namespace Application.Handlers;

/// <summary>
/// Base interface for query handlers
/// </summary>
/// <typeparam name="TQuery">Query type</typeparam>
/// <typeparam name="TResult">Result type</typeparam>
public interface IQueryHandler<TQuery, TResult> where TQuery : IQuery<TResult>
{
    /// <summary>
    /// Handles the query
    /// </summary>
    /// <param name="query">Query to handle</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<TResult> HandleAsync(TQuery query, CancellationToken cancellationToken = default);
}
