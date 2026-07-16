# ERP Platform Module Registration Strategy

**Version:** 1.0  
**Last Updated:** 2026-07-07

---

## Module Registration Philosophy

### Principles
1. **Modular Independence:** Each module registers its own services
2. **Explicit Registration:** No auto-discovery, explicit registration only
3. **Extension Methods:** Each module provides a registration extension
4. **Optional Dependencies:** Modules can be added/removed without breaking core
5. **Clear Boundaries:** Module registration defines module boundaries

---

## Module Structure Template

### Folder Structure
```
Modules/
└── ModuleName/
    ├── Controllers/
    │   └── ModuleNameController.cs
    ├── Services/
    │   ├── IModuleNameService.cs
    │   └── ModuleNameService.cs
    ├── Repositories/
    │   ├── IModuleNameRepository.cs
    │   └── ModuleNameRepository.cs
    ├── DTOs/
    │   ├── ModuleNameDto.cs
    │   └── CreateModuleNameRequest.cs
    ├── Entities/
    │   └── ModuleNameEntity.cs
    ├── Validators/
    │   └── ModuleNameValidator.cs
    └── Events/
        ├── ModuleNameCreatedEvent.cs
        └── ModuleNameUpdatedEvent.cs
```

---

## Registration Extension Template

### Extension Method
```csharp
namespace Backend.Modules.ModuleName
{
    public static class ModuleNameModuleExtensions
    {
        public static IServiceCollection AddModuleNameModule(this IServiceCollection services)
        {
            // Register Services
            services.AddScoped<IModuleNameService, ModuleNameService>();

            // Register Repositories
            services.AddScoped<IRepository<ModuleNameEntity, int>, ModuleNameRepository>();

            // Register Event Handlers (if any)
            services.AddScoped<IEventHandler<ModuleNameCreatedEvent>, ModuleNameCreatedHandler>();

            return services;
        }
    }
}
```

---

## Module Registration Order

### Core Platform (Always Registered First)
```csharp
services.AddInfrastructure(databasePath);
services.AddPlatform();
```

### Business Modules (Registered in Dependency Order)
```csharp
// Foundation modules (no dependencies)
services.AddAuthenticationModule();
services.AddSocietyModule();

// Dependent modules
services.AddAccountingModule();
services.AddMemberModule();

// Higher-level modules
services.AddBillingModule();
services.AddReportingModule();
```

### Optional Modules (Registered as Needed)
```csharp
// Optional features
services.AddInventoryModule();
services.AddPayrollModule();
services.AddCRMModule();
services.AddHRModule();
```

---

## Module Dependency Management

### Dependency Declaration
```csharp
public static class ModuleNameModuleExtensions
{
    public static IServiceCollection AddModuleNameModule(
        this IServiceCollection services,
        Action<ModuleNameModuleOptions> configureOptions = null)
    {
        // Configure options
        var options = new ModuleNameModuleOptions();
        configureOptions?.Invoke(options);

        // Register services
        services.Configure(configureOptions);

        // Register module services
        services.AddScoped<IModuleNameService, ModuleNameService>();

        return services;
    }
}
```

### Dependency Validation
```csharp
public static class ModuleNameModuleExtensions
{
    public static IServiceCollection AddModuleNameModule(this IServiceCollection services)
    {
        // Validate required dependencies
        if (!services.Any(s => s.ServiceType == typeof(ISocietyService)))
        {
            throw new InvalidOperationException(
                "ModuleNameModule requires SocietyModule to be registered first");
        }

        // Register services
        services.AddScoped<IModuleNameService, ModuleNameService>();

        return services;
    }
}
```

---

## Event-Based Module Communication

### Module A Publishes Event
```csharp
public class AccountingService : IAccountingService
{
    private readonly IEventBus _eventBus;

    public async Task CreateVoucherAsync(CreateVoucherRequest request)
    {
        // Create voucher
        var voucher = await _repository.AddAsync(voucherEntity);

        // Publish event
        await _eventBus.PublishAsync(new VoucherCreatedEvent
        {
            VoucherId = voucher.Id,
            Amount = voucher.Amount,
            CreatedAt = DateTime.UtcNow
        });
    }
}
```

### Module B Subscribes to Event
```csharp
public class BillingService : IBillingService
{
    public BillingService(IEventBus eventBus)
    {
        eventBus.SubscribeAsync<VoucherCreatedEvent>(HandleVoucherCreated);
    }

    private async Task HandleVoucherCreated(VoucherCreatedEvent @event)
    {
        // Process voucher for billing
        await ProcessVoucherForBilling(@event.VoucherId);
    }
}
```

