# ERP Platform Coding Standards

**Version:** 1.0  
**Last Updated:** 2026-07-07  
**Purpose:** Define coding standards for the ERP Platform Foundation

---

## Core Principles

### 1. Controllers Never Contain SQL
- **Rule:** Controllers must NOT directly execute SQL queries
- **Reason:** Business logic belongs in services, database access belongs in repositories
- **Correct:** Controller → Service → Repository → Database
- **Incorrect:** Controller → Database

### 2. Repositories Only Access Database
- **Rule:** Repository layer is the ONLY layer that accesses the database
- **Reason:** Maintains separation of concerns, enables testing
- **Correct:** Repository uses IDbConnectionFactory
- **Incorrect:** Service or Controller creates database connections

### 3. Services Contain Business Logic
- **Rule:** Application services contain business logic and orchestration
- **Reason:** Centralizes business rules, enables reuse
- **Correct:** Service implements use cases, validates business rules
- **Incorrect:** Controller contains business logic

### 4. Domain Contains Accounting Rules
- **Rule:** Domain layer contains core business rules and entities
- **Reason:** Ensures business rules are enforced at the domain level
- **Correct:** Domain entities enforce invariants, domain services implement business calculations
- **Incorrect:** Business rules scattered across controllers

### 5. Controllers Orchestrate Only
- **Rule:** Controllers orchestrate requests, delegate to services
- **Reason:** Controllers should be thin, focused on HTTP concerns
- **Correct:** Controller receives request, calls service, returns response
- **Incorrect:** Controller contains business logic or data access

### 6. No Module Direct References
- **Rule:** Modules must NOT directly reference other business modules
- **Reason:** Prevents tight coupling, enables independent deployment
- **Correct:** Module A communicates with Module B via events
- **Incorrect:** Module A directly calls Module B services

### 7. Use Dependency Injection Everywhere
- **Rule:** All dependencies must be injected via constructor
- **Reason:** Enables testing, loose coupling, lifecycle management
- **Correct:** Constructor injection with interfaces
- **Incorrect:** Manual instantiation or service locator pattern

---

## Layer Responsibilities

### Controllers (Presentation Layer)
- Handle HTTP requests/responses
- Validate input models
- Orchestrate service calls
- Return standardized API responses
- **DO NOT:** Execute SQL, contain business logic, access database directly

### Services (Application Layer)
- Implement use cases
- Orchestrate domain operations
- Handle transaction boundaries
- Map DTOs to domain entities
- Publish events after transactions
- **DO NOT:** Access database directly, contain UI logic

### Domain (Domain Layer)
- Contain business entities
- Enforce business rules
- Implement domain services
- Define domain events
- **DO NOT:** Access infrastructure, contain UI logic

### Repositories (Infrastructure Layer)
- Access database
- Execute queries
- Handle data persistence
- **DO NOT:** Contain business logic, access other services

---

## Naming Conventions

### Folders and Files
- **Folders:** PascalCase (e.g., `Controllers`, `Services`, `Repositories`)
- **Files:** PascalCase (e.g., `AccountController.cs`, `AccountService.cs`)
- **Namespaces:** Match folder structure (e.g., `Backend.Controllers`)

### Classes and Interfaces
- **Classes:** PascalCase (e.g., `AccountService`, `SqliteConnectionFactory`)
- **Interfaces:** PascalCase with 'I' prefix (e.g., `IAccountService`, `IDbConnectionFactory`)
- **Abstract Classes:** PascalCase (e.g., `BaseRepository`)

### Methods and Properties
- **Methods:** PascalCase (e.g., `GetAccountById`, `CreateAccount`)
- **Properties:** PascalCase (e.g., `AccountId`, `AccountName`)
- **Private Fields:** camelCase with underscore prefix (e.g., `_accountId`, `_connectionFactory`)

### Constants and Enums
- **Constants:** PascalCase (e.g., `MaxRetries`, `DefaultTimeout`)
- **Enums:** PascalCase (e.g., `AccountType`, `VoucherType`)
- **Enum Values:** PascalCase (e.g., `AccountType.Asset`, `VoucherType.Receipt`)

---

