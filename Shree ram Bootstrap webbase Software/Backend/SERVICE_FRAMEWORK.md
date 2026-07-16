# Service Framework Documentation

**Version:** 1.0  
**Last Updated:** 2026-07-07  
**Purpose:** Document the Service Framework for the ERP platform

---

## Overview

The Service Framework provides the enterprise service architecture that every future business service will use. It follows Clean Architecture principles with CQRS pattern, dependency injection, and extensibility.

---

## Architecture Principles

### Core Principles
- **CQRS Pattern:** Separate command and query responsibilities
- **Single Responsibility:** Each service handles one business domain
- **Interface Segregation:** Separate interfaces for different concerns
- **Dependency Inversion:** Services depend on abstractions, not concrete implementations
- **Open/Closed:** Open for extension through behaviors, closed for modification

### Service Layer Rules
- **Business Logic Only:** Services contain business logic
- **No Data Access:** Services use repositories, never access data directly
- **No HTTP:** Services never make HTTP calls
- **No Controller Logic:** Services are independent of controllers
- **No UI Concerns:** Services are independent of UI

---

## Service Base Class

### ApplicationServiceBase
Base class for all application services with common functionality.

**Responsibilities:**
- Validation
- Logging
- Context Access
- Transactions
- Events
- Response creation
- Exception handling

**Dependencies:**
- `IContextProvider` - Context provider for context access
- `IUnitOfWork` - Unit of work for transaction management
- `IEventBus` - Event bus for event publishing
- `IAuditService` - Audit service for audit logging

**Context Access:**
- `CurrentCompanyId` - Current company ID from context
- `CurrentYearId` - Current assessment year ID from context
- `CurrentUserId` - Current user ID from context
- `CurrentBranch` - Current branch from context

**Transaction Management:**
- `BeginTransactionAsync()` - Begin a transaction
- `CommitTransactionAsync()` - Commit the current transaction
- `RollbackTransactionAsync()` - Rollback the current transaction
- `SaveChangesAsync()` - Save all changes
- `ExecuteInTransactionAsync(operation)` - Execute operation within transaction

**Event Publishing:**
- `PublishEventAsync<TEvent>(event)` - Publish an event

**Audit Logging:**
- `LogAuditAsync(action, entity, entityId, details)` - Log an audit entry

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

## Command Pattern

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

**Usage Example:**
```csharp
public class CreateMemberCommand : CommandBase<MemberDto>
{
    public string Name { get; set; }
    public string Email { get; set; }
}

public class CreateMemberCommandHandler : ICommandHandler<CreateMemberCommand, MemberDto>
{
    private readonly IMemberRepository _repository;
    private readonly IMapper _mapper;

    public CreateMemberCommandHandler(IMemberRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<MemberDto> HandleAsync(CreateMemberCommand command, CancellationToken cancellationToken = default)
    {
        var member = _mapper.Map<CreateMemberCommand, Member>(command);
        await _repository.AddAsync(member);
        return _mapper.Map<Member, MemberDto>(member);
    }
}
```

---

## Query Pattern

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

**Usage Example:**
```csharp
public class GetMemberQuery : QueryBase<MemberDto>
{
    public int MemberId { get; set; }
}

public class GetMemberQueryHandler : IQueryHandler<GetMemberQuery, MemberDto>
{
    private readonly IMemberRepository _repository;
    private readonly IMapper _mapper;

    public GetMemberQueryHandler(IMemberRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<MemberDto> HandleAsync(GetMemberQuery query, CancellationToken cancellationToken = default)
    {
        var member = await _repository.GetByIdAsync(query.MemberId);
        return _mapper.Map<Member, MemberDto>(member);
    }
}
```

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

**Usage Example:**
```csharp
public class AccountService : ApplicationServiceBase
{
    private readonly IResponseFactory _responseFactory;

    public async Task<ServiceResult<AccountDto>> CreateAccountAsync(CreateAccountRequest request)
    {
        // Business logic
        return _responseFactory.Success(accountDto);
    }
}
```

---

## Service Lifecycle

### Scoped Services
Services are typically scoped to the HTTP request lifetime.

**Registration:**
```csharp
services.AddScoped<IAccountService, AccountService>();
```

### Dependencies
Services depend on:
- Repositories (scoped)
- Context provider (singleton)
- Unit of work (scoped)
- Event bus (singleton)
- Audit service (singleton)
- Response factory (singleton)
- Mapper (singleton)

---

## Service Best Practices

### Use Transactions for Write Operations
```csharp
public async Task<ServiceResult<AccountDto>> CreateAccountAsync(CreateAccountRequest request)
{
    return await ExecuteInTransactionAsync(async () =>
    {
        // Business logic
        return _responseFactory.Success(accountDto);
    });
}
```

