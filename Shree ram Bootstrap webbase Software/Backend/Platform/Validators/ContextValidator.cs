using Core.Exceptions;
using Core;
using Platform.Engines;

namespace Platform.Validators;

/// <summary>
/// Context Validator implementation for validating context information
/// </summary>
public class ContextValidator : IContextValidator
{
    private readonly ICompanyEngine _companyEngine;
    private readonly IAssessmentYearEngine _assessmentYearEngine;
    private readonly IApplicationContextManager _contextManager;

    public ContextValidator(
        ICompanyEngine companyEngine,
        IAssessmentYearEngine assessmentYearEngine,
        IApplicationContextManager contextManager)
    {
        _companyEngine = companyEngine;
        _assessmentYearEngine = assessmentYearEngine;
        _contextManager = contextManager;
    }

    public async Task<Result> ValidateCompanyExistsAsync(string companyId)
    {
        if (string.IsNullOrWhiteSpace(companyId))
            return Result.Failure("Company ID cannot be empty");

        var exists = await _companyEngine.CompanyExistsAsync(companyId);
        if (!exists)
            return Result.Failure($"Company with ID '{companyId}' does not exist");

        return Result.Success();
    }

    public async Task<Result> ValidateAssessmentYearExistsAsync(string yearId)
    {
        if (string.IsNullOrWhiteSpace(yearId))
            return Result.Failure("Assessment year ID cannot be empty");

        var exists = await _assessmentYearEngine.YearExistsAsync(yearId);
        if (!exists)
            return Result.Failure($"Assessment year with ID '{yearId}' does not exist");

        return Result.Success();
    }

    public async Task<Result> ValidateContextInitializedAsync()
    {
        var errors = new List<string>();

        if (!_contextManager.UserContext.IsAuthenticated)
            errors.Add("User context not initialized");

        if (!_contextManager.CompanyContext.HasCompany)
            errors.Add("Company context not initialized");

        if (!_contextManager.AssessmentYearContext.HasYear)
            errors.Add("Assessment year context not initialized");

        if (errors.Count > 0)
            return Result.Failure(errors);

        return await Task.FromResult(Result.Success());
    }

    public async Task<Result> ValidateContextNotExpiredAsync()
    {
        // Infrastructure placeholder - will check session expiration, token expiration, etc.
        // For now, returns success to support architecture without business logic
        return await Task.FromResult(Result.Success());
    }

    public async Task<Result> ValidateUserCompanyAccessAsync(string userId, string companyId)
    {
        // Infrastructure placeholder - will check user's access to company
        // For now, returns success to support architecture without business logic
        return await Task.FromResult(Result.Success());
    }

    public async Task<Result> ValidateAssessmentYearAccessibleAsync(string yearId)
    {
        // Infrastructure placeholder - will check if year is accessible (not closed/archived)
        // For now, returns success to support architecture without business logic
        return await Task.FromResult(Result.Success());
    }

    public async Task<Result> ValidateAllContextsAsync()
    {
        var errors = new List<string>();

        // Validate user context
        if (!_contextManager.UserContext.IsAuthenticated)
            errors.Add("User context not initialized");

        // Validate company context
        if (_contextManager.CompanyContext.HasCompany)
        {
            var companyValidation = await ValidateCompanyExistsAsync(_contextManager.CompanyContext.CompanyId);
            if (companyValidation.IsFailure)
                errors.AddRange(companyValidation.Errors);
        }
        else
        {
            errors.Add("Company context not initialized");
        }

        // Validate assessment year context
        if (_contextManager.AssessmentYearContext.HasYear)
        {
            var yearValidation = await ValidateAssessmentYearExistsAsync(_contextManager.AssessmentYearContext.YearId);
            if (yearValidation.IsFailure)
                errors.AddRange(yearValidation.Errors);
        }
        else
        {
            errors.Add("Assessment year context not initialized");
        }

        // Validate context not expired
        var expirationValidation = await ValidateContextNotExpiredAsync();
        if (expirationValidation.IsFailure)
            errors.AddRange(expirationValidation.Errors);

        if (errors.Count > 0)
            return Result.Failure(errors);

        return Result.Success();
    }
}
