# Repository Architecture Documentation

**Version:** 1.0  
**Last Updated:** 2026-07-07  
**Purpose:** Document the repository infrastructure for the ERP platform

---

## Overview

The Repository Architecture provides a robust, enterprise-grade data access layer that every future module will use. It follows Clean Architecture principles with separation of concerns, dependency injection, and extensibility.

---

## Architecture Principles

### Core Principles
- **Single Responsibility:** Each repository handles data access for one entity type
- **Interface Segregation:** Separate read and write interfaces for different use cases
- **Dependency Inversion:** Repositories depend on abstractions, not concrete implementations
- **Open/Closed:** Open for extension through hooks, closed for modification
- **Context Injection:** Repositories automatically receive context, never determine it manually

### Data Access Rules
- **Only Data Access:** Repositories never perform business logic
- **No HTTP:** Repositories never make HTTP calls
- **No Controller Logic:** Repositories are independent of controllers
- **No UI Concerns:** Repositories are independent of UI
- **No Business Validation:** Repositories only perform data access validation

---

## Repository Interfaces

### IRepository<TEntity>
Combined repository interface inheriting from read and write repositories.

```csharp
public interface IRepository<TEntity> : IReadRepository<TEntity>, IWriteRepository<TEntity> 
    where TEntity : class
{
}
```

### IReadRepository<TEntity>
Read-only repository interface for querying entities.

**Methods:**
- `GetByIdAsync(id)` - Get entity by ID
- `GetAllAsync()` - Get all entities
- `FindAsync(specification)` - Find entities matching specification
- `FirstOrDefaultAsync(specification)` - Get first matching entity
- `AnyAsync(specification)` - Check if any entity matches
- `CountAsync(specification)` - Count matching entities
- `GetPagedAsync(query)` - Get paged results
- `ProjectAsync<TProjection>(specification)` - Project to different type

### IWriteRepository<TEntity>
Write-only repository interface for modifying entities.

**Methods:**
- `AddAsync(entity)` - Add new entity
- `AddRangeAsync(entities)` - Add multiple entities
- `UpdateAsync(entity)` - Update existing entity
- `UpdateRangeAsync(entities)` - Update multiple entities
- `DeleteAsync(entity)` - Delete entity
- `DeleteAsync(id)` - Delete entity by ID
- `DeleteRangeAsync(entities)` - Delete multiple entities

---

## Base Repository

### BaseRepository<TEntity>
Abstract base class providing common CRUD operations with audit hooks and logging.

**Features:**
- Automatic context injection via IRepositoryContext
- Audit hooks for Before/After Insert/Update/Delete
- Repository logging for all operations
- Placeholder implementations for future data access

**Usage:**
```csharp
public class AccountRepository : BaseRepository<Account>
{
    public AccountRepository(IRepositoryContext context) : base(context)
    {
    }

    // Override methods with actual data access implementation
}
```

---

## Repository Context

### IRepositoryContext
Interface for automatic context injection.

**Properties:**
- `UserContext` - Current user context
- `CompanyContext` - Current company context
- `AssessmentYearContext` - Current assessment year context
- `DatabaseContext` - Current database context
- `EnvironmentContext` - Current environment context
- `CurrentCompanyId` - Current company ID
- `CurrentYearId` - Current assessment year ID
- `CurrentUserId` - Current user ID
- `CurrentBranch` - Current branch

### RepositoryContext
Implementation that automatically injects context from ApplicationContextManager.

**Benefits:**
- Repositories never determine context manually
- Context is consistent across all repositories
- Context is automatically available for filtering
- Supports multi-company and multi-year scenarios

---

## Repository Factory

### IRepositoryFactory
Factory interface for creating repository instances.

**Methods:**
- `CreateRepository<TEntity, TRepository>()` - Create specific repository type
- `CreateRepository<TEntity>()` - Create default repository type

### RepositoryFactory
Implementation using service provider for dependency injection.

---

## Repository Registry

### IRepositoryRegistry
Registry for tracking registered repositories.

**Methods:**
- `Register<TEntity, TRepository>()` - Register repository type
- `GetRepositoryType(entityType)` - Get repository type for entity
- `IsRegistered(entityType)` - Check if repository is registered
- `GetRegisteredEntityTypes()` - Get all registered entity types

### RepositoryRegistry
Implementation using dictionary for type mapping.

---

## Repository Resolver

### IRepositoryResolver
Resolver for resolving repository instances.

