namespace Core.Exceptions;

/// <summary>
/// Exception thrown when user does not have permission to perform an action
/// </summary>
public class ForbiddenException : Exception
{
    public string RequiredPermission { get; }

    public ForbiddenException(string requiredPermission) 
        : base($"User does not have required permission: {requiredPermission}")
    {
        RequiredPermission = requiredPermission;
    }

    public ForbiddenException(string message, string requiredPermission) : base(message)
    {
        RequiredPermission = requiredPermission;
    }

}