### Event Registration
```csharp
public static class BillingModuleExtensions
{
    public static IServiceCollection AddBillingModule(this IServiceCollection services)
    {
        services.AddScoped<IBillingService, BillingService>();

        // Register event handlers
        services.AddScoped<IEventHandler<VoucherCreatedEvent>, VoucherCreatedHandler>();

        return services;
    }
}
```

---

## Module Configuration

### Configuration Class
```csharp
public class ModuleNameModuleOptions
{
    public bool Enabled { get; set; } = true;
    public string DatabaseTablePrefix { get; set; } = "ModuleName";
    public int CacheDurationMinutes { get; set; } = 30;
}
```

### Configuration Registration
```csharp
services.AddModuleNameModule(options =>
{
    options.Enabled = true;
    options.DatabaseTablePrefix = "ACCT";
    options.CacheDurationMinutes = 60;
});
```

---

## Module Versioning

### Version Attribute
```csharp
[ModuleVersion("1.0.0")]
public static class ModuleNameModuleExtensions
{
    public static IServiceCollection AddModuleNameModule(this IServiceCollection services)
    {
        // Registration logic
        return services;
    }
}
```

### Version Validation
```csharp
public static class ModuleRegistry
{
    public static void ValidateModuleVersions(IServiceCollection services)
    {
        // Check module compatibility
        // Validate version dependencies
    }
}
```

---

## Module Discovery (Future Enhancement)

### Attribute-Based Discovery
```csharp
[Module("Accounting", Version = "1.0.0", Dependencies = new[] { "Society" })]
public class AccountingModule
{
    public static IServiceCollection Register(IServiceCollection services)
    {
        services.AddAccountingModule();
        return services;
    }
}
```

### Auto-Registration
```csharp
public static IServiceCollection RegisterModules(this IServiceCollection services)
{
    var moduleTypes = Assembly.GetExecutingAssembly()
        .GetTypes()
        .Where(t => t.GetCustomAttribute<ModuleAttribute>() != null);

    foreach (var moduleType in moduleTypes)
    {
        var registerMethod = moduleType.GetMethod("Register");
        registerMethod?.Invoke(null, new object[] { services });
    }

    return services;
}
```

---

## Module Testing Strategy

### Module Isolation
```csharp
public class AccountingModuleTests
{
    private readonly IServiceProvider _serviceProvider;

    public AccountingModuleTests()
    {
        var services = new ServiceCollection();
        services.AddInfrastructure(":memory:");
        services.AddPlatform();
        services.AddAccountingModule();
        _serviceProvider = services.BuildServiceProvider();
    }

    [Fact]
    public async Task AccountService_ShouldCreateAccount()
    {
        var service = _serviceProvider.GetRequiredService<IAccountService>();
        var result = await service.CreateAccountAsync(new CreateAccountRequest
        {
            Code = "TEST001",
            Name = "Test Account"
        });

        Assert.True(result.IsSuccess);
    }
}
```

---

## Module Migration Strategy

### Phase 1: Create Module Structure
- Create module folder structure
- Create service interfaces
- Create repository interfaces
- Create DTOs
- Create registration extension

### Phase 2: Implement Services
- Implement service interfaces
- Implement repository interfaces
- Add business logic
- Add validation

### Phase 3: Refactor Controllers
- Update controller to use service
- Remove direct SQL from controller
- Add unit tests
- Integration test

### Phase 4: Register Module
- Add module registration to Program.cs
- Configure module options
- Test module integration
- Deploy

---

## Module Removal Strategy

### Graceful Removal
1. Remove module registration from Program.cs
2. Deprecate module services (mark as Obsolete)
3. Provide migration path for data
4. Document removal procedure
5. Remove after deprecation period

### Data Migration
```csharp
public static class ModuleNameDataMigration
{
    public static async Task MigrateDataAsync(IDbConnectionFactory connectionFactory)
    {
        // Migrate data to other modules
        // Archive old data
        // Clean up tables
    }
}
```

---

## Module Documentation Requirements

### README.md Template
```markdown
# ModuleName Module

## Purpose
Brief description of module purpose.

## Dependencies
- SocietyModule (required)
- AccountingModule (optional)

## Services
- IModuleNameService

## Events
- ModuleNameCreatedEvent
- ModuleNameUpdatedEvent

## Configuration
```csharp
services.AddModuleNameModule(options =>
{
    options.Enabled = true;
});
```

## Usage Example
```csharp
var service = serviceProvider.GetRequiredService<IModuleNameService>();
var result = await service.ExecuteAsync(request);
```
```
