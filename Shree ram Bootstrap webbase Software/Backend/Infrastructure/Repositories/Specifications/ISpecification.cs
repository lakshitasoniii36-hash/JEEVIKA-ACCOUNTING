using System.Linq.Expressions;

namespace Infrastructure.Repositories.Specifications;

/// <summary>
/// Specification interface for encapsulating query logic
/// </summary>
/// <typeparam name="TEntity">Entity type</typeparam>
public interface ISpecification<TEntity>
{
    /// <summary>
    /// Gets the filter expression
    /// </summary>
    Expression<Func<TEntity, bool>>? Criteria { get; }

    /// <summary>
    /// Gets the include expressions (navigation properties)
    /// </summary>
    List<Expression<Func<TEntity, object>>> Includes { get; }

    /// <summary>
    /// Gets the include strings (navigation properties as strings)
    /// </summary>
    List<string> IncludeStrings { get; }

    /// <summary>
    /// Gets the order by expression
    /// </summary>
    Expression<Func<TEntity, object>>? OrderBy { get; }

    /// <summary>
    /// Gets the order by descending expression
    /// </summary>
    Expression<Func<TEntity, object>>? OrderByDescending { get; }

    /// <summary>
    /// Gets the group by expression
    /// </summary>
    Expression<Func<TEntity, object>>? GroupBy { get; }

    /// <summary>
    /// Gets the pagination (skip and take)
    /// </summary>
    (int Skip, int Take)? Pagination { get; }

    /// <summary>
    /// Gets whether tracking is enabled
    /// </summary>
    bool AsNoTracking { get; }
}

/// <summary>
/// Base specification with common functionality
/// </summary>
/// <typeparam name="TEntity">Entity type</typeparam>
public abstract class BaseSpecification<TEntity> : ISpecification<TEntity>
{
    protected BaseSpecification()
    {
        Includes = new List<Expression<Func<TEntity, object>>>();
        IncludeStrings = new List<string>();
    }

    public Expression<Func<TEntity, bool>>? Criteria { get; private set; }
    public List<Expression<Func<TEntity, object>>> Includes { get; }
    public List<string> IncludeStrings { get; }
    public Expression<Func<TEntity, object>>? OrderBy { get; private set; }
    public Expression<Func<TEntity, object>>? OrderByDescending { get; private set; }
    public Expression<Func<TEntity, object>>? GroupBy { get; private set; }
    public (int Skip, int Take)? Pagination { get; private set; }
    public bool AsNoTracking { get; private set; }

    /// <summary>
    /// Adds a filter criteria
    /// </summary>
    protected void AddCriteria(Expression<Func<TEntity, bool>> criteria)
    {
        Criteria = criteria;
    }

    /// <summary>
    /// Adds an include expression
    /// </summary>
    protected void AddInclude(Expression<Func<TEntity, object>> includeExpression)
    {
        Includes.Add(includeExpression);
    }

    /// <summary>
    /// Adds an include string
    /// </summary>
    protected void AddInclude(string includeString)
    {
        IncludeStrings.Add(includeString);
    }

    /// <summary>
    /// Adds order by ascending
    /// </summary>
    protected void ApplyOrderBy(Expression<Func<TEntity, object>> orderByExpression)
    {
        OrderBy = orderByExpression;
    }

    /// <summary>
    /// Adds order by descending
    /// </summary>
    protected void ApplyOrderByDescending(Expression<Func<TEntity, object>> orderByDescendingExpression)
    {
        OrderByDescending = orderByDescendingExpression;
    }

    /// <summary>
    /// Adds group by
    /// </summary>
    protected void ApplyGroupBy(Expression<Func<TEntity, object>> groupByExpression)
    {
        GroupBy = groupByExpression;
    }

    /// <summary>
    /// Applies pagination
    /// </summary>
    protected void ApplyPaging(int skip, int take)
    {
        Pagination = (skip, take);
    }

    /// <summary>
    /// Disables change tracking
    /// </summary>
    protected void DisableTracking()
    {
        AsNoTracking = true;
    }
}

/// <summary>
/// Specification for a single entity by ID
/// </summary>
/// <typeparam name="TEntity">Entity type</typeparam>
public class GetByIdSpecification<TEntity> : BaseSpecification<TEntity>
{
    public GetByIdSpecification(object id)
    {
        // This will be implemented in the concrete repository
        // The actual implementation depends on the entity's ID property
    }
}
