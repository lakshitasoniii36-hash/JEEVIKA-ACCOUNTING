namespace Platform.Contexts;

/// <summary>
/// Current assessment year context information
/// </summary>
public interface IAssessmentYearContext
{
    /// <summary>
    /// Assessment year ID
    /// </summary>
    string YearId { get; }

    /// <summary>
    /// Assessment year
    /// </summary>
    string Year { get; }

    /// <summary>
    /// Financial year start
    /// </summary>
    DateTime YearStart { get; }

    /// <summary>
    /// Financial year end
    /// </summary>
    DateTime YearEnd { get; }

    /// <summary>
    /// Whether assessment year context is set
    /// </summary>
    bool HasYear { get; }

    /// <summary>
    /// Sets the current assessment year context
    /// </summary>
    void SetAssessmentYear(string yearId, string year, DateTime yearStart, DateTime yearEnd);

    /// <summary>
    /// Clears the current assessment year context
    /// </summary>
    void Clear();
}