**Methods:**
- `Resolve<TEntity>()` - Resolve repository for entity type
- `Resolve(entityType)` - Resolve repository for entity type (non-generic)

### RepositoryResolver
Implementation using factory and registry for resolution.

---

## Unit of Work

### IUnitOfWork
Interface for transaction management.

**Methods:**
- `BeginTransactionAsync()` - Begin new transaction
- `CommitAsync()` - Commit transaction
- `RollbackAsync()` - Rollback transaction
- `SaveChangesAsync()` - Save all changes

**Properties:**
- `TransactionStatus` - Current transaction status
- `HasActiveTransaction` - Whether transaction is active

### TransactionStatus
- `None` - No transaction active
- `InProgress` - Transaction in progress
- `Committed` - Transaction committed
- `RolledBack` - Transaction rolled back
- `Failed` - Transaction failed

### UnitOfWork
Implementation using SQLite connection and transaction.

---

## Query Infrastructure

### Query<TEntity>
Query object for filtering, sorting, searching, and pagination.

**Properties:**
- `Filter` - Filter criteria
- `Sort` - Sort criteria
- `Pagination` - Pagination criteria
- `Search` - Search criteria
- `Includes` - Navigation properties to include

### FilterCriteria
- `Property` - Property name to filter on
- `Operation` - Filter operation (Equal, NotEqual, GreaterThan, etc.)
- `Value` - Filter value

### SortCriteria
- `Property` - Property name to sort on
- `Direction` - Sort direction (Ascending, Descending)

### PaginationCriteria
- `PageNumber` - Page number (1-based)
- `PageSize` - Page size

### SearchCriteria
- `Term` - Search term
- `Properties` - Properties to search in

### PagedResult<T>
Paged result wrapper with pagination metadata.

**Properties:**
- `Items` - Items in current page
- `TotalCount` - Total number of items
- `PageNumber` - Current page number
- `PageSize` - Page size
- `TotalPages` - Total number of pages
- `HasPreviousPage` - Whether there is a previous page
- `HasNextPage` - Whether there is a next page

---

## Specification Pattern

### ISpecification<TEntity>
Specification interface for encapsulating query logic.

**Properties:**
- `Criteria` - Filter expression
- `Includes` - Include expressions (navigation properties)
- `IncludeStrings` - Include strings (navigation properties as strings)
- `OrderBy` - Order by expression
- `OrderByDescending` - Order by descending expression
- `GroupBy` - Group by expression
- `Pagination` - Pagination (skip and take)
- `AsNoTracking` - Whether tracking is disabled

### BaseSpecification<TEntity>
Base specification with common functionality.

**Methods:**
- `AddCriteria(criteria)` - Add filter criteria
- `AddInclude(includeExpression)` - Add include expression
- `AddInclude(includeString)` - Add include string
- `ApplyOrderBy(orderByExpression)` - Apply order by ascending
- `ApplyOrderByDescending(orderByDescendingExpression)` - Apply order by descending
- `ApplyGroupBy(groupByExpression)` - Apply group by
- `ApplyPaging(skip, take)` - Apply pagination
- `DisableTracking()` - Disable change tracking

---

## Audit Hooks

### IRepositoryAuditHooks<TEntity>
Interface for audit extensibility points.

**Methods:**
- `BeforeInsertAsync(entity)` - Called before insert
- `AfterInsertAsync(entity)` - Called after insert
- `BeforeUpdateAsync(entity)` - Called before update
- `AfterUpdateAsync(entity)` - Called after update
- `BeforeDeleteAsync(entity)` - Called before delete
- `AfterDeleteAsync(entity)` - Called after delete

### DefaultRepositoryAuditHooks<TEntity>
Default no-op implementation.

**Usage:**
```csharp
public class CustomAuditHooks<TEntity> : IRepositoryAuditHooks<TEntity>
{
    public async Task BeforeInsertAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        // Custom audit logic
        await Task.CompletedTask;
    }
}
```

---

## Soft Delete

### ISoftDelete
Interface for entities that support soft deletion.

**Properties:**
- `IsDeleted` - Whether the entity is deleted
- `DeletedAt` - Deletion date
- `DeletedBy` - ID of user who deleted the entity

### ISoftDeleteRepository<TEntity>
Soft delete repository interface.

