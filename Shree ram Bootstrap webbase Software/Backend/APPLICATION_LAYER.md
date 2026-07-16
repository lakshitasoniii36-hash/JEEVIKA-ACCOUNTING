# Application Layer Documentation

**Version:** 1.0  
**Last Updated:** 2026-07-07  
**Purpose:** Document the Application Layer architecture for the ERP platform

---

## Overview

The Application Layer provides the enterprise application framework that every future business service will use. It follows Clean Architecture principles with separation of concerns, dependency injection, and extensibility.

---

## Architecture Principles

### Core Principles
- **Single Responsibility:** Each service handles one business domain
- **Interface Segregation:** Separate command and query handlers
- **Dependency Inversion:** Services depend on abstractions, not concrete implementations
- **Open/Closed:** Open for extension through behaviors, closed for modification
- **Context Injection:** Services automatically receive context, never determine it manually

### Application Layer Rules
- **Business Logic Only:** Application layer contains business logic
- **No Data Access:** Services use repositories, never access data directly
- **No HTTP:** Services never make HTTP calls
- **No Controller Logic:** Services are independent of controllers
- **No UI Concerns:** Services are independent of UI

---

## Application Service Base

### IApplicationService
Base interface for all application services.

**Properties:**
- `ServiceName` - Service name for logging and identification

### ApplicationServiceBase
Base class for all application services with common functionality.

**Dependencies:**
- `IContextProvider` - Context provider for context access
- `IUnitOfWork` - Unit of work for transaction management
- `IEventBus` - Event bus for event publishing
- `IAuditService` - Audit service for audit logging

**Properties:**
- `ServiceName` - Service name
- `CurrentCompanyId` - Current company ID from context
- `CurrentYearId` - Current assessment year ID from context
- `CurrentUserId` - Current user ID from context
- `CurrentBranch` - Current branch from context

**Methods:**
- `BeginTransactionAsync()` - Begin a transaction
- `CommitTransactionAsync()` - Commit the current transaction
- `RollbackTransactionAsync()` - Rollback the current transaction
- `SaveChangesAsync()` - Save all changes
- `PublishEventAsync<TEvent>(event)` - Publish an event
- `LogAuditAsync(action, entity, entityId, details)` - Log an audit entry
- `ExecuteInTransactionAsync(operation)` - Execute operation within transaction

**Usage:**
```csharp
public class AccountService : ApplicationServiceBase, IAccountService
{
    public AccountService(
        IContextProvider contextProvider,
        IUnitOfWork unitOfWork,
        IEventBus eventBus,
        IAuditService auditService) : base(contextProvider, unitOfWork, eventBus, auditService)
    {
    }

    public async Task<ServiceResult<AccountDto>> CreateAccountAsync(CreateAccountRequest request)
    {
        return await ExecuteInTransactionAsync(async () =>
        {
            // Business logic here
            return _responseFactory.Success(accountDto);
        });
    }
}
```

---

## Service Result

### ServiceResult<T>
Standard service result for application operations with return value.

**Properties:**
- `IsSuccess` - Whether the operation was successful
- `Data` - Result data
- `ErrorMessage` - Error message
- `ErrorCode` - Error code
- `ValidationErrors` - Validation errors
- `Timestamp` - Timestamp

**Static Methods:**
- `Success(data)` - Create successful result
- `Failure(errorMessage, errorCode)` - Create failed result
- `ValidationFailure(validationErrors)` - Create validation failure result

### ServiceResult
Standard service result for operations without return value.

**Properties:**
- `IsSuccess` - Whether the operation was successful
- `ErrorMessage` - Error message
- `ErrorCode` - Error code
- `ValidationErrors` - Validation errors
- `Timestamp` - Timestamp

**Static Methods:**
- `Success()` - Create successful result
- `Failure(errorMessage, errorCode)` - Create failed result
- `ValidationFailure(validationErrors)` - Create validation failure result

---

## Command Infrastructure

### ICommand
Base interface for commands (write operations).

**Properties:**
- `CommandId` - Command ID for tracking

### ICommand<TResult>
Command interface with return value.

### CommandBase
Base class for commands.

### CommandBase<TResult>
Base class for commands with return value.

### ICommandHandler<TCommand>
Base interface for command handlers.

**Methods:**
- `HandleAsync(command, cancellationToken)` - Handle the command

### ICommandHandler<TCommand, TResult>
Command handler interface with return value.

**Methods:**
- `HandleAsync(command, cancellationToken)` - Handle the command

**Usage:**
```csharp
public class CreateMemberCommand : CommandBase<MemberDto>
{
    public string Name { get; set; }
    public string Email { get; set; }
}

public class CreateMemberCommandHandler : ICommandHandler<CreateMemberCommand, MemberDto>
{
    public async Task<MemberDto> HandleAsync(CreateMemberCommand command, CancellationToken cancellationToken = default)
    {
        // Handle command
        return memberDto;
    }
}
```

---

## Query Infrastructure

### IQuery
Base interface for queries (read operations).

**Properties:**
- `QueryId` - Query ID for tracking

### IQuery<TResult>
Query interface with return value.

### QueryBase
Base class for queries.

### QueryBase<TResult>
Base class for queries with return value.

### IQueryHandler<TQuery, TResult>
Base interface for query handlers.

