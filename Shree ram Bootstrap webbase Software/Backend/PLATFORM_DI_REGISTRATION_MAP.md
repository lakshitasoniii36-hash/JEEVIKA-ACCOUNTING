# ERP Platform DI Registration Map

**Version:** 1.0  
**Last Updated:** 2026-07-07

---

## Registration Method

### Extension Method
```csharp
services.AddInfrastructure(databasePath);
services.AddPlatform();
services.AddApplication();
```

---

## Infrastructure Services Registration

### Singleton Services (Application Lifetime)

```csharp
services.AddSingleton<IDbConnectionFactory, SqliteConnectionFactory>();
services.AddSingleton<ICache, InMemoryCache>();
services.AddSingleton<IMemoryCache, InMemoryCache>();
services.AddSingleton<ILogger, ConsoleLogger>();
services.AddSingleton<IConfigurationManager, ConfigurationManager>();
```

### Rationale for Singleton
- **IDbConnectionFactory:** Connection factory is thread-safe and stateless
- **ICache:** In-memory cache is thread-safe with proper locking
- **ILogger:** Console logger is thread-safe
- **IConfigurationManager:** Configuration is read-only after initialization

---

## Platform Services Registration

### Singleton Services (Application Lifetime)

```csharp
services.AddSingleton<ICurrentUserContext, CurrentUserContext>();
services.AddSingleton<ICompanyContext, CompanyContext>();
services.AddSingleton<IAssessmentYearContext, AssessmentYearContext>();
services.AddSingleton<IPermissionContext, PermissionContext>();
services.AddSingleton<IEnvironmentContext, EnvironmentContext>();
```

### Singleton Application Context

```csharp
services.AddSingleton<IApplicationContext, ApplicationContext>();
```

### Rationale for Singleton
- Context objects are lightweight and thread-safe
- Context is shared across the application
- Context state is managed per-request via scoped services

---

## Application Services Registration

### Scoped Services (Request Lifetime)

```csharp
// When implementations are added:
services.AddScoped<IAccountService, AccountService>();
services.AddScoped<IMemberService, MemberService>();
services.AddScoped<IVoucherService, VoucherService>();
services.AddScoped<IReportService, ReportService>();
services.AddScoped<ISocietyService, SocietyService>();
services.AddScoped<IInventoryService, InventoryService>();
services.AddScoped<IBillingService, BillingService>();
services.AddScoped<IAuthenticationService, AuthenticationService>();
```

### Rationale for Scoped
- Services may hold request-specific state
- Services may use scoped repositories
- Services participate in transactions

---

## Repository Services Registration

### Scoped Services (Request Lifetime)

```csharp
// When implementations are added:
services.AddScoped<IRepository<Account, int>, AccountRepository>();
services.AddScoped<IRepository<Member, int>, MemberRepository>();
services.AddScoped<IRepository<Voucher, int>, VoucherRepository>();
services.AddScoped<IUnitOfWork, UnitOfWork>();
```

### Rationale for Scoped
- Repositories participate in transactions
- Repositories may hold connection state
- Repositories are request-bound

---

## Cross-Cutting Services Registration

### Event Bus (Singleton)

```csharp
services.AddSingleton<IEventBus, InMemoryEventBus>();
```

### Audit Service (Scoped)

```csharp
services.AddScoped<IAuditService, AuditService>();
```

### Permission Service (Scoped)

```csharp
services.AddScoped<IPermissionService, PermissionService>();
```

---

## Complete Registration Order

### Step 1: Register Infrastructure
```csharp
services.AddInfrastructure(databasePath);
```

### Step 2: Register Platform
```csharp
services.AddPlatform();
```

### Step 3: Register Application
```csharp
services.AddApplication();
```

### Step 4: Register Shared Services
```csharp
services.AddSingleton<IEventBus, InMemoryEventBus>();
services.AddScoped<IAuditService, AuditService>();
services.AddScoped<IPermissionService, PermissionService>();
```

---

## Service Lifetimes Summary

