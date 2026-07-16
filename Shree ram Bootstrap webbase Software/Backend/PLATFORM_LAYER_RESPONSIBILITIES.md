# ERP Platform Layer Responsibilities

**Version:** 1.0  
**Last Updated:** 2026-07-07

---

## Controllers Layer (Presentation)

### Responsibilities
- Handle HTTP requests and responses
- Validate input models
- Orchestrate service calls
- Return standardized API responses
- Handle authentication/authorization at HTTP level
- Map HTTP-specific concerns (headers, cookies)

### Allowed Operations
- Receive HTTP requests
- Validate request DTOs
- Call application services
- Return ApiResponse<T> or ApiResponse
- Handle HTTP-specific errors
- Extract user context from HTTP headers/tokens

### Forbidden Operations
- Execute SQL queries
- Access database directly
- Contain business logic
- Access repositories directly
- Contain data transformation logic
- Directly reference other controllers

### Example Pattern
```csharp
[HttpGet("{id}")]
public async Task<IActionResult> GetAccount(int id)
{
    var result = await _accountService.GetAccountAsync(id);
    return Ok(ApiResponse.Ok(result));
}
```

---

## Application Layer (Services)

### Responsibilities
- Implement use cases
- Orchestrate domain operations
- Handle transaction boundaries
- Map DTOs to domain entities
- Publish events after transactions
- Coordinate multiple repositories
- Validate business rules at use case level

### Allowed Operations
- Call domain services
- Call repositories
- Manage transactions
- Map DTOs to entities
- Publish events
- Coordinate multiple operations
- Validate use case constraints

### Forbidden Operations
- Access database directly
- Contain UI logic
- Directly reference other module services
- Execute SQL queries
- Access HTTP-specific concerns

### Example Pattern
```csharp
public async Task<AccountDto> CreateAccountAsync(CreateAccountRequest request)
{
    // Validate request
    // Map to entity
    // Call repository
    // Publish event
    // Return DTO
}
```

---

## Domain Layer (Business Logic)

### Responsibilities
- Contain business entities
- Enforce business rules and invariants
- Implement domain services
- Define domain events
- Contain business calculations
- Enforce data integrity at domain level

### Allowed Operations
- Define entity behavior
- Implement business rules
- Create domain events
- Perform business calculations
- Validate entity invariants

### Forbidden Operations
- Access database directly
- Access infrastructure services
- Contain UI logic
- Access HTTP-specific concerns
- Directly reference repositories

### Example Pattern
```csharp
public class Account
{
    public void Debit(decimal amount)
    {
        if (amount <= 0)
            throw new ValidationException("Amount must be positive");
        Balance -= amount;
    }
}
```

---

## Infrastructure Layer (Data Access)

### Responsibilities
- Access database
- Execute SQL queries
- Handle data persistence
- Implement repository interfaces
- Manage database connections
- Handle data mapping to/from entities

### Allowed Operations
- Execute SQL queries
- Manage database connections
- Map database results to entities
- Implement repository interfaces
- Handle connection pooling
- Manage transactions at data level

### Forbidden Operations
- Contain business logic
- Access application services
- Access controllers
- Contain UI logic
- Directly reference other repositories

### Example Pattern
```csharp
public async Task<Account?> GetByIdAsync(int id)
{
    using var connection = _connectionFactory.CreateConnection();
    // Execute SQL
    // Map to entity
    // Return entity
}
```

---

## Platform Layer (Contexts)

### Responsibilities
- Provide global application context
- Manage user context
- Manage company context
- Manage assessment year context
- Manage permission context
- Manage environment context
- Provide configuration management

### Allowed Operations
- Store and retrieve context information
- Initialize default context values
- Clear context on logout
- Provide context to other layers

### Forbidden Operations
- Access database directly
- Contain business logic
- Access HTTP-specific concerns directly

