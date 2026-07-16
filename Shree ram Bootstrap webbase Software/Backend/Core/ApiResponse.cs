namespace Core;

/// <summary>
/// Standard API response model for all endpoints
/// </summary>
/// <typeparam name="T">Type of the data payload</typeparam>
public class ApiResponse<T>
{
    public bool Success { get; set; }
    public string Message { get; set; } = string.Empty;
    public T? Data { get; set; }
    public List<string> Errors { get; set; } = new();
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    public string CorrelationId { get; set; } = Guid.NewGuid().ToString();

    public static ApiResponse<T> Ok(T data, string message = "Operation successful")
    {
        return new ApiResponse<T>
        {
            Success = true,
            Message = message,
            Data = data
        };
    }

    public static ApiResponse<T> Fail(string error)
    {
        return new ApiResponse<T>
        {
            Success = false,
            Message = "Operation failed",
            Errors = new List<string> { error }
        };
    }

    public static ApiResponse<T> Fail(List<string> errors)
    {
        return new ApiResponse<T>
        {
            Success = false,
            Message = "Operation failed",
            Errors = errors
        };
    }

    public static ApiResponse<T> FromResult(Result<T> result)
    {
        if (result.IsSuccess)
        {
            return Ok(result.Value!);
        }
        return Fail(result.Error);
    }
}

/// <summary>
/// Standard API response model for endpoints without data payload
/// </summary>
public class ApiResponse
{
    public bool Success { get; set; }
    public string Message { get; set; } = string.Empty;
    public List<string> Errors { get; set; } = new();
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    public string CorrelationId { get; set; } = Guid.NewGuid().ToString();

    public static ApiResponse Ok(string message = "Operation successful")
    {
        return new ApiResponse
        {
            Success = true,
            Message = message
        };
    }

    public static ApiResponse Fail(string error)
    {
        return new ApiResponse
        {
            Success = false,
            Message = "Operation failed",
            Errors = new List<string> { error }
        };
    }

    public static ApiResponse Fail(List<string> errors)
    {
        return new ApiResponse
        {
            Success = false,
            Message = "Operation failed",
            Errors = errors
        };
    }

    public static ApiResponse FromResult(Result result)
    {
        if (result.IsSuccess)
        {
            return Ok();
        }
        return Fail(result.Error);
    }
}
