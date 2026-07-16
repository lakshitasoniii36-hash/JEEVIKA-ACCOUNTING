# ERP Platform Folder Structure

**Version:** 1.0  
**Last Updated:** 2026-07-07

---

## Root Structure

```
Backend/
├── Controllers/              # Existing controllers (to be refactored)
├── Data/                     # Database files
├── Platform/                 # NEW: Platform foundation
├── Core/                     # NEW: Core types and utilities
├── Infrastructure/           # NEW: Infrastructure implementations
├── Shared/                   # NEW: Shared DTOs and interfaces
├── Domain/                   # NEW: Business domains (placeholders)
├── Application/              # NEW: Application service interfaces
├── Program.cs               # Application entry point
├── Backend.csproj           # Project file
└── appsettings.json         # Configuration
```

---

## Platform Folder Structure

```
Platform/
└── Contexts/
    ├── IApplicationContext.cs          # Global context interface
    ├── ApplicationContext.cs           # Global context implementation
    ├── ICurrentUserContext.cs         # User context interface
    ├── CurrentUserContext.cs          # User context implementation
    ├── ICompanyContext.cs             # Company context interface
    ├── CompanyContext.cs              # Company context implementation
    ├── IAssessmentYearContext.cs      # Assessment year context interface
    ├── AssessmentYearContext.cs       # Assessment year context implementation
    ├── IPermissionContext.cs          # Permission context interface
    ├── PermissionContext.cs           # Permission context implementation
    ├── IEnvironmentContext.cs         # Environment context interface
    └── EnvironmentContext.cs          # Environment context implementation
```

---

## Core Folder Structure

```
Core/
├── Result.cs                          # Result<T> and Result types
├── ApiResponse.cs                     # ApiResponse<T> and ApiResponse types
├── Constants/
│   ├── ErrorCodes.cs                  # Standard error codes
│   └── SystemEvents.cs                # System event names
├── Exceptions/
│   ├── ValidationException.cs         # Validation exception
│   ├── NotFoundException.cs           # Not found exception
│   ├── UnauthorizedException.cs       # Unauthorized exception
│   ├── ForbiddenException.cs          # Forbidden exception
│   ├── ConflictException.cs           # Conflict exception
│   └── ExceptionHandlingMiddleware.cs # Exception handling middleware
├── Helpers/
│   ├── DateTimeHelper.cs              # Date/time helper methods
│   └── StringHelper.cs                # String helper methods
└── Utilities/
    └── Guard.cs                       # Guard clauses for validation
```

---

## Infrastructure Folder Structure

```
Infrastructure/
├── Data/
│   ├── IDbConnectionFactory.cs        # Database connection factory interface
│   └── SqliteConnectionFactory.cs     # SQLite connection factory implementation
├── Repositories/
│   ├── IRepository.cs                 # Base repository interface
│   └── IUnitOfWork.cs                 # Unit of work interface
├── Logging/
│   └── ILogger.cs                     # Logging interface
├── Caching/
│   ├── ICache.cs                      # Cache interface
│   ├── IMemoryCache.cs                # In-memory cache interface
│   └── IDistributedCache.cs          # Distributed cache interface
├── Configuration/
│   └── IConfigurationManager.cs      # Configuration manager interface
└── DependencyInjection/
    └── ServiceCollectionExtensions.cs  # DI registration extensions
```

---

## Shared Folder Structure

```
Shared/
├── DTOs/
│   └── PagedResult.cs                 # Paged result model
├── Enums/
│   └── AccountType.cs                 # Common enumerations
├── Extensions/
│   └── StringExtensions.cs            # String extension methods
└── Interfaces/
    ├── IEventBus.cs                   # Event bus interface
    ├── IAuditService.cs               # Audit service interface
    └── IPermissionService.cs          # Permission service interface
```

---

## Domain Folder Structure

