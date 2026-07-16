# Pipeline Architecture Documentation

**Version:** 1.0  
**Last Updated:** 2026-07-07  
**Purpose:** Document the Pipeline Architecture for the ERP platform

---

## Overview

The Pipeline Architecture provides a middleware-style pipeline for processing commands and queries through a series of behaviors. It follows the Chain of Responsibility pattern with cross-cutting concerns handled by behaviors.

---

## Architecture Principles

### Core Principles
- **Chain of Responsibility:** Each behavior processes the request and passes to the next
- **Separation of Concerns:** Each behavior handles one cross-cutting concern
- **Open/Closed:** New behaviors can be added without modifying existing code
- **Single Responsibility:** Each behavior has one responsibility
- **Order Matters:** Behaviors execute in a specific order

### Pipeline Rules
- **Behaviors are composable:** Multiple behaviors can be chained together
- **Behaviors are reusable:** Same behavior can be used for different requests
- **Behaviors are testable:** Each behavior can be tested independently
- **Behaviors are async:** All behaviors support async operations

---

## Behavior Interface

### IBehavior<TRequest, TResponse>
Base interface for pipeline behaviors.

**Methods:**
- `HandleAsync(request, next, cancellationToken)` - Process request through behavior pipeline

**Parameters:**
- `request` - Request to process
- `next` - Next behavior in pipeline (delegate to next handler)
- `cancellationToken` - Cancellation token

**Implementation Pattern:**
```csharp
public class CustomBehavior<TRequest, TResponse> : IBehavior<TRequest, TResponse>
{
    public async Task<TResponse> HandleAsync(TRequest request, Func<Task<TResponse>> next, CancellationToken cancellationToken = default)
    {
        // Pre-processing logic
        var response = await next();
        // Post-processing logic
        return response;
    }
}
```

---

## Pipeline Behaviors

### ValidationBehavior
Validates requests before processing.

**Responsibility:**
- Validate request data
- Return validation errors if invalid
- Pass to next behavior if valid

**Order:** First in pipeline

**Implementation:**
```csharp
public class ValidationBehavior<TRequest, TResponse> : IBehavior<TRequest, TResponse>
{
    public async Task<TResponse> HandleAsync(TRequest request, Func<Task<TResponse>> next, CancellationToken cancellationToken = default)
    {
        // Validate request
        // Future: Use validation framework
        return await next();
    }
}
```

### LoggingBehavior
Logs request/response for observability.

**Responsibility:**
- Log request details before processing
- Log response details after processing
- Log execution time

**Order:** Second in pipeline

**Implementation:**
```csharp
public class LoggingBehavior<TRequest, TResponse> : IBehavior<TRequest, TResponse>
{
    public async Task<TResponse> HandleAsync(TRequest request, Func<Task<TResponse>> next, CancellationToken cancellationToken = default)
    {
        // Log request
        var response = await next();
        // Log response
        return response;
    }
}
```

### AuthorizationBehavior
Checks permissions before processing.

**Responsibility:**
- Check user permissions
- Return unauthorized if permission denied
- Pass to next behavior if authorized

**Order:** Third in pipeline

**Implementation:**
```csharp
public class AuthorizationBehavior<TRequest, TResponse> : IBehavior<TRequest, TResponse>
{
    public async Task<TResponse> HandleAsync(TRequest request, Func<Task<TResponse>> next, CancellationToken cancellationToken = default)
    {
        // Check authorization
        // Future: Check user permissions
        return await next();
    }
}
```

### TransactionBehavior
Wraps operations in transactions.

**Responsibility:**
- Begin transaction before processing
- Commit transaction if successful
- Rollback transaction if failed

**Order:** Fourth in pipeline (for commands only)

**Implementation:**
```csharp
public class TransactionBehavior<TRequest, TResponse> : IBehavior<TRequest, TResponse>
{
    private readonly IUnitOfWork _unitOfWork;

    public TransactionBehavior(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<TResponse> HandleAsync(TRequest request, Func<Task<TResponse>> next, CancellationToken cancellationToken = default)
    {
        await _unitOfWork.BeginTransactionAsync();
        
        try
        {
            var response = await next();
            await _unitOfWork.CommitAsync();
            return response;
        }
        catch
        {
            await _unitOfWork.RollbackAsync();
            throw;
        }
    }
}
```

