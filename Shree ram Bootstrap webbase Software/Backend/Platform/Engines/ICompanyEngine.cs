namespace Platform.Engines;

/// <summary>
/// Company Engine interface for managing company context and operations
/// </summary>
public interface ICompanyEngine
{
    /// <summary>
    /// Gets the current company ID
    /// </summary>
    string? CurrentCompanyId { get; }

    /// <summary>
    /// Gets the current company code
    /// </summary>
    string? CurrentCompanyCode { get; }

    /// <summary>
    /// Gets the current company name
    /// </summary>
    string? CurrentCompanyName { get; }

    /// <summary>
    /// Checks if a company context is set
    /// </summary>
    bool HasCompanyContext { get; }

    /// <summary>
    /// Sets the current company context
    /// </summary>
    /// <param name="companyId">Company ID</param>
    /// <param name="companyCode">Company code</param>
    /// <param name="companyName">Company name</param>
    Task SetCompanyAsync(string companyId, string companyCode, string companyName);

    /// <summary>
    /// Clears the current company context
    /// </summary>
    Task ClearCompanyAsync();

    /// <summary>
    /// Validates that a company exists (infrastructure only, no business logic)
    /// </summary>
    /// <param name="companyId">Company ID to validate</param>
    /// <returns>True if company exists, false otherwise</returns>
    Task<bool> CompanyExistsAsync(string companyId);

    /// <summary>
    /// Gets all available companies (infrastructure only, no business logic)
    /// </summary>
    /// <returns>List of company information</returns>
    Task<IEnumerable<CompanyInfo>> GetAvailableCompaniesAsync();

    /// <summary>
    /// Gets company information by ID (infrastructure only, no business logic)
    /// </summary>
    /// <param name="companyId">Company ID</param>
    /// <returns>Company information or null if not found</returns>
    Task<CompanyInfo?> GetCompanyAsync(string companyId);
}

/// <summary>
/// Company information model
/// </summary>
public class CompanyInfo
{
    public string CompanyId { get; set; } = string.Empty;
    public string CompanyCode { get; set; } = string.Empty;
    public string CompanyName { get; set; } = string.Empty;
    public string DatabaseName { get; set; } = string.Empty;
    public bool IsActive { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? ModifiedDate { get; set; }
}
