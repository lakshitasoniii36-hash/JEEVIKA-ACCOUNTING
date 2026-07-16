namespace Core.Exceptions;

/// <summary>
/// Exception thrown when validation fails
/// </summary>
public class ValidationException : Exception
{
    public List<string> Errors { get; }

    public ValidationException(string error) : base(error)
    {
        Errors = new List<string> { error };
    }

    public ValidationException(List<string> errors) : base(errors.Count > 0 ? errors[0] : "Validation failed")
    {
        Errors = errors;
    }

    public ValidationException(string message, List<string> errors) : base(message)
    {
        Errors = errors;
    }
}