## Dependency Rules

### Allowed Dependencies
- **Controllers** → Services, DTOs, Core
- **Services** → Domain, Repositories, Core, Shared
- **Domain** → Core, Shared
- **Repositories** → Infrastructure, Core, Shared
- **Infrastructure** → Core, Shared

### Forbidden Dependencies
- **Controllers** → Repositories, Domain, Infrastructure
- **Services** → Controllers
- **Domain** → Infrastructure, Repositories
- **Repositories** → Services, Controllers

---

## Error Handling

### Standard Pattern
```csharp
try
{
    var result = await _service.ExecuteAsync(request);
    return Ok(ApiResponse.Ok(result));
}
catch (ValidationException ex)
{
    return BadRequest(ApiResponse.Fail(ex.Errors));
}
catch (NotFoundException ex)
{
    return NotFound(ApiResponse.Fail(ex.Message));
}
```

### Exception Types
- `ValidationException` - Validation failures
- `NotFoundException` - Resource not found
- `UnauthorizedException` - Authentication failures
- `ForbiddenException` - Authorization failures
- `ConflictException` - Duplicate/conflict scenarios

---

## Async/Await Guidelines

### When to Use Async
- All I/O operations (database, network, file)
- Service method calls
- Repository operations

### When Sync is Acceptable
- Simple in-memory operations
- Calculations
- Data transformations

### Best Practices
- Always use `async`/`await` for async operations
- Avoid `async void` (use `async Task` instead)
- Configure `await` appropriately (use `ConfigureAwait(false)` in library code)

---

## API Response Standards

### Standard Response Format
```csharp
{
    "success": true,
    "message": "Operation successful",
    "data": { ... },
    "errors": [],
    "timestamp": "2026-07-07T00:00:00Z",
    "correlationId": "guid"
}
```

### Response Methods
- `ApiResponse.Ok(data)` - Success response
- `ApiResponse.Fail(error)` - Failure response
- `ApiResponse.Fail(errors)` - Failure with multiple errors

---

## Database Access Rules

### Connection Management
- Use `IDbConnectionFactory` for all connections
- Never create connections manually
- Connections are pooled and managed by factory

### Transaction Management
- Use `IUnitOfWork` for transactions
- Begin transaction at service level
- Commit after successful operations
- Rollback on errors

### SQL Guidelines
- Use parameterized queries only
- Never concatenate SQL strings
- Use WAL mode for better concurrency
- Configure busy timeout appropriately

---

## Testing Guidelines

### Unit Tests
- Test business logic in isolation
- Mock external dependencies
- Test both success and failure paths
- Use descriptive test names

### Integration Tests
- Test service orchestration
- Use test database
- Clean up after tests
- Test transaction rollback

---

## Code Review Checklist

### Architecture
- [ ] No SQL in controllers
- [ ] No business logic in controllers
- [ ] No direct database access outside repositories
- [ ] No direct module-to-module references
- [ ] All dependencies injected via constructor

### Code Quality
- [ ] Follows naming conventions
- [ ] Proper error handling
- [ ] Async/await used correctly
- [ ] Standard API responses
- [ ] No code duplication

### Security
- [ ] Input validation
- [ ] SQL injection prevention
- [ ] Authorization checks
- [ ] Sensitive data not logged

---

## Migration Strategy

### Incremental Refactoring
1. Create new service interface
2. Implement service with business logic from controller
3. Update controller to use service
4. Add repository if needed
5. Test thoroughly
6. Repeat for next controller

### Preservation Rules
- DO NOT modify business logic during refactor
- DO NOT change database schema
- DO NOT modify existing APIs
- DO NOT break existing functionality

---

## Future Module Registration

### Module Structure
Each new module should follow:
```
Modules/
  ModuleName/
    Controllers/
    Services/
    Repositories/
    DTOs/
    Entities/
    Validators/
```

### Registration Pattern
```csharp
services.AddScoped<IModuleService, ModuleService>();
services.AddScoped<IModuleRepository, ModuleRepository>();
```

### Integration Pattern
- Use events for cross-module communication
- No direct service calls between modules
- Shared interfaces in Shared folder
