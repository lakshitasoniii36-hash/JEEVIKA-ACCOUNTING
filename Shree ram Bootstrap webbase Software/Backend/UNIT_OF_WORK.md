# Unit of Work Documentation

**Version:** 1.0  
**Last Updated:** 2026-07-07  
**Purpose:** Document the Unit of Work pattern implementation for transaction management

---

## Overview

The Unit of Work pattern provides transaction management for repository operations. It ensures that multiple repository operations can be executed within a single transaction, with the ability to commit or rollback all changes atomically.

---

## Purpose

### Transaction Management
- Begin transactions
- Commit transactions
- Rollback transactions
- Track transaction status
- Save all changes

### Benefits
- **Atomicity:** All operations succeed or fail together
- **Consistency:** Database remains consistent
- **Isolation:** Transactions are isolated from each other
- **Durability:** Committed changes are permanent

---

## IUnitOfWork Interface

### Methods

#### BeginTransactionAsync
Begins a new transaction.

```csharp
Task BeginTransactionAsync(CancellationToken cancellationToken = default)
```

**Behavior:**
- Creates a new SQLite connection
- Begins a new transaction
- Sets transaction status to InProgress
- Throws if transaction already in progress

#### CommitAsync
Commits the current transaction.

```csharp
Task CommitAsync(CancellationToken cancellationToken = default)
```

**Behavior:**
- Commits the transaction
- Sets transaction status to Committed
- Disposes transaction and connection
- Throws if no transaction in progress

#### RollbackAsync
Rolls back the current transaction.

```csharp
Task RollbackAsync(CancellationToken cancellationToken = default)
```

**Behavior:**
- Rolls back the transaction
- Sets transaction status to RolledBack
- Disposes transaction and connection
- Throws if no transaction in progress

#### SaveChangesAsync
Saves all changes made in this unit of work.

```csharp
Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
```

**Behavior:**
- Saves all pending changes
- Returns number of entities affected
- Infrastructure placeholder - will be implemented with actual data context

### Properties

#### TransactionStatus
Gets the current transaction status.

```csharp
TransactionStatus TransactionStatus { get; }
```

**Values:**
- `None` - No transaction active
- `InProgress` - Transaction in progress
- `Committed` - Transaction committed
- `RolledBack` - Transaction rolled back
- `Failed` - Transaction failed

#### HasActiveTransaction
Gets whether a transaction is active.

```csharp
bool HasActiveTransaction { get; }
```

**Returns:**
- `true` if transaction is in progress
- `false` otherwise

---

## TransactionStatus Enumeration

### Values

#### None
No transaction is active.

#### InProgress
Transaction is in progress and can be committed or rolled back.

#### Committed
Transaction has been successfully committed.

#### RolledBack
Transaction has been rolled back.

#### Failed
Transaction has failed (error during commit or rollback).

---

## UnitOfWork Implementation

### Constructor
```csharp
public UnitOfWork(IDbConnectionFactory connectionFactory)
```

**Parameters:**
- `connectionFactory` - Database connection factory for creating connections

### Implementation Details

#### Connection Management
- Creates connection from connection factory
- Manages connection lifecycle
- Disposes connection after transaction completes

#### Transaction Management
- Uses SQLite transactions
- Supports async operations
- Properly disposes resources

#### Error Handling
- Sets transaction status to Failed on errors
- Properly disposes resources on errors
- Re-throws exceptions to caller

---

## Usage Examples

### Basic Transaction
```csharp
public class AccountService : IAccountService
{
    private readonly IRepository<Account> _accountRepository;
    private readonly IUnitOfWork _unitOfWork;

    public AccountService(IRepository<Account> accountRepository, IUnitOfWork unitOfWork)
    {
        _accountRepository = accountRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<AccountDto> CreateAccountAsync(CreateAccountRequest request)
    {
        await _unitOfWork.BeginTransactionAsync();
        
        try
        {
            var account = new Account { /* ... */ };
            await _accountRepository.AddAsync(account);
            await _unitOfWork.SaveChangesAsync();
            await _unitOfWork.CommitAsync();
            
            return MapToDto(account);
        }
        catch
        {
            await _unitOfWork.RollbackAsync();
            throw;
        }
    }
}
```

### Multiple Operations in Transaction
```csharp
public async Task TransferFundsAsync(TransferFundsRequest request)
{
    await _unitOfWork.BeginTransactionAsync();
    
    try
    {
        var fromAccount = await _accountRepository.GetByIdAsync(request.FromAccountId);
        var toAccount = await _accountRepository.GetByIdAsync(request.ToAccountId);
        
        fromAccount.Balance -= request.Amount;
        toAccount.Balance += request.Amount;
        
        await _accountRepository.UpdateAsync(fromAccount);
        await _accountRepository.UpdateAsync(toAccount);
        
        await _unitOfWork.SaveChangesAsync();
        await _unitOfWork.CommitAsync();
    }
    catch
    {
        await _unitOfWork.RollbackAsync();
        throw;
    }
}
```

### Nested Transactions (Not Supported)
SQLite does not support nested transactions. Attempting to begin a transaction while one is in progress will throw an exception.

```csharp
// This will throw InvalidOperationException
await _unitOfWork.BeginTransactionAsync();
await _unitOfWork.BeginTransactionAsync(); // Error!
```

