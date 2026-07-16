namespace Application.Validators;

/// <summary>
/// Interface for validating objects
/// </summary>
/// <typeparam name="T">Type to validate</typeparam>
public interface IValidator<T>
{
    /// <summary>
    /// Validates the object
    /// </summary>
    /// <param name="obj">Object to validate</param>
    /// <returns>Validation result</returns>
    ValidationResult Validate(T obj);
}

/// <summary>
/// Validation result
/// </summary>
public class ValidationResult
{
    /// <summary>
    /// Gets whether validation was successful
    /// </summary>
    public bool IsValid { get; set; }

    /// <summary>
    /// Gets validation errors
    /// </summary>
    public Dictionary<string, string[]> Errors { get; set; } = new();

    /// <summary>
    /// Creates a successful validation result
    /// </summary>
    public static ValidationResult Success()
    {
        return new ValidationResult { IsValid = true };
    }

    /// <summary>
    /// Creates a failed validation result
    /// </summary>
    public static ValidationResult Failure(Dictionary<string, string[]> errors)
    {
        return new ValidationResult
        {
            IsValid = false,
            Errors = errors
        };
    }

    /// <summary>
    /// Adds an error
    /// </summary>
    public void AddError(string propertyName, string errorMessage)
    {
        if (!Errors.ContainsKey(propertyName))
        {
            Errors[propertyName] = Array.Empty<string>();
        }
        
        var errors = Errors[propertyName].ToList();
        errors.Add(errorMessage);
        Errors[propertyName] = errors.ToArray();
    }
}

/// <summary>
/// Abstract validator base class
/// </summary>
/// <typeparam name="T">Type to validate</typeparam>
public abstract class ValidatorBase<T> : IValidator<T>
{
    public ValidationResult Validate(T obj)
    {
        var result = new ValidationResult();
        ValidateInternal(obj, result);
        return result;
    }

    /// <summary>
    /// Internal validation logic
    /// </summary>
    protected abstract void ValidateInternal(T obj, ValidationResult result);
}
