using Core.Exceptions;
using System.Net;

namespace Core.Exceptions;

/// <summary>
/// Middleware for centralized exception handling
/// </summary>
public class ExceptionHandlingMiddleware
{
    private readonly RequestDelegate _next;

    public ExceptionHandlingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (ValidationException ex)
        {
            await HandleValidationExceptionAsync(context, ex);
        }
        catch (NotFoundException ex)
        {
            await HandleNotFoundExceptionAsync(context, ex);
        }
        catch (UnauthorizedException ex)
        {
            await HandleUnauthorizedExceptionAsync(context, ex);
        }
        catch (ForbiddenException ex)
        {
            await HandleForbiddenExceptionAsync(context, ex);
        }
        catch (ConflictException ex)
        {
            await HandleConflictExceptionAsync(context, ex);
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(context, ex);
        }
    }

    private static Task HandleValidationExceptionAsync(HttpContext context, ValidationException exception)
    {
        context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
        var response = new ApiResponse
        {
            Success = false,
            Message = "Validation failed",
            Errors = exception.Errors
        };
        return context.Response.WriteAsJsonAsync(response);
    }

    private static Task HandleNotFoundExceptionAsync(HttpContext context, NotFoundException exception)
    {
        context.Response.StatusCode = (int)HttpStatusCode.NotFound;
        var response = new ApiResponse
        {
            Success = false,
            Message = exception.Message,
            Errors = new List<string> { exception.Message }
        };
        return context.Response.WriteAsJsonAsync(response);
    }

    private static Task HandleUnauthorizedExceptionAsync(HttpContext context, UnauthorizedException exception)
    {
        context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
        var response = new ApiResponse
        {
            Success = false,
            Message = exception.Message,
            Errors = new List<string> { exception.Message }
        };
        return context.Response.WriteAsJsonAsync(response);
    }

    private static Task HandleForbiddenExceptionAsync(HttpContext context, ForbiddenException exception)
    {
        context.Response.StatusCode = (int)HttpStatusCode.Forbidden;
        var response = new ApiResponse
        {
            Success = false,
            Message = exception.Message,
            Errors = new List<string> { exception.Message }
        };
        return context.Response.WriteAsJsonAsync(response);
    }

    private static Task HandleConflictExceptionAsync(HttpContext context, ConflictException exception)
    {
        context.Response.StatusCode = (int)HttpStatusCode.Conflict;
        var response = new ApiResponse
        {
            Success = false,
            Message = exception.Message,
            Errors = new List<string> { exception.Message }
        };
        return context.Response.WriteAsJsonAsync(response);
    }

    private static Task HandleExceptionAsync(HttpContext context, Exception exception)
    {
        context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
        var response = new ApiResponse
        {
            Success = false,
            Message = "An unexpected error occurred",
            Errors = new List<string> { exception.Message }
        };
        return context.Response.WriteAsJsonAsync(response);
    }
}

/// <summary>
/// Extension method to register exception handling middleware
/// </summary>
public static class ExceptionHandlingMiddlewareExtensions
{
    public static IApplicationBuilder UseExceptionHandling(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<ExceptionHandlingMiddleware>();
    }
}