---

## Transaction Lifecycle

### Normal Flow
```
BeginTransactionAsync
    ↓
Perform Operations
    ↓
SaveChangesAsync
    ↓
CommitAsync
    ↓
Transaction Committed
```

### Error Flow
```
BeginTransactionAsync
    ↓
Perform Operations
    ↓
Error Occurs
    ↓
RollbackAsync
    ↓
Transaction Rolled Back
```

---

## Best Practices

### Always Use Transactions
```csharp
// Good: Use transaction for multiple operations
await _unitOfWork.BeginTransactionAsync();
try
{
    // Operations
    await _unitOfWork.CommitAsync();
}
catch
{
    await _unitOfWork.RollbackAsync();
    throw;
}
```

### Check Transaction Status
```csharp
if (_unitOfWork.HasActiveTransaction)
{
    await _unitOfWork.RollbackAsync();
}
```

### Use Using Statement for Cleanup
```csharp
using (var unitOfWork = _unitOfWork)
{
    await unitOfWork.BeginTransactionAsync();
    // Operations
    await unitOfWork.CommitAsync();
}
```

### Handle Exceptions Properly
```csharp
try
{
    await _unitOfWork.BeginTransactionAsync();
    // Operations
    await _unitOfWork.CommitAsync();
}
catch (Exception ex)
{
    await _unitOfWork.RollbackAsync();
    _logger.LogError(ex, "Transaction failed");
    throw;
}
```

---

## Anti-Patterns

### Don't Forget to Commit
```csharp
// Bad: Transaction not committed
await _unitOfWork.BeginTransactionAsync();
await _accountRepository.AddAsync(account);
// Missing CommitAsync!
```

### Don't Forget to Rollback on Error
```csharp
// Bad: No rollback on error
await _unitOfWork.BeginTransactionAsync();
try
{
    await _accountRepository.AddAsync(account);
    await _unitOfWork.CommitAsync();
}
catch
{
    // Missing RollbackAsync!
    throw;
}
```

### Don't Use Transactions for Single Operations
```csharp
// Bad: Unnecessary transaction for single operation
await _unitOfWork.BeginTransactionAsync();
await _accountRepository.GetByIdAsync(id); // Read operation doesn't need transaction
await _unitOfWork.CommitAsync();
```

---

## Integration with Repository

### Repository Context
Repositories automatically receive context via IRepositoryContext, which includes company ID, year ID, user ID, etc. This ensures that all repository operations within a transaction use the same context.

### Audit Hooks
Audit hooks are called before and after each repository operation, even within transactions. This ensures consistent audit logging.

### Logging
Repository operations are logged even within transactions, providing visibility into all data access operations.

---

## Future Enhancements

### SaveChanges Implementation
- Implement actual SaveChangesAsync with data context
- Track entity changes
- Optimize batch operations
- Add change tracking

### Distributed Transactions
- Add support for distributed transactions across multiple databases
- Add two-phase commit protocol
- Add transaction coordination service

### Transaction Isolation Levels
- Add support for different isolation levels
- Add snapshot isolation
- Add serializable isolation

### Transaction Timeouts
- Add transaction timeout configuration
- Add automatic rollback on timeout
- Add timeout monitoring

### Transaction Monitoring
- Add transaction performance metrics
- Add transaction duration tracking
- Add transaction failure monitoring

---

## SQLite Transaction Considerations

### WAL Mode
- SQLite uses Write-Ahead Logging (WAL) mode
- Allows concurrent readers and writers
- Improves performance for concurrent transactions

### Connection Pooling
- Connection factory uses connection pooling
- Reduces connection overhead
- Improves transaction performance

### Busy Timeout
- SQLite has busy timeout for concurrent access
- Configured in connection factory
- Prevents lock contention issues

---

## Testing

### Unit Testing
```csharp
[Fact]
public async Task Commit_ShouldCommitTransaction()
{
    // Arrange
    var mockConnectionFactory = new Mock<IDbConnectionFactory>();
    var unitOfWork = new UnitOfWork(mockConnectionFactory.Object);
    
    // Act
    await unitOfWork.BeginTransactionAsync();
    await unitOfWork.CommitAsync();
    
    // Assert
    Assert.Equal(TransactionStatus.Committed, unitOfWork.TransactionStatus);
}
```

### Integration Testing
```csharp
[Fact]
public async Task Transaction_ShouldRollbackOnError()
{
    // Arrange
    var unitOfWork = new UnitOfWork(connectionFactory);
    
    // Act
    await unitOfWork.BeginTransactionAsync();
    await unitOfWork.RollbackAsync();
    
    // Assert
    Assert.Equal(TransactionStatus.RolledBack, unitOfWork.TransactionStatus);
}
```

---

## Compliance

### ✅ Architecture Compliance
- Follows Clean Architecture principles
- Follows ARCHITECTURE.md guidelines
- Follows DEVELOPMENT_GUIDELINES.md standards
- No architectural boundary violations

### ✅ Phase 3 Compliance
- No business logic implemented
- No accounting logic implemented
- No voucher logic implemented
- No SQL changes
- No database schema changes
- No controller refactoring
- No frontend changes
