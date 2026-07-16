namespace Application.Responses;

/// <summary>
/// Standard service result for application operations
/// </summary>
/// <typeparam name="T">Result type</typeparam>
public class ServiceResult<T>
{
    /// <summary>
    /// Gets whether the operation was successful
    /// </summary>
    public bool IsSuccess { get; set; }

    /// <summary>
    /// Gets the result data
    /// </summary>
    public T? Data { get; set; }

    /// <summary>
    /// Gets the error message
    /// </summary>
    public string? ErrorMessage { get; set; }

    /// <summary>
    /// Gets the error code
    /// </summary>
    public string? ErrorCode { get; set; }

    /// <summary>
    /// Gets validation errors
    /// </summary>
    public Dictionary<string, string[]> ValidationErrors { get; set; } = new();

    /// <summary>
    /// Gets the timestamp
    /// </summary>
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Creates a successful result
    /// </summary>
    public static ServiceResult<T> Success(T data)
    {
        return new ServiceResult<T>
        {
            IsSuccess = true,
            Data = data
        };
    }

    /// <summary>
    /// Creates a failed result
    /// </summary>
    public static ServiceResult<T> Failure(string errorMessage, string? errorCode = null)
    {
        return new ServiceResult<T>
        {
            IsSuccess = false,
            ErrorMessage = errorMessage,
            ErrorCode = errorCode
        };
    }

    /// <summary>
    /// Creates a failed result with validation errors
    /// </summary>
    public static ServiceResult<T> ValidationFailure(Dictionary<string, string[]> validationErrors)
    {
        return new ServiceResult<T>
        {
            IsSuccess = false,
            ErrorMessage = "Validation failed",
            ErrorCode = "VALIDATION_ERROR",
            ValidationErrors = validationErrors
        };
    }
}

/// <summary>
/// Standard service result for operations without return value
/// </summary>
public class ServiceResult
{
    /// <summary>
    /// Gets whether the operation was successful
    /// </summary>
    public bool IsSuccess { get; set; }

    /// <summary>
    /// Gets the error message
    /// </summary>
    public string? ErrorMessage { get; set; }

    /// <summary>
    /// Gets the error code
    /// </summary>
    public string? ErrorCode { get; set; }

    /// <summary>
    /// Gets validation errors
    /// </summary>
    public Dictionary<string, string[]> ValidationErrors { get; set; } = new();

    /// <summary>
    /// Gets the timestamp
    /// </summary>
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Creates a successful result
    /// </summary>
    public static ServiceResult Success()
    {
        return new ServiceResult
        {
            IsSuccess = true
        };
    }

    /// <summary>
    /// Creates a failed result
    /// </summary>
    public static ServiceResult Failure(string errorMessage, string? errorCode = null)
    {
        return new ServiceResult
        {
            IsSuccess = false,
            ErrorMessage = errorMessage,
            ErrorCode = errorCode
        };
    }

    /// <summary>
    /// Creates a failed result with validation errors
    /// </summary>
    public static ServiceResult ValidationFailure(Dictionary<string, string[]> validationErrors)
    {
        return new ServiceResult
        {
            IsSuccess = false,
            ErrorMessage = "Validation failed",
            ErrorCode = "VALIDATION_ERROR",
            ValidationErrors = validationErrors
        };
    }
}