**Methods:**
- `HandleAsync(query, cancellationToken)` - Handle the query

**Usage:**
```csharp
public class GetMemberQuery : QueryBase<MemberDto>
{
    public int MemberId { get; set; }
}

public class GetMemberQueryHandler : IQueryHandler<GetMemberQuery, MemberDto>
{
    public async Task<MemberDto> HandleAsync(GetMemberQuery query, CancellationToken cancellationToken = default)
    {
        // Handle query
        return memberDto;
    }
}
```

---

## Pipeline Behaviors

### IBehavior<TRequest, TResponse>
Base interface for pipeline behaviors.

**Methods:**
- `HandleAsync(request, next, cancellationToken)` - Process request through behavior pipeline

### ValidationBehavior<TRequest, TResponse>
Validates requests before processing.

### LoggingBehavior<TRequest, TResponse>
Logs request/response for observability.

### TransactionBehavior<TRequest, TResponse>
Wraps operations in transactions.

### PerformanceBehavior<TRequest, TResponse>
Measures execution time for performance monitoring.

### AuthorizationBehavior<TRequest, TResponse>
Checks permissions before processing.

### AuditBehavior<TRequest, TResponse>
Logs audit trails for compliance.

### ExceptionBehavior<TRequest, TResponse>
Handles exceptions gracefully.

---

## Mapping Infrastructure

### IMapper
Interface for object mapping.

**Methods:**
- `Map<TSource, TDestination>(source)` - Map source to destination
- `MapCollection<TSource, TDestination>(source)` - Map source collection to destination collection

### DefaultMapper
Default mapper implementation (placeholder).

---

## Validation Framework

### IValidator<T>
Interface for validating objects.

**Methods:**
- `Validate(obj)` - Validate the object

### ValidationResult
Validation result.

**Properties:**
- `IsValid` - Whether validation was successful
- `Errors` - Validation errors

**Static Methods:**
- `Success()` - Create successful validation result
- `Failure(errors)` - Create failed validation result

**Methods:**
- `AddError(propertyName, errorMessage)` - Add an error

### ValidatorBase<T>
Abstract validator base class.

**Methods:**
- `ValidateInternal(obj, result)` - Internal validation logic

---

## Response Factory

### IResponseFactory
Interface for creating standardized responses.

**Methods:**
- `Success<T>(data)` - Create successful response with data
- `Success()` - Create successful response without data
- `Failure(errorMessage, errorCode)` - Create failed response
- `Failure<T>(errorMessage, errorCode)` - Create failed response with data
- `ValidationFailure(validationErrors)` - Create validation failure response
- `ValidationFailure<T>(validationErrors)` - Create validation failure response with data

### ResponseFactory
Default response factory implementation.

---

## Event Publishing

### IApplicationEvent
Base interface for application events.

**Properties:**
- `EventId` - Event ID
- `OccurredAt` - Event timestamp
- `EventType` - Event type

### ApplicationEventBase
Base class for application events.

### IEventPublisher
Interface for event publisher.

**Methods:**
- `PublishAsync<TEvent>(event)` - Publish an event
- `PublishRangeAsync<TEvent>(events)` - Publish multiple events

### DefaultEventPublisher
Default event publisher implementation (placeholder).

### IEventHandler<TEvent>
Interface for event handler.

**Methods:**
- `HandleAsync(event, cancellationToken)` - Handle the event

---

## Architecture Benefits

### Separation of Concerns
- Services handle business logic only
- Repositories handle data access
- Controllers handle HTTP concerns
- Context is automatically injected

### Extensibility
- Pipeline behaviors for cross-cutting concerns
- Event publishing for decoupled communication
- Validation framework for data validation
- Mapping infrastructure for object transformation

### Testability
- All components are interface-based
- Dependencies are injected
- Mock-friendly architecture
- Unit test ready

### Performance
- Pipeline behaviors for optimization
- Async operations throughout
- Transaction management
- Event-driven architecture

### Maintainability
- Clear separation of layers
- Consistent patterns
- Documentation included
- Type-safe generics

---

## Future Enhancements

### Behavior Implementation
- Implement actual validation logic in ValidationBehavior
- Implement actual logging in LoggingBehavior
- Implement actual transaction wrapping in TransactionBehavior
- Implement actual performance metrics in PerformanceBehavior
- Implement actual authorization checks in AuthorizationBehavior
- Implement actual audit logging in AuditBehavior
- Implement actual exception handling in ExceptionBehavior

### Mapping Implementation
- Integrate AutoMapper or similar
- Add custom mapping profiles
- Add collection mapping optimization
- Add nested object mapping

### Validation Implementation
- Add FluentValidation integration
- Add custom validation rules
- Add async validation support
- Add validation rule composition

### Event Implementation
- Implement actual event bus integration
- Add event persistence
- Add event replay support
- Add event versioning

---

## Compliance

### ✅ Architecture Compliance
- Follows Clean Architecture principles
- Follows ARCHITECTURE.md guidelines
- Follows DEVELOPMENT_GUIDELINES.md standards
- No architectural boundary violations

### ✅ Phase 4 Compliance
- No business logic implemented
- No accounting logic implemented
- No voucher logic implemented
- No SQL changes
- No database schema changes
- No controller refactoring
- No frontend changes
