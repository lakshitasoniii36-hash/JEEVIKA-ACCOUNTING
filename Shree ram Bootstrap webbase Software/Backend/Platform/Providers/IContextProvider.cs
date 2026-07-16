namespace Platform.Providers;

/// <summary>
/// Context Provider interface for providing context to controllers and services
/// </summary>
public interface IContextProvider
{
    /// <summary>
    /// Gets the current user ID
    /// </summary>
    string? CurrentUserId { get; }

    /// <summary>
    /// Gets the current username
    /// </summary>
    string? CurrentUsername { get; }

    /// <summary>
    /// Gets the current user type
    /// </summary>
    string? CurrentUserType { get; }

    /// <summary>
    /// Gets the current user level
    /// </summary>
    string? CurrentUserLevel { get; }

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
    /// Gets the current assessment year ID
    /// </summary>
    string? CurrentYearId { get; }

    /// <summary>
    /// Gets the current assessment year
    /// </summary>
    string? CurrentYear { get; }

    /// <summary>
    /// Gets the current financial year start
    /// </summary>
    DateTime? CurrentYearStart { get; }

    /// <summary>
    /// Gets the current financial year end
    /// </summary>
    DateTime? CurrentYearEnd { get; }

    /// <summary>
    /// Gets the current branch
    /// </summary>
    string? CurrentBranch { get; }

    /// <summary>
    /// Gets the current language
    /// </summary>
    string CurrentLanguage { get; }

    /// <summary>
    /// Gets the current currency
    /// </summary>
    string CurrentCurrency { get; }

    /// <summary>
    /// Gets the current timezone
    /// </summary>
    string CurrentTimezone { get; }

    /// <summary>
    /// Gets the current database name
    /// </summary>
    string? CurrentDatabaseName { get; }

    /// <summary>
    /// Gets the current roles
    /// </summary>
    IEnumerable<string> CurrentRoles { get; }

    /// <summary>
    /// Gets the current permissions
    /// </summary>
    IEnumerable<string> CurrentPermissions { get; }

    /// <summary>
    /// Checks if user has a specific permission
    /// </summary>
    /// <param name="permissionCode">Permission code to check</param>
    /// <returns>True if user has permission, false otherwise</returns>
    bool HasPermission(string permissionCode);

    /// <summary>
    /// Checks if user has any of the specified permissions
    /// </summary>
    /// <param name="permissionCodes">Permission codes to check</param>
    /// <returns>True if user has any permission, false otherwise</returns>
    bool HasAnyPermission(params string[] permissionCodes);

    /// <summary>
    /// Checks if user has all specified permissions
    /// </summary>
    /// <param name="permissionCodes">Permission codes to check</param>
    /// <returns>True if user has all permissions, false otherwise</returns>
    bool HasAllPermissions(params string[] permissionCodes);
}
