using Infrastructure.Repositories.Transactions;

namespace Application.Behaviors;

/// <summary>
/// Transaction behavior for wrapping operations in transactions
/// </summary>
/// <typeparam name="TRequest">Request type</typeparam>
/// <typeparam name="TResponse">Response type</typeparam>
public class TransactionBehavior<TRequest, TResponse> : IBehavior<TRequest, TResponse>
{
    private readonly IUnitOfWork _unitOfWork;

    public TransactionBehavior(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<TResponse> HandleAsync(TRequest request, Func<Task<TResponse>> next, CancellationToken cancellationToken = default)
    {
        // Infrastructure placeholder - will wrap in transaction
        // Future: Begin transaction, execute, commit/rollback
        return await next();
    }
}