**Methods:**
- `SoftDeleteAsync(entity)` - Soft delete entity
- `RestoreAsync(entity)` - Restore soft deleted entity
- `PermanentDeleteAsync(entity)` - Permanently delete entity

---

## Repository Caching

### IRepositoryCache
Interface for caching repository operations.

**Methods:**
- `GetAsync<T>(key)` - Get cached value
- `SetAsync<T>(key, value, expiration)` - Set cached value
- `RemoveAsync(key)` - Remove cached value
- `RemoveByPatternAsync(pattern)` - Remove cached values by pattern
- `ClearAsync()` - Clear all cached values

### RepositoryCacheConfiguration
Configuration for repository caching.

**Properties:**
- `IsEnabled` - Whether caching is enabled
- `DefaultExpiration` - Default cache expiration
- `KeyPrefix` - Cache key prefix
- `IncludeCompanyContext` - Include company context in cache key
- `IncludeYearContext` - Include year context in cache key
- `IncludeUserContext` - Include user context in cache key

---

## Repository Logging

### IRepositoryLogger
Interface for logging repository operations.

**Methods:**
- `LogOperationAsync(operation, entityType, entityId, details)` - Log operation
- `LogErrorAsync(operation, entityType, exception)` - Log error

### RepositoryOperation
Operation types:
- `Read` - Read operation
- `Insert` - Insert operation
- `Update` - Update operation
- `Delete` - Delete operation
- `Transaction` - Transaction operation
- `Cache` - Cache operation

### DefaultRepositoryLogger
Default no-op implementation.

---

## Dependency Injection

### Registration
```csharp
services.AddRepositoryInfrastructure();
services.AddScopedRepository<Account, AccountRepository>();
services.AddScopedRepository<Member, MemberRepository>();
```

### Service Lifetimes
- **Singleton:** IRepositoryContext, IRepositoryFactory, IRepositoryRegistry, IRepositoryLogger, RepositoryCacheConfiguration
- **Scoped:** IUnitOfWork, IRepositoryResolver
- **Transient:** IRepositoryAuditHooks<TEntity>

### Extension Methods
- `AddRepositoryInfrastructure()` - Register repository infrastructure
- `AddRepository<TEntity, TRepository>(lifetime)` - Register repository with custom lifetime
- `AddScopedRepository<TEntity, TRepository>()` - Register scoped repository
- `AddTransientRepository<TEntity, TRepository>()` - Register transient repository
- `AddSingletonRepository<TEntity, TRepository>()` - Register singleton repository

---

## Repository Usage Examples

### Basic Repository Usage
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

### Specification Usage
```csharp
public class ActiveAccountSpecification : BaseSpecification<Account>
{
    public ActiveAccountSpecification()
    {
        AddCriteria(a => a.IsActive);
        ApplyOrderBy(a => a.AccountName);
    }
}

var accounts = await _accountRepository.FindAsync(new ActiveAccountSpecification());
```

### Query Usage
```csharp
var query = new Query<Account>
{
    Filter = new FilterCriteria { Property = "IsActive", Operation = FilterOperation.Equal, Value = true },
    Sort = new SortCriteria { Property = "AccountName", Direction = SortDirection.Ascending },
    Pagination = new PaginationCriteria { PageNumber = 1, PageSize = 20 }
};

var pagedResult = await _accountRepository.GetPagedAsync(query);
```

---

## Architecture Benefits

### Separation of Concerns
- Repositories handle only data access
- Business logic remains in services
- Controllers remain thin
- Context is automatically injected

### Extensibility
- Audit hooks for custom logic
- Specification pattern for complex queries
- Caching interface for performance
- Logging interface for observability

### Testability
- All components are interface-based
- Dependencies are injected
- Mock-friendly architecture
- Unit test ready

### Performance
- Caching infrastructure ready
- Query optimization support
- Connection pooling support
- Async operations throughout

### Maintainability
- Clear separation of layers
- Consistent patterns
- Documentation included
- Type-safe generics

---

## Future Enhancements

### Data Access Implementation
- Implement actual SQLite data access in BaseRepository
- Add Dapper or Entity Framework integration
- Add connection pooling optimization
- Add query performance monitoring

### Advanced Features
- Add bulk operations
- Add stored procedure support
- Add database view support
- Add complex query builder

### Performance
- Implement actual caching
- Add query result caching
- Add connection pool monitoring
- Add performance metrics

### Observability
- Implement actual logging
- Add query performance logging
- Add error tracking
- Add metrics collection

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
