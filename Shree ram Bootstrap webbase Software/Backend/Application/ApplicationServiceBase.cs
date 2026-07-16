using Platform.Providers;
using Infrastructure.Repositories.Transactions;
using Shared.Interfaces;

namespace Application;

/// <summary>
/// Base class for all application services with common functionality
/// </summary>
public abstract class ApplicationServiceBase : IApplicationService
{
    protected readonly IContextProvider _contextProvider;
    protected readonly IUnitOfWork _unitOfWork;
    protected readonly IEventBus _eventBus;
    protected readonly IAuditService _auditService;

    protected ApplicationServiceBase(
        IContextProvider contextProvider,
        IUnitOfWork unitOfWork,
        IEventBus eventBus,
        IAuditService auditService)
    {
        _contextProvider = contextProvider;
        _unitOfWork = unitOfWork;
        _eventBus = eventBus;
        _auditService = auditService;
    }

    public string ServiceName => GetType().Name;

    /// <summary>
    /// Gets the current company ID from context
    /// </summary>
    protected string? CurrentCompanyId => _contextProvider.CurrentCompanyId;

    /// <summary>
    /// Gets the current assessment year ID from context
    /// </summary>
    protected string? CurrentYearId => _contextProvider.CurrentYearId;

    /// <summary>
    /// Gets the current user ID from context
    /// </summary>
    protected string? CurrentUserId => _contextProvider.CurrentUserId;

    /// <summary>
    /// Gets the current branch from context
    /// </summary>
    protected string? CurrentBranch => _contextProvider.CurrentBranch;

    /// <summary>
    /// Begins a transaction
    /// </summary>
    protected async Task BeginTransactionAsync()
    {
        await _unitOfWork.BeginTransactionAsync();
    }

    /// <summary>
    /// Commits the current transaction
    /// </summary>
    protected async Task CommitTransactionAsync()
    {
        await _unitOfWork.CommitAsync();
    }

    /// <summary>
    /// Rolls back the current transaction
    /// </summary>
    protected async Task RollbackTransactionAsync()
    {
        await _unitOfWork.RollbackAsync();
    }

    /// <summary>
    /// Saves all changes
    /// </summary>
    protected async Task<int> SaveChangesAsync()
    {
        return await _unitOfWork.SaveChangesAsync();
    }

    /// <summary>
    /// Publishes an event to the event bus
    /// </summary>
    protected async Task PublishEventAsync<TEvent>(TEvent @event) where TEvent : class
    {
        // Infrastructure placeholder - will publish to event bus
        await Task.CompletedTask;
    }

    /// <summary>
    /// Logs an audit entry
    /// </summary>
    protected async Task LogAuditAsync(string action, string entity, object? entityId, string? details = null)
    {
        // Infrastructure placeholder - will log to audit service
        await Task.CompletedTask;
    }

    /// <summary>
    /// Executes an operation within a transaction
    /// </summary>
    protected async Task<TResult> ExecuteInTransactionAsync<TResult>(Func<Task<TResult>> operation)
    {
        await BeginTransactionAsync();
        
        try
        {
            var result = await operation();
            await SaveChangesAsync();
            await CommitTransactionAsync();
            return result;
        }
        catch
        {
            await RollbackTransactionAsync();
            throw;
        }
    }

    /// <summary>
    /// Executes an operation within a transaction (no return value)
    /// </summary>
    protected async Task ExecuteInTransactionAsync(Func<Task> operation)
    {
        await BeginTransactionAsync();
        
        try
        {
            await operation();
            await SaveChangesAsync();
            await CommitTransactionAsync();
        }
        catch
        {
            await RollbackTransactionAsync();
            throw;
        }
    }
}
