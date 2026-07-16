namespace Application.Queries;

/// <summary>
/// Base interface for queries (read operations)
/// </summary>
public interface IQuery
{
    /// <summary>
    /// Gets the query ID for tracking
    /// </summary>
    string QueryId { get; }
}

/// <summary>
/// Query interface with return value
/// </summary>
/// <typeparam name="TResult">Result type</typeparam>
public interface IQuery<TResult> : IQuery
{
}