```
Domain/
├── Accounting/
│   └── README.md                      # Placeholder for accounting domain
├── Inventory/
│   └── README.md                      # Placeholder for inventory domain
├── CRM/
│   └── README.md                      # Placeholder for CRM domain
├── HR/
│   └── README.md                      # Placeholder for HR domain
├── Payroll/
│   └── README.md                      # Placeholder for payroll domain
├── Billing/
│   └── README.md                      # Placeholder for billing domain
├── Society/
│   └── README.md                      # Placeholder for society domain
├── Reporting/
│   └── README.md                      # Placeholder for reporting domain
└── Settings/
    └── README.md                      # Placeholder for settings domain
```

---

## Application Folder Structure

```
Application/
└── Services/
    ├── IAccountService.cs             # Account service interface
    ├── IMemberService.cs              # Member service interface
    ├── IVoucherService.cs             # Voucher service interface
    ├── IReportService.cs              # Report service interface
    ├── ISocietyService.cs             # Society service interface
    ├── IInventoryService.cs           # Inventory service interface
    ├── IBillingService.cs             # Billing service interface
    └── IAuthenticationService.cs      # Authentication service interface
```

---

## Existing Controllers Structure

```
Controllers/
├── AccountController.cs               # Account management (to be refactored)
├── AuthController.cs                  # Authentication (to be refactored)
├── BankController.cs                  # Bank management (to be refactored)
├── BillPrintSetupController.cs        # Bill print setup (to be refactored)
├── BillTransferController.cs         # Bill transfer (to be refactored)
├── BillTypeMasterController.cs       # Bill type master (to be refactored)
├── BillingMasterController.cs        # Billing master (to be refactored)
├── CommitteeMasterController.cs      # Committee master (to be refactored)
├── GSTMasterController.cs            # GST master (to be refactored)
├── GroupController.cs                # Group management (to be refactored)
├── MemberBillController.cs           # Member billing (to be refactored)
├── MemberController.cs               # Member management (to be refactored)
├── MemberNoteController.cs           # Member notes (to be refactored)
├── OpeningBalancesController.cs      # Opening balances (to be refactored)
├── OpeningBankRecoController.cs      # Opening bank reconciliation (to be refactored)
├── SocietyController.cs              # Society management (to be refactored)
├── StaffMasterController.cs          # Staff master (to be refactored)
├── UploadController.cs               # File upload (to be refactored)
├── VoucherAuditController.cs         # Voucher audit (to be refactored)
├── VoucherController.cs              # Voucher management (to be refactored)
└── WorkspaceController.cs            # Workspace (to be refactored)
```

---

## File Naming Conventions

### C# Files
- **Classes:** PascalCase (e.g., `AccountService.cs`)
- **Interfaces:** PascalCase with 'I' prefix (e.g., `IAccountService.cs`)
- **Enums:** PascalCase (e.g., `AccountType.cs`)
- **Extensions:** PascalCase with 'Extensions' suffix (e.g., `StringExtensions.cs`)

### Documentation Files
- **Markdown:** UPPERCASE with underscores (e.g., `PLATFORM_CODING_STANDARDS.md`)
- **Readme:** `README.md` (lowercase)

---

## Namespace Conventions

Namespaces match folder structure:

- `Backend.Controllers` - Controllers folder
- `Backend.Platform.Contexts` - Platform contexts
- `Backend.Core` - Core types
- `Backend.Core.Constants` - Core constants
- `Backend.Core.Exceptions` - Core exceptions
- `Backend.Core.Helpers` - Core helpers
- `Backend.Core.Utilities` - Core utilities
- `Backend.Infrastructure.Data` - Infrastructure data
- `Backend.Infrastructure.Repositories` - Infrastructure repositories
- `Backend.Infrastructure.Logging` - Infrastructure logging
- `Backend.Infrastructure.Caching` - Infrastructure caching
- `Backend.Infrastructure.Configuration` - Infrastructure configuration
- `Backend.Infrastructure.DependencyInjection` - Infrastructure DI
- `Backend.Shared.DTOs` - Shared DTOs
- `Backend.Shared.Enums` - Shared enums
- `Backend.Shared.Extensions` - Shared extensions
- `Backend.Shared.Interfaces` - Shared interfaces
- `Backend.Domain.Accounting` - Accounting domain
- `Backend.Domain.Inventory` - Inventory domain
- `Backend.Application.Services` - Application services
