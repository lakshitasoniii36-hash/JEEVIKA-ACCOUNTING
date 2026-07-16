namespace Platform.Contexts;

/// <summary>
/// Current user context information
/// </summary>
public interface ICurrentUserContext
{
    /// <summary>
    /// User ID
    /// </summary>
    string UserId { get; }

    /// <summary>
    /// Username
    /// </summary>
    string Username { get; }

    /// <summary>
    /// User type
    /// </summary>
    string UserType { get; }

    /// <summary>
    /// User level
    /// </summary>
    string UserLevel { get; }

    /// <summary>
    /// Whether user is authenticated
    /// </summary>
    bool IsAuthenticated { get; }

    /// <summary>
    /// Sets the current user context
    /// </summary>
    void SetUser(string userId, string username, string userType, string userLevel);

    /// <summary>
    /// Clears the current user context
    /// </summary>
    void Clear();
}
