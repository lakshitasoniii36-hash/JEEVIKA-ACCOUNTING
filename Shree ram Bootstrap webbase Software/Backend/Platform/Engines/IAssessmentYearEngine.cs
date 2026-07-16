namespace Platform.Engines;

/// <summary>
/// Assessment Year Engine interface for managing assessment year context and operations
/// </summary>
public interface IAssessmentYearEngine
{
    /// <summary>
    /// Gets the current assessment year ID
    /// </summary>
    string? CurrentYearId { get; }

    /// <summary>
    /// Gets the current assessment year (e.g., "2024-25")
    /// </summary>
    string? CurrentYear { get; }

    /// <summary>
    /// Gets the current financial year start date
    /// </summary>
    DateTime? YearStart { get; }

    /// <summary>
    /// Gets the current financial year end date
    /// </summary>
    DateTime? YearEnd { get; }

    /// <summary>
    /// Gets the current assessment year status
    /// </summary>
    AssessmentYearStatus YearStatus { get; }

    /// <summary>
    /// Checks if an assessment year context is set
    /// </summary>
    bool HasYearContext { get; }

    /// <summary>
    /// Sets the current assessment year context
    /// </summary>
    /// <param name="yearId">Assessment year ID</param>
    /// <param name="year">Assessment year (e.g., "2024-25")</param>
    /// <param name="yearStart">Financial year start date</param>
    /// <param name="yearEnd">Financial year end date</param>
    Task SetAssessmentYearAsync(string yearId, string year, DateTime yearStart, DateTime yearEnd);

    /// <summary>
    /// Clears the current assessment year context
    /// </summary>
    Task ClearAssessmentYearAsync();

    /// <summary>
    /// Validates that an assessment year exists (infrastructure only, no business logic)
    /// </summary>
    /// <param name="yearId">Assessment year ID to validate</param>
    /// <returns>True if assessment year exists, false otherwise</returns>
    Task<bool> YearExistsAsync(string yearId);

    /// <summary>
    /// Gets all available assessment years for a company (infrastructure only, no business logic)
    /// </summary>
    /// <param name="companyId">Company ID</param>
    /// <returns>List of assessment year information</returns>
    Task<IEnumerable<AssessmentYearInfo>> GetAvailableYearsAsync(string companyId);

    /// <summary>
    /// Gets assessment year information by ID (infrastructure only, no business logic)
    /// </summary>
    /// <param name="yearId">Assessment year ID</param>
    /// <returns>Assessment year information or null if not found</returns>
    Task<AssessmentYearInfo?> GetAssessmentYearAsync(string yearId);

    /// <summary>
    /// Gets the previous assessment year (infrastructure only, no business logic)
    /// </summary>
    /// <param name="currentYearId">Current assessment year ID</param>
    /// <returns>Previous assessment year information or null if not found</returns>
    Task<AssessmentYearInfo?> GetPreviousYearAsync(string currentYearId);

    /// <summary>
    /// Gets the next assessment year (infrastructure only, no business logic)
    /// </summary>
    /// <param name="currentYearId">Current assessment year ID</param>
    /// <returns>Next assessment year information or null if not found</returns>
    Task<AssessmentYearInfo?> GetNextYearAsync(string currentYearId);
}

/// <summary>
/// Assessment year status enumeration
/// </summary>
public enum AssessmentYearStatus
{
    /// <summary>
    /// Year is open for transactions
    /// </summary>
    Open = 1,

    /// <summary>
    /// Year is frozen - no new transactions allowed
    /// </summary>
    Frozen = 2,

    /// <summary>
    /// Year is closed - read-only
    /// </summary>
    Closed = 3,

    /// <summary>
    /// Year is archived - historical only
    /// </summary>
    Archived = 4
}

/// <summary>
/// Assessment year information model
/// </summary>
public class AssessmentYearInfo
{
    public string YearId { get; set; } = string.Empty;
    public string CompanyId { get; set; } = string.Empty;
    public string Year { get; set; } = string.Empty;
    public DateTime YearStart { get; set; }
    public DateTime YearEnd { get; set; }
    public AssessmentYearStatus Status { get; set; }
    public bool IsCurrent { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? ModifiedDate { get; set; }
}
