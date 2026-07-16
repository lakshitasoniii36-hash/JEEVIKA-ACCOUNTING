using Core.Exceptions;

namespace Platform.Engines;

/// <summary>
/// Assessment Year Engine implementation for managing assessment year context
/// </summary>
public class AssessmentYearEngine : IAssessmentYearEngine
{
    private string? _currentYearId;
    private string? _currentYear;
    private DateTime? _yearStart;
    private DateTime? _yearEnd;
    private AssessmentYearStatus _yearStatus = AssessmentYearStatus.Open;

    public string? CurrentYearId => _currentYearId;
    public string? CurrentYear => _currentYear;
    public DateTime? YearStart => _yearStart;
    public DateTime? YearEnd => _yearEnd;
    public AssessmentYearStatus YearStatus => _yearStatus;
    public bool HasYearContext => !string.IsNullOrEmpty(_currentYearId);

    public Task SetAssessmentYearAsync(string yearId, string year, DateTime yearStart, DateTime yearEnd)
    {
        if (string.IsNullOrWhiteSpace(yearId))
            throw new ValidationException("Assessment year ID cannot be empty");
        
        if (string.IsNullOrWhiteSpace(year))
            throw new ValidationException("Assessment year cannot be empty");
        
        if (yearStart >= yearEnd)
            throw new ValidationException("Year start must be before year end");

        _currentYearId = yearId.Trim();
        _currentYear = year.Trim();
        _yearStart = yearStart;
        _yearEnd = yearEnd;
        _yearStatus = AssessmentYearStatus.Open;

        return Task.CompletedTask;
    }

    public Task ClearAssessmentYearAsync()
    {
        _currentYearId = null;
        _currentYear = null;
        _yearStart = null;
        _yearEnd = null;
        _yearStatus = AssessmentYearStatus.Open;

        return Task.CompletedTask;
    }

    public Task<bool> YearExistsAsync(string yearId)
    {
        // Infrastructure placeholder - will be implemented with repository
        // For now, returns true to support architecture without business logic
        return Task.FromResult(!string.IsNullOrWhiteSpace(yearId));
    }

    public Task<IEnumerable<AssessmentYearInfo>> GetAvailableYearsAsync(string companyId)
    {
        // Infrastructure placeholder - will be implemented with repository
        // For now, returns empty list to support architecture without business logic
        return Task.FromResult<IEnumerable<AssessmentYearInfo>>(Enumerable.Empty<AssessmentYearInfo>());
    }

    public Task<AssessmentYearInfo?> GetAssessmentYearAsync(string yearId)
    {
        // Infrastructure placeholder - will be implemented with repository
        // For now, returns null to support architecture without business logic
        return Task.FromResult<AssessmentYearInfo?>(null);
    }

    public Task<AssessmentYearInfo?> GetPreviousYearAsync(string currentYearId)
    {
        // Infrastructure placeholder - will be implemented with repository
        // For now, returns null to support architecture without business logic
        return Task.FromResult<AssessmentYearInfo?>(null);
    }

    public Task<AssessmentYearInfo?> GetNextYearAsync(string currentYearId)
    {
        // Infrastructure placeholder - will be implemented with repository
        // For now, returns null to support architecture without business logic
        return Task.FromResult<AssessmentYearInfo?>(null);
    }
}