### Example Pattern
```csharp
public class CurrentUserContext : ICurrentUserContext
{
    public string UserId { get; private set; }
    public void SetUser(string userId, string username, ...)
    {
        UserId = userId;
        // ...
    }
}
```

---

## Core Layer (Utilities)

### Responsibilities
- Provide base types (Result<T>, ApiResponse<T>)
- Define constants and error codes
- Define system events
- Provide exception types
- Provide helper methods
- Provide utility functions
- Provide guard clauses

### Allowed Operations
- Define base types
- Provide utility methods
- Define constants
- Define exceptions
- No external dependencies

### Forbidden Operations
- Access database
- Access infrastructure
- Contain business logic

### Example Pattern
```csharp
public static class Guard
{
    public static T NotNull<T>(T? value, string paramName)
    {
        if (value is null)
            throw new ArgumentNullException(paramName);
        return value;
    }
}
```

---

## Shared Layer (Cross-Cutting)

### Responsibilities
- Provide shared DTOs
- Define common enumerations
- Provide extension methods
- Define cross-cutting interfaces
- Provide common models

### Allowed Operations
- Define DTOs
- Define enums
- Provide extensions
- Define interfaces for cross-cutting concerns

### Forbidden Operations
- Contain business logic
- Access database
- Access infrastructure

### Example Pattern
```csharp
public static class StringExtensions
{
    public static string ToTitleCase(this string value)
    {
        // Implementation
    }
}
```

---

## Layer Interaction Flow

### Request Flow
```
HTTP Request
    ↓
Controller (Validate, Orchestrate)
    ↓
Application Service (Use Case, Transaction)
    ↓
Domain Service (Business Logic)
    ↓
Repository (Data Access)
    ↓
Database
```

### Response Flow
```
Database
    ↓
Repository (Map to Entity)
    ↓
Domain Service (Business Logic)
    ↓
Application Service (Map to DTO, Publish Event)
    ↓
Controller (Return ApiResponse)
    ↓
HTTP Response
```

---

## Cross-Cutting Concerns

### Logging
- **Location:** Infrastructure layer (ILogger)
- **Usage:** All layers can inject and use
- **Scope:** Application-wide

### Caching
- **Location:** Infrastructure layer (ICache)
- **Usage:** Application and Domain layers
- **Scope:** Application-wide

### Events
- **Location:** Shared layer (IEventBus)
- **Usage:** Application layer for publishing
- **Scope:** Cross-module communication

### Audit
- **Location:** Shared layer (IAuditService)
- **Usage:** Application layer
- **Scope:** All write operations

### Permissions
- **Location:** Shared layer (IPermissionService)
- **Usage:** Application and Controller layers
- **Scope:** Authorization checks

---

## Data Flow Rules

### Input Data
```
HTTP Request → Controller → DTO Validation → Service → Domain Entity
```

### Output Data
```
Domain Entity → Service → DTO → Controller → HTTP Response
```

### Database Data
```
Database → Repository → Domain Entity → Service → DTO → Controller
```

---

## Transaction Management

### Transaction Boundaries
- **Location:** Application layer (Services)
- **Implementation:** IUnitOfWork
- **Scope:** Single use case

### Transaction Flow
```
Service.BeginTransactionAsync()
    ↓
Repository Operations
    ↓
Service.CommitAsync() OR Service.RollbackAsync()
```

---

## Error Handling Flow

### Exception Flow
```
Domain Exception
    ↓
Application Service (Catch, Convert to Result)
    ↓
Controller (Return ApiResponse with errors)
    ↓
Middleware (Handle unhandled exceptions)
    ↓
HTTP Response
```

### Error Types
- **ValidationException** → 400 Bad Request
- **NotFoundException** → 404 Not Found
- **UnauthorizedException** → 401 Unauthorized
- **ForbiddenException** → 403 Forbidden
- **ConflictException** → 409 Conflict
- **Other Exceptions** → 500 Internal Server Error
