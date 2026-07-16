# ERP Platform Dependency Graph

**Version:** 1.0  
**Last Updated:** 2026-07-07

---

## Dependency Rules

### Allowed Dependencies (→)

```
Controllers → Services
Controllers → DTOs
Controllers → Core
Controllers → Shared

Services → Domain
Services → Repositories
Services → Core
Services → Shared

Domain → Core
Domain → Shared

Repositories → Infrastructure
Repositories → Core
Repositories → Shared

Infrastructure → Core
Infrastructure → Shared
```

### Forbidden Dependencies (✗)

```
Controllers ✗ Repositories
Controllers ✗ Domain
Controllers ✗ Infrastructure
Controllers ✗ Other Controllers

Services ✗ Controllers
Services ✗ Other Services (direct)

Domain ✗ Infrastructure
Domain ✗ Repositories
Domain ✗ Services

Repositories ✗ Services
Repositories ✗ Controllers
Repositories ✗ Other Repositories (direct)
```

---

## Layer Dependency Diagram

```
┌─────────────────────────────────────────────────────────────┐
│                     Controllers Layer                        │
│  (HTTP Request/Response, Orchestration, Input Validation)  │
└─────────────────────┬───────────────────────────────────────┘
                      │
                      ↓
┌─────────────────────────────────────────────────────────────┐
│                   Application Layer                           │
│  (Services, Use Cases, DTO Mapping, Event Publishing)       │
└─────────────────────┬───────────────────────────────────────┘
                      │
                      ↓
┌─────────────────────────────────────────────────────────────┐
│                      Domain Layer                            │
│  (Business Logic, Entities, Domain Services, Rules)         │
└─────────────────────┬───────────────────────────────────────┘
                      │
                      ↓
┌─────────────────────────────────────────────────────────────┐
│                 Infrastructure Layer                          │
│  (Repositories, Database Access, Caching, Logging)           │
└─────────────────────────────────────────────────────────────┘
```

---

## Module Dependency Pattern

### Current (Tightly Coupled - To Be Refactored)
```
AccountController → DbHelper (Direct SQL)
MemberController → DbHelper (Direct SQL)
VoucherController → DbHelper (Direct SQL)
```

### Target (Loosely Coupled)
```
AccountController → IAccountService → IAccountRepository → IDbConnectionFactory
MemberController → IMemberService → IMemberRepository → IDbConnectionFactory
VoucherController → IVoucherService → IVoucherRepository → IDbConnectionFactory
```

### Cross-Module Communication (Event-Driven)
```
Accounting Module → IEventBus → Society Module
Accounting Module → IEventBus → Billing Module
Society Module → IEventBus → Reporting Module
```

---

## Component Dependencies

### Platform Contexts
```
ApplicationContext
├── ICurrentUserContext
├── ICompanyContext
├── IAssessmentYearContext
├── IPermissionContext
├── IEnvironmentContext
└── IConfigurationManager
```

### Core Types
```
Result<T>
├── Core (no dependencies)
└── System (built-in)

ApiResponse<T>
├── Core (no dependencies)
└── System (built-in)

Exceptions
├── Core (no dependencies)
└── System (built-in)
```

### Infrastructure Components
```
SqliteConnectionFactory
├── Microsoft.Data.Sqlite (external)
└── System (built-in)

InMemoryCache
├── System (built-in)
└── System.Collections.Generic (built-in)

ConsoleLogger
├── System (built-in)
└── System.Console (built-in)
```

### Shared Interfaces
```
IEventBus
├── Core (Result<T>)
└── System (built-in)

IAuditService
├── Core (no dependencies)
└── System (built-in)

IPermissionService
├── Core (no dependencies)
└── System (built-in)
```

---

## Dependency Injection Hierarchy

### Singleton Services (Application Lifetime)
```
IDbConnectionFactory
IConfigurationManager
ICache (InMemoryCache)
ILogger (ConsoleLogger)
IApplicationContext
ICurrentUserContext
ICompanyContext
IAssessmentYearContext
IPermissionContext
IEnvironmentContext
```

### Scoped Services (Request Lifetime)
```
IUnitOfWork (when implemented)
Repository implementations (when implemented)
Service implementations (when implemented)
```

### Transient Services (Each Request)
```
DTOs (when needed)
Validators (when implemented)
```

---

## External Dependencies

### NuGet Packages
```
Microsoft.Data.Sqlite (10.0.7)
  └── Used by: SqliteConnectionFactory

Swashbuckle.AspNetCore (10.1.7)
  └── Used by: Swagger/OpenAPI

System.Data.OleDb (8.0.0)
  └── Used by: Legacy data access (to be removed)

Microsoft.IdentityModel.Tokens (7.0.2)
  └── Used by: JWT authentication (future)

System.IdentityModel.Tokens.Jwt (7.0.2)
  └── Used by: JWT authentication (future)
```

---

## Circular Dependency Prevention

### Anti-Pattern (Avoid)
```
Service A → Service B
Service B → Service A
```

### Correct Pattern (Use Events)
```
Service A → IEventBus → Event
Event → Service B Handler
```

### Example
```
AccountingService → IEventBus.Publish(VoucherCreatedEvent)
VoucherCreatedEvent → BillingService.Handle(VoucherCreatedEvent)
```

---

## Dependency Inversion Principle

### High-Level Modules (Should Not Depend on Low-Level)
```
Controllers (High-Level)
  └── Depend on: IAccountService (Interface)
      └── Implemented by: AccountService (Low-Level)
```

### Abstractions Should Not Depend on Details
```
IRepository<T> (Abstraction)
  └── Implemented by: SqliteRepository<T> (Detail)
```

### Details Should Depend on Abstractions
```
SqliteRepository<T> (Detail)
  └── Depends on: IRepository<T> (Abstraction)
```

---

## Module Isolation Strategy

### Module Boundaries
```
Accounting Module
├── Controllers: AccountController, VoucherController
├── Services: IAccountService, IVoucherService
├── Repositories: IAccountRepository, IVoucherRepository
├── DTOs: AccountDto, VoucherDto
├── Entities: Account, Voucher
└── Domain: Accounting domain logic
```

### Inter-Module Communication
```
Module A → IEventBus → IntegrationEvent
IntegrationEvent → Module B Handler
```

### No Direct Module Dependencies
```
✗ AccountingService → BillingService (Direct call)
✓ AccountingService → IEventBus → BillingService (Event)
```