### PerformanceBehavior
Measures execution time for performance monitoring.

**Responsibility:**
- Measure execution time
- Log performance metrics
- Track slow operations

**Order:** Fifth in pipeline

**Implementation:**
```csharp
public class PerformanceBehavior<TRequest, TResponse> : IBehavior<TRequest, TResponse>
{
    public async Task<TResponse> HandleAsync(TRequest request, Func<Task<TResponse>> next, CancellationToken cancellationToken = default)
    {
        var stopwatch = System.Diagnostics.Stopwatch.StartNew();
        
        try
        {
            var response = await next();
            stopwatch.Stop();
            
            // Log performance metrics
            // Future: Log execution time, memory usage, etc.
            
            return response;
        }
        catch
        {
            stopwatch.Stop();
            throw;
        }
    }
}
```

### AuditBehavior
Logs audit trails for compliance.

**Responsibility:**
- Log who did what
- Log when it happened
- Log what entity was affected

**Order:** Sixth in pipeline

**Implementation:**
```csharp
public class AuditBehavior<TRequest, TResponse> : IBehavior<TRequest, TResponse>
{
    public async Task<TResponse> HandleAsync(TRequest request, Func<Task<TResponse>> next, CancellationToken cancellationToken = default)
    {
        // Log audit trail
        // Future: Log who did what, when, and to what entity
        var response = await next();
        return response;
    }
}
```

### ExceptionBehavior
Handles exceptions gracefully.

**Responsibility:**
- Catch exceptions
- Log exceptions
- Convert to appropriate error response

**Order:** Last in pipeline

**Implementation:**
```csharp
public class ExceptionBehavior<TRequest, TResponse> : IBehavior<TRequest, TResponse>
{
    public async Task<TResponse> HandleAsync(TRequest request, Func<Task<TResponse>> next, CancellationToken cancellationToken = default)
    {
        try
        {
            return await next();
        }
        catch (Exception ex)
        {
            // Handle exception
            // Future: Log exception, convert to appropriate error response
            throw;
        }
    }
}
```

---

## Pipeline Execution Order

### Standard Command Pipeline
```
Request
  ↓
ValidationBehavior
  ↓
LoggingBehavior
  ↓
AuthorizationBehavior
  ↓
TransactionBehavior
  ↓
PerformanceBehavior
  ↓
AuditBehavior
  ↓
ExceptionBehavior
  ↓
Handler
  ↓
Response
```

### Standard Query Pipeline
```
Request
  ↓
ValidationBehavior
  ↓
LoggingBehavior
  ↓
AuthorizationBehavior
  ↓
PerformanceBehavior
  ↓
ExceptionBehavior
  ↓
Handler
  ↓
Response
```

---

## Pipeline Configuration

### Behavior Registration
Behaviors are registered in the DI container.

```csharp
services.AddTransient(typeof(IBehavior<,>), typeof(ValidationBehavior<,>));
services.AddTransient(typeof(IBehavior<,>), typeof(LoggingBehavior<,>));
services.AddTransient(typeof(IBehavior<,>), typeof(AuthorizationBehavior<,>));
services.AddTransient(typeof(IBehavior<,>), typeof(TransactionBehavior<,>));
services.AddTransient(typeof(IBehavior<,>), typeof(PerformanceBehavior<,>));
services.AddTransient(typeof(IBehavior<,>), typeof(AuditBehavior<,>));
services.AddTransient(typeof(IBehavior<,>), typeof(ExceptionBehavior<,>));
```

### Pipeline Builder
Pipeline builder constructs the behavior chain.

