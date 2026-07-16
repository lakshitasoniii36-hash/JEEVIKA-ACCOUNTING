namespace Application.Queries;

/// <summary>
/// Base class for queries
/// </summary>
public abstract class QueryBase : IQuery
{
    public string QueryId { get; } = Guid.NewGuid().ToString();
}

/// <summary>
/// Base class for queries with return value
/// </summary>
/// <typeparam name="TResult">Result type</typeparam>
public abstract class QueryBase<TResult> : QueryBase, IQuery<TResult>
{
}
