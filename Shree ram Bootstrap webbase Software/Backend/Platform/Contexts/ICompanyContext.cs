namespace Platform.Contexts;

/// <summary>
/// Current company context information
/// </summary>
public interface ICompanyContext
{
    /// <summary>
    /// Company ID
    /// </summary>
    string CompanyId { get; }

    /// <summary>
    /// Company code
    /// </summary>
    string CompanyCode { get; }

    /// <summary>
    /// Company name
    /// </summary>
    string CompanyName { get; }

    /// <summary>
    /// Whether company context is set
    /// </summary>
    bool HasCompany { get; }

    /// <summary>
    /// Sets the current company context
    /// </summary>
    void SetCompany(string companyId, string companyCode, string companyName);

    /// <summary>
    /// Clears the current company context
    /// </summary>
    void Clear();
}
