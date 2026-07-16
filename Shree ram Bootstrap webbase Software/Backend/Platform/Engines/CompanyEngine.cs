using Core.Exceptions;

namespace Platform.Engines;

/// <summary>
/// Company Engine implementation for managing company context
/// </summary>
public class CompanyEngine : ICompanyEngine
{
    private string? _currentCompanyId;
    private string? _currentCompanyCode;
    private string? _currentCompanyName;

    public string? CurrentCompanyId => _currentCompanyId;
    public string? CurrentCompanyCode => _currentCompanyCode;
    public string? CurrentCompanyName => _currentCompanyName;
    public bool HasCompanyContext => !string.IsNullOrEmpty(_currentCompanyId);

    public Task SetCompanyAsync(string companyId, string companyCode, string companyName)
    {
        if (string.IsNullOrWhiteSpace(companyId))
            throw new ValidationException("Company ID cannot be empty");
        
        if (string.IsNullOrWhiteSpace(companyCode))
            throw new ValidationException("Company code cannot be empty");
        
        if (string.IsNullOrWhiteSpace(companyName))
            throw new ValidationException("Company name cannot be empty");

        _currentCompanyId = companyId.Trim();
        _currentCompanyCode = companyCode.Trim();
        _currentCompanyName = companyName.Trim();

        return Task.CompletedTask;
    }

    public Task ClearCompanyAsync()
    {
        _currentCompanyId = null;
        _currentCompanyCode = null;
        _currentCompanyName = null;

        return Task.CompletedTask;
    }

    public Task<bool> CompanyExistsAsync(string companyId)
    {
        // Infrastructure placeholder - will be implemented with repository
        // For now, returns true to support architecture without business logic
        return Task.FromResult(!string.IsNullOrWhiteSpace(companyId));
    }

    public Task<IEnumerable<CompanyInfo>> GetAvailableCompaniesAsync()
    {
        // Infrastructure placeholder - will be implemented with repository
        // For now, returns empty list to support architecture without business logic
        return Task.FromResult<IEnumerable<CompanyInfo>>(Enumerable.Empty<CompanyInfo>());
    }

    public Task<CompanyInfo?> GetCompanyAsync(string companyId)
    {
        // Infrastructure placeholder - will be implemented with repository
        // For now, returns null to support architecture without business logic
        return Task.FromResult<CompanyInfo?>(null);
    }
}
