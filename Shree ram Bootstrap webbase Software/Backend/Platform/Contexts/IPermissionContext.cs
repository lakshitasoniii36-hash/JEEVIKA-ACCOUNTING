namespace Platform.Contexts;

/// <summary>
/// Current permission context information
/// </summary>
public interface IPermissionContext
{
    /// <summary>
    /// User's roles
    /// </summary>
    IEnumerable<string> Roles { get; }

    /// <summary>
    /// User's permissions
    /// </summary>
    IEnumerable<string> Permissions { get; }

    /// <summary>
    /// Checks if user has a specific permission
    /// </summary>
    bool HasPermission(string permissionCode);

    /// <summary>
    /// Checks if user has any of the specified permissions
    /// </summary>
    bool HasAnyPermission(params string[] permissionCodes);

    /// <summary>
    /// Sets the current permission context
    /// </summary>
    void SetPermissions(IEnumerable<string> roles, IEnumerable<string> permissions);

    /// <summary>
    /// Clears the current permission context
    /// </summary>
    void Clear();
}