```csharp
public class PipelineBuilder<TRequest, TResponse>
{
    private readonly IServiceProvider _serviceProvider;
    private readonly List<Type> _behaviorTypes = new();

    public PipelineBuilder(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public PipelineBuilder<TRequest, TResponse> AddBehavior<TBehavior>() where TBehavior : IBehavior<TRequest, TResponse>
    {
        _behaviorTypes.Add(typeof(TBehavior));
        return this;
    }

    public Func<Task<TResponse>> Build(Func<Task<TResponse>> handler)
    {
        Func<Task<TResponse>> pipeline = handler;

        for (int i = _behaviorTypes.Count - 1; i >= 0; i--)
        {
            var behaviorType = _behaviorTypes[i];
            var behavior = (IBehavior<TRequest, TResponse>)_serviceProvider.GetRequiredService(behaviorType);
            
            var currentPipeline = pipeline;
            pipeline = () => behavior.HandleAsync(default!, currentPipeline);
        }

        return pipeline;
    }
}
```

---

## Pipeline Usage

### Command Handler with Pipeline
```csharp
public class CreateMemberCommandHandler : ICommandHandler<CreateMemberCommand, MemberDto>
{
    private readonly IServiceProvider _serviceProvider;
    private readonly IMemberRepository _repository;

    public CreateMemberCommandHandler(IServiceProvider serviceProvider, IMemberRepository repository)
    {
        _serviceProvider = serviceProvider;
        _repository = repository;
    }

    public async Task<MemberDto> HandleAsync(CreateMemberCommand command, CancellationToken cancellationToken = default)
    {
        var pipeline = new PipelineBuilder<CreateMemberCommand, MemberDto>(_serviceProvider)
            .AddBehavior<ValidationBehavior<CreateMemberCommand, MemberDto>>()
            .AddBehavior<LoggingBehavior<CreateMemberCommand, MemberDto>>()
            .AddBehavior<AuthorizationBehavior<CreateMemberCommand, MemberDto>>()
            .AddBehavior<TransactionBehavior<CreateMemberCommand, MemberDto>>()
            .AddBehavior<PerformanceBehavior<CreateMemberCommand, MemberDto>>()
            .AddBehavior<AuditBehavior<CreateMemberCommand, MemberDto>>()
            .AddBehavior<ExceptionBehavior<CreateMemberCommand, MemberDto>>()
            .Build(() => HandleInternalAsync(command, cancellationToken));

        return await pipeline();
    }

    private async Task<MemberDto> HandleInternalAsync(CreateMemberCommand command, CancellationToken cancellationToken)
    {
        // Actual handler logic
        var member = new Member { Name = command.Name, Email = command.Email };
        await _repository.AddAsync(member);
        return new MemberDto { Id = member.Id, Name = member.Name, Email = member.Email };
    }
}
```

### Query Handler with Pipeline
```csharp
public class GetMemberQueryHandler : IQueryHandler<GetMemberQuery, MemberDto>
{
    private readonly IServiceProvider _serviceProvider;
    private readonly IMemberRepository _repository;

    public GetMemberQueryHandler(IServiceProvider serviceProvider, IMemberRepository repository)
    {
        _serviceProvider = serviceProvider;
        _repository = repository;
    }

    public async Task<MemberDto> HandleAsync(GetMemberQuery query, CancellationToken cancellationToken = default)
    {
        var pipeline = new PipelineBuilder<GetMemberQuery, MemberDto>(_serviceProvider)
            .AddBehavior<ValidationBehavior<GetMemberQuery, MemberDto>>()
            .AddBehavior<LoggingBehavior<GetMemberQuery, MemberDto>>()
            .AddBehavior<AuthorizationBehavior<GetMemberQuery, MemberDto>>()
            .AddBehavior<PerformanceBehavior<GetMemberQuery, MemberDto>>()
            .AddBehavior<ExceptionBehavior<GetMemberQuery, MemberDto>>()
            .Build(() => HandleInternalAsync(query, cancellationToken));

        return await pipeline();
    }

    private async Task<MemberDto> HandleInternalAsync(GetMemberQuery query, CancellationToken cancellationToken)
    {
        // Actual handler logic
        var member = await _repository.GetByIdAsync(query.MemberId);
        return new MemberDto { Id = member.Id, Name = member.Name, Email = member.Email };
    }
}
```