### Use Commands for Write Operations
```csharp
public async Task<ServiceResult<MemberDto>> CreateMemberAsync(CreateMemberRequest request)
{
    var command = new CreateMemberCommand { Name = request.Name, Email = request.Email };
    var handler = _serviceProvider.GetRequiredService<ICommandHandler<CreateMemberCommand, MemberDto>>();
    var result = await handler.HandleAsync(command);
    return _responseFactory.Success(result);
}
```

### Use Queries for Read Operations
```csharp
public async Task<ServiceResult<MemberDto>> GetMemberAsync(int memberId)
{
    var query = new GetMemberQuery { MemberId = memberId };
    var handler = _serviceProvider.GetRequiredService<IQueryHandler<GetMemberQuery, MemberDto>>();
    var result = await handler.HandleAsync(query);
    return _responseFactory.Success(result);
}
```

### Validate Input
```csharp
public async Task<ServiceResult<AccountDto>> CreateAccountAsync(CreateAccountRequest request)
{
    var validator = new CreateAccountRequestValidator();
    var validationResult = validator.Validate(request);
    
    if (!validationResult.IsValid)
    {
        return _responseFactory.ValidationFailure<AccountDto>(validationResult.Errors);
    }
    
    // Business logic
}
```

### Log Audit Trail
```csharp
public async Task<ServiceResult<AccountDto>> CreateAccountAsync(CreateAccountRequest request)
{
    await LogAuditAsync("CREATE", "Account", null, $"Creating account: {request.Name}");
    
    // Business logic
    
    await LogAuditAsync("CREATED", "Account", account.Id, $"Account created: {account.Name}");
    return _responseFactory.Success(accountDto);
}
```

### Publish Events
```csharp
public async Task<ServiceResult<AccountDto>> CreateAccountAsync(CreateAccountRequest request)
{
    // Business logic
    
    var @event = new AccountCreatedEvent { AccountId = account.Id, Name = account.Name };
    await PublishEventAsync(@event);
    
    return _responseFactory.Success(accountDto);
}
```

---

## Service Anti-Patterns

### Don't Access Data Directly
```csharp
// Bad: Direct data access
public async Task<ServiceResult<AccountDto>> GetAccountAsync(int id)
{
    using var connection = new SqlConnection(_connectionString);
    var account = await connection.QueryFirstOrDefaultAsync<Account>("SELECT * FROM Accounts WHERE Id = @Id", new { Id = id });
    return _responseFactory.Success(accountDto);
}

// Good: Use repository
public async Task<ServiceResult<AccountDto>> GetAccountAsync(int id)
{
    var account = await _accountRepository.GetByIdAsync(id);
    return _responseFactory.Success(accountDto);
}
```

### Don't Make HTTP Calls
```csharp
// Bad: HTTP call in service
public async Task<ServiceResult<MemberDto>> GetMemberAsync(int id)
{
    using var httpClient = new HttpClient();
    var response = await httpClient.GetAsync($"https://api.example.com/members/{id}");
    return _responseFactory.Success(memberDto);
}

// Good: Use service for external calls
public async Task<ServiceResult<MemberDto>> GetMemberAsync(int id)
{
    var member = await _memberRepository.GetByIdAsync(id);
    return _responseFactory.Success(memberDto);
}
```

### Don't Use Transactions for Read Operations
```csharp
// Bad: Transaction for read operation
public async Task<ServiceResult<AccountDto>> GetAccountAsync(int id)
{
    await BeginTransactionAsync();
    var account = await _accountRepository.GetByIdAsync(id);
    await CommitTransactionAsync();
    return _responseFactory.Success(accountDto);
}

// Good: No transaction for read operation
public async Task<ServiceResult<AccountDto>> GetAccountAsync(int id)
{
    var account = await _accountRepository.GetByIdAsync(id);
    return _responseFactory.Success(accountDto);
}
```

---

## Service Testing

### Unit Testing
```csharp
[Fact]
public async Task CreateAccountAsync_ShouldReturnSuccess()
{
    // Arrange
    var mockRepository = new Mock<IAccountRepository>();
    var mockUnitOfWork = new Mock<IUnitOfWork>();
    var mockContextProvider = new Mock<IContextProvider>();
    var mockEventBus = new Mock<IEventBus>();
    var mockAuditService = new Mock<IAuditService>();
    var responseFactory = new ResponseFactory();
    
    var service = new AccountService(
        mockContextProvider.Object,
        mockUnitOfWork.Object,
        mockEventBus.Object,
        mockAuditService.Object);
    
    var request = new CreateAccountRequest { Name = "Test Account" };
    
    // Act
    var result = await service.CreateAccountAsync(request);
    
    // Assert
    Assert.True(result.IsSuccess);
}
```

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
