namespace Shared.Interfaces;

/// <summary>
/// Interface for permission checking operations
/// </summary>
public interface IPermissionService
{
    /// <summary>
    /// Checks if current user has a specific permission
    /// </summary>
    Task<bool> HasPermissionAsync(string permissionCode);

    /// <summary>
    /// Checks if current user has any of the specified permissions
    /// </summary>
    Task<bool> HasAnyPermissionAsync(params string[] permissionCodes);

    /// <summary>
    /// Checks if current user has all specified permissions
    /// </summary>
    Task<bool> HasAllPermissionsAsync(params string[] permissionCodes);

    /// <summary>
    /// Gets all permissions for current user
    /// </summary>
    Task<IEnumerable<string>> GetUserPermissionsAsync();

    /// <summary>
    /// Gets all roles for current user
    /// </summary>
    Task<IEnumerable<string>> GetUserRolesAsync();
}

/// <summary>
/// Standard permission codes
/// </summary>
public static class PermissionCodes
{
    // Accounting Permissions
    public const string ACCOUNT_CREATE = "ACCOUNT_CREATE";
    public const string ACCOUNT_EDIT = "ACCOUNT_EDIT";
    public const string ACCOUNT_DELETE = "ACCOUNT_DELETE";
    public const string ACCOUNT_VIEW = "ACCOUNT_VIEW";
    public const string JV_POST = "JV_POST";
    public const string JV_DELETE = "JV_DELETE";
    public const string JV_VIEW = "JV_VIEW";
    public const string PAYMENT_APPROVE = "PAYMENT_APPROVE";
    public const string PAYMENT_CREATE = "PAYMENT_CREATE";
    public const string PAYMENT_DELETE = "PAYMENT_DELETE";
    public const string RECEIPT_CREATE = "RECEIPT_CREATE";
    public const string RECEIPT_DELETE = "RECEIPT_DELETE";

    // Member Permissions
    public const string MEMBER_CREATE = "MEMBER_CREATE";
    public const string MEMBER_EDIT = "MEMBER_EDIT";
    public const string MEMBER_DELETE = "MEMBER_DELETE";
    public const string MEMBER_VIEW = "MEMBER_VIEW";
    public const string MEMBER_TRANSFER = "MEMBER_TRANSFER";

    // Report Permissions
    public const string REPORT_VIEW = "REPORT_VIEW";
    public const string REPORT_PRINT = "REPORT_PRINT";
    public const string REPORT_EXPORT = "REPORT_EXPORT";

    // Society Permissions
    public const string SOCIETY_MANAGE = "SOCIETY_MANAGE";
    public const string SOCIETY_CONFIGURE = "SOCIETY_CONFIGURE";

    // Admin Permissions
    public const string USER_MANAGE = "USER_MANAGE";
    public const string ROLE_MANAGE = "ROLE_MANAGE";
    public const string SYSTEM_CONFIGURE = "SYSTEM_CONFIGURE";
}