---

## Pipeline Benefits

### Separation of Concerns
- Each behavior handles one cross-cutting concern
- Handler logic is clean and focused
- Behaviors are reusable across handlers

### Consistency
- All requests go through same pipeline
- Consistent logging, validation, authorization
- Consistent error handling

### Maintainability
- Easy to add new behaviors
- Easy to modify existing behaviors
- Easy to test behaviors independently

### Performance
- Behaviors can be optimized independently
- Performance monitoring built-in
- Async operations throughout

### Testability
- Each behavior can be tested independently
- Pipeline can be tested with mock behaviors
- Handler logic can be tested without pipeline

---

## Pipeline Best Practices

### Order Behaviors Correctly
```csharp
// Good: Correct order
.AddBehavior<ValidationBehavior<,>>()
.AddBehavior<LoggingBehavior<,>>()
.AddBehavior<AuthorizationBehavior<,>>()
.AddBehavior<TransactionBehavior<,>>()
.AddBehavior<PerformanceBehavior<,>>()
.AddBehavior<AuditBehavior<,>>()
.AddBehavior<ExceptionBehavior<,>>()

// Bad: Wrong order
.AddBehavior<TransactionBehavior<,>>()
.AddBehavior<ValidationBehavior<,>>() // Validation after transaction
```

### Use Transaction Behavior for Commands Only
```csharp
// Good: Transaction for commands
.AddBehavior<TransactionBehavior<,>>() // For command handlers

// Bad: Transaction for queries
.AddBehavior<TransactionBehavior<,>>() // Not needed for queries
```

### Keep Behaviors Focused
```csharp
// Good: Single responsibility
public class ValidationBehavior<TRequest, TResponse> : IBehavior<TRequest, TResponse>
{
    // Only validates
}

// Bad: Multiple responsibilities
public class ValidationAndLoggingBehavior<TRequest, TResponse> : IBehavior<TRequest, TResponse>
{
    // Validates AND logs - violates single responsibility
}
```

### Use Async Throughout
```csharp
// Good: Async operations
public async Task<TResponse> HandleAsync(TRequest request, Func<Task<TResponse>> next, CancellationToken cancellationToken = default)
{
    return await next();
}

// Bad: Blocking operations
public Task<TResponse> HandleAsync(TRequest request, Func<Task<TResponse>> next, CancellationToken cancellationToken = default)
{
    return next().Result; // Blocks
}
```

---

## Pipeline Anti-Patterns

### Don't Skip Behaviors
```csharp
// Bad: Skipping next behavior
public async Task<TResponse> HandleAsync(TRequest request, Func<Task<TResponse>> next, CancellationToken cancellationToken = default)
{
    // Logic
    return default!; // Never calls next()
}
```

### Don't Modify Request After Validation
```csharp
// Bad: Modifying request after validation
public async Task<TResponse> HandleAsync(TRequest request, Func<Task<TResponse>> next, CancellationToken cancellationToken = default)
{
    // Validate
    // Modify request - validation no longer valid
    return await next();
}
```

### Don't Throw in Middle of Pipeline
```csharp
// Bad: Throwing in middle of pipeline
public async Task<TResponse> HandleAsync(TRequest request, Func<Task<TResponse>> next, CancellationToken cancellationToken = default)
{
    throw new Exception("Error"); // Should use ExceptionBehavior
}
```

---

## Future Enhancements

### Behavior Implementation
- Implement actual validation logic in ValidationBehavior
- Implement actual logging in LoggingBehavior
- Implement actual authorization checks in AuthorizationBehavior
- Implement actual transaction wrapping in TransactionBehavior
- Implement actual performance metrics in PerformanceBehavior
- Implement actual audit logging in AuditBehavior
- Implement actual exception handling in ExceptionBehavior

### Pipeline Builder
- Add support for conditional behaviors
- Add support for behavior configuration
- Add support for behavior ordering
- Add support for behavior profiling

### Advanced Features
- Add support for distributed transactions
- Add support for retry logic
- Add support for circuit breaker
- Add support for rate limiting
- Add support for caching

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