| Service | Interface | Implementation | Lifetime | Reason |
|---------|-----------|----------------|----------|--------|
| Database Connection Factory | IDbConnectionFactory | SqliteConnectionFactory | Singleton | Thread-safe, stateless |
| Cache | ICache, IMemoryCache | InMemoryCache | Singleton | Thread-safe, shared |
| Logger | ILogger | ConsoleLogger | Singleton | Thread-safe, shared |
| Configuration | IConfigurationManager | ConfigurationManager | Singleton | Read-only, shared |
| Current User Context | ICurrentUserContext | CurrentUserContext | Singleton | Lightweight, shared |
| Company Context | ICompanyContext | CompanyContext | Singleton | Lightweight, shared |
| Assessment Year Context | IAssessmentYearContext | AssessmentYearContext | Singleton | Lightweight, shared |
| Permission Context | IPermissionContext | PermissionContext | Singleton | Lightweight, shared |
| Environment Context | IEnvironmentContext | EnvironmentContext | Singleton | Lightweight, shared |
| Application Context | IApplicationContext | ApplicationContext | Singleton | Orchestrates contexts |
| Account Service | IAccountService | AccountService | Scoped | Request-bound |
| Member Service | IMemberService | MemberService | Scoped | Request-bound |
| Voucher Service | IVoucherService | VoucherService | Scoped | Request-bound |
| Report Service | IReportService | ReportService | Scoped | Request-bound |
| Society Service | ISocietyService | SocietyService | Scoped | Request-bound |
| Inventory Service | IInventoryService | InventoryService | Scoped | Request-bound |
| Billing Service | IBillingService | BillingService | Scoped | Request-bound |
| Authentication Service | IAuthenticationService | AuthenticationService | Scoped | Request-bound |
| Account Repository | IRepository<Account, int> | AccountRepository | Scoped | Transaction-bound |
| Member Repository | IRepository<Member, int> | MemberRepository | Scoped | Transaction-bound |
| Voucher Repository | IRepository<Voucher, int> | VoucherRepository | Scoped | Transaction-bound |
| Unit of Work | IUnitOfWork | UnitOfWork | Scoped | Transaction-bound |
| Event Bus | IEventBus | InMemoryEventBus | Singleton | Cross-module |
| Audit Service | IAuditService | AuditService | Scoped | Request-bound |
| Permission Service | IPermissionService | PermissionService | Scoped | Request-bound |

---

## Constructor Injection Examples

### Controller Injection
```csharp
public class AccountController : ControllerBase
{
    private readonly IAccountService _accountService;
    private readonly ICurrentUserContext _currentUserContext;

    public AccountController(
        IAccountService accountService,
        ICurrentUserContext currentUserContext)
    {
        _accountService = accountService;
        _currentUserContext = currentUserContext;
    }
}
```

### Service Injection
```csharp
public class AccountService : IAccountService
{
    private readonly IRepository<Account, int> _accountRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IEventBus _eventBus;
    private readonly IAuditService _auditService;
    private readonly ICurrentUserContext _currentUserContext;

    public AccountService(
        IRepository<Account, int> accountRepository,
        IUnitOfWork unitOfWork,
        IEventBus eventBus,
        IAuditService auditService,
        ICurrentUserContext currentUserContext)
    {
        _accountRepository = accountRepository;
        _unitOfWork = unitOfWork;
        _eventBus = eventBus;
        _auditService = auditService;
        _currentUserContext = currentUserContext;
    }
}
```

### Repository Injection
```csharp
public class AccountRepository : IRepository<Account, int>
{
    private readonly IDbConnectionFactory _connectionFactory;
    private readonly ILogger _logger;

    public AccountRepository(
        IDbConnectionFactory connectionFactory,
        ILogger logger)
    {
        _connectionFactory = connectionFactory;
        _logger = logger;
    }
}
```

---

## Service Resolution Validation

### Validation Rules
- All services must be registered before use
- Circular dependencies must be avoided
- Singleton services must be thread-safe
- Scoped services must not depend on scoped services in constructors

### Validation Method
```csharp
// In Program.cs
var serviceProvider = services.BuildServiceProvider();
serviceProvider.ValidateServiceRegistrations();
```

---

## Future Module Registration Pattern

### Module Registration Extension
```csharp
public static class AccountingModuleExtensions
{
    public static IServiceCollection AddAccountingModule(this IServiceCollection services)
    {
        services.AddScoped<IAccountService, AccountService>();
        services.AddScoped<IVoucherService, VoucherService>();
        services.AddScoped<IRepository<Account, int>, AccountRepository>();
        services.AddScoped<IRepository<Voucher, int>, VoucherRepository>();
        return services;
    }
}
```

### Module Registration in Program.cs
```csharp
services.AddInfrastructure(databasePath);
services.AddPlatform();
services.AddAccountingModule();
services.AddSocietyModule();
services.AddBillingModule();
```
