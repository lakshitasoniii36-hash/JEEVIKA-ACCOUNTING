namespace Infrastructure.Repositories.Queries;

/// <summary>
/// Query object for filtering, sorting, and pagination
/// </summary>
/// <typeparam name="TEntity">Entity type</typeparam>
public class Query<TEntity>
{
    /// <summary>
    /// Filter criteria
    /// </summary>
    public FilterCriteria? Filter { get; set; }

    /// <summary>
    /// Sort criteria
    /// </summary>
    public SortCriteria? Sort { get; set; }

    /// <summary>
    /// Pagination criteria
    /// </summary>
    public PaginationCriteria? Pagination { get; set; }

    /// <summary>
    /// Search criteria
    /// </summary>
    public SearchCriteria? Search { get; set; }

    /// <summary>
    /// Include navigation properties
    /// </summary>
    public List<string> Includes { get; set; } = new();
}

/// <summary>
/// Filter criteria
/// </summary>
public class FilterCriteria
{
    /// <summary>
    /// Property name to filter on
    /// </summary>
    public string Property { get; set; } = string.Empty;

    /// <summary>
    /// Filter operation
    /// </summary>
    public FilterOperation Operation { get; set; }

    /// <summary>
    /// Filter value
    /// </summary>
    public object? Value { get; set; }
}

/// <summary>
/// Filter operations
/// </summary>
public enum FilterOperation
{
    Equal,
    NotEqual,
    GreaterThan,
    GreaterThanOrEqual,
    LessThan,
    LessThanOrEqual,
    Contains,
    StartsWith,
    EndsWith,
    In,
    NotIn
}

/// <summary>
/// Sort criteria
/// </summary>
public class SortCriteria
{
    /// <summary>
    /// Property name to sort on
    /// </summary>
    public string Property { get; set; } = string.Empty;

    /// <summary>
    /// Sort direction
    /// </summary>
    public SortDirection Direction { get; set; } = SortDirection.Ascending;
}

/// <summary>
/// Sort direction
/// </summary>
public enum SortDirection
{
    Ascending,
    Descending
}

/// <summary>
/// Pagination criteria
/// </summary>
public class PaginationCriteria
{
    /// <summary>
    /// Page number (1-based)
    /// </summary>
    public int PageNumber { get; set; } = 1;

    /// <summary>
    /// Page size
    /// </summary>
    public int PageSize { get; set; } = 20;
}

/// <summary>
/// Search criteria
/// </summary>
public class SearchCriteria
{
    /// <summary>
    /// Search term
    /// </summary>
    public string Term { get; set; } = string.Empty;

    /// <summary>
    /// Properties to search in
    /// </summary>
    public List<string> Properties { get; set; } = new();
}
