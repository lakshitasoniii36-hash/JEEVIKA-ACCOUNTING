using Core.Exceptions;
using Core;

namespace Platform.Validators;

/// <summary>
/// Context Validator interface for validating context information
/// </summary>
public interface IContextValidator
{
    /// <summary>
    /// Validates that a company exists
    /// </summary>
    /// <param name="companyId">Company ID to validate</param>
    /// <returns>Validation result</returns>
    Task<Result> ValidateCompanyExistsAsync(string companyId);

    /// <summary>
    /// Validates that an assessment year exists
    /// </summary>
    /// <param name="yearId">Assessment year ID to validate</param>
    /// <returns>Validation result</returns>
    Task<Result> ValidateAssessmentYearExistsAsync(string yearId);

    /// <summary>
    /// Validates that context is initialized
    /// </summary>
    /// <returns>Validation result</returns>
    Task<Result> ValidateContextInitializedAsync();

    /// <summary>
    /// Validates that context is not expired
    /// </summary>
    /// <returns>Validation result</returns>
    Task<Result> ValidateContextNotExpiredAsync();

    /// <summary>
    /// Validates that user has access to company
    /// </summary>
    /// <param name="userId">User ID</param>
    /// <param name="companyId">Company ID</param>
    /// <returns>Validation result</returns>
    Task<Result> ValidateUserCompanyAccessAsync(string userId, string companyId);

    /// <summary>
    /// Validates that assessment year is accessible
    /// </summary>
    /// <param name="yearId">Assessment year ID</param>
    /// <returns>Validation result</returns>
    Task<Result> ValidateAssessmentYearAccessibleAsync(string yearId);

    /// <summary>
    /// Validates all contexts
    /// </summary>
    /// <returns>Validation result with all errors</returns>
    Task<Result> ValidateAllContextsAsync();
}

/// <summary>
/// Context validation result
/// </summary>
public class ContextValidationResult
{
    public bool IsValid { get; set; }
    public List<string> Errors { get; set; } = new();
    public List<string> Warnings { get; set; } = new();
}
