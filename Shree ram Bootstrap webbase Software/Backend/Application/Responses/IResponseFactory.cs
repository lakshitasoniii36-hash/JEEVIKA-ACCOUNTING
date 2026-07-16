namespace Application.Responses;

/// <summary>
/// Interface for creating standardized responses
/// </summary>
public interface IResponseFactory
{
    /// <summary>
    /// Creates a successful response
    /// </summary>
    /// <typeparam name="T">Data type</typeparam>
    /// <param name="data">Response data</param>
    /// <returns>Service result with data</returns>
    ServiceResult<T> Success<T>(T data);

    /// <summary>
    /// Creates a successful response without data
    /// </summary>
    /// <returns>Service result</returns>
    ServiceResult Success();

    /// <summary>
    /// Creates a failed response
    /// </summary>
    /// <param name="errorMessage">Error message</param>
    /// <param name="errorCode">Error code</param>
    /// <returns>Service result with error</returns>
    ServiceResult Failure(string errorMessage, string? errorCode = null);

    /// <summary>
    /// Creates a failed response with data
    /// </summary>
    /// <typeparam name="T">Data type</typeparam>
    /// <param name="errorMessage">Error message</param>
    /// <param name="errorCode">Error code</param>
    /// <returns>Service result with error</returns>
    ServiceResult<T> Failure<T>(string errorMessage, string? errorCode = null);

    /// <summary>
    /// Creates a validation failure response
    /// </summary>
    /// <param name="validationErrors">Validation errors</param>
    /// <returns>Service result with validation errors</returns>
    ServiceResult ValidationFailure(Dictionary<string, string[]> validationErrors);

    /// <summary>
    /// Creates a validation failure response with data
    /// </summary>
    /// <typeparam name="T">Data type</typeparam>
    /// <param name="validationErrors">Validation errors</param>
    /// <returns>Service result with validation errors</returns>
    ServiceResult<T> ValidationFailure<T>(Dictionary<string, string[]> validationErrors);
}

/// <summary>
/// Default response factory implementation
/// </summary>
public class ResponseFactory : IResponseFactory
{
    public ServiceResult<T> Success<T>(T data)
    {
        return ServiceResult<T>.Success(data);
    }

    public ServiceResult Success()
    {
        return ServiceResult.Success();
    }

    public ServiceResult Failure(string errorMessage, string? errorCode = null)
    {
        return ServiceResult.Failure(errorMessage, errorCode);
    }

    public ServiceResult<T> Failure<T>(string errorMessage, string? errorCode = null)
    {
        return ServiceResult<T>.Failure(errorMessage, errorCode);
    }

    public ServiceResult ValidationFailure(Dictionary<string, string[]> validationErrors)
    {
        return ServiceResult.ValidationFailure(validationErrors);
    }

    public ServiceResult<T> ValidationFailure<T>(Dictionary<string, string[]> validationErrors)
    {
        return ServiceResult<T>.ValidationFailure(validationErrors);
    }
}
