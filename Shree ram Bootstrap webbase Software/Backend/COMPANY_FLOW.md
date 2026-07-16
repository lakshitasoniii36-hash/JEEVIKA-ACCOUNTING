# Company Flow Documentation

**Version:** 1.0  
**Last Updated:** 2026-07-07  
**Purpose:** Document company context management flow

---

## Overview

The Company Engine manages company context for multi-company operation. Although the current software is single-company, the architecture supports future multi-company expansion without code changes.

---

## Company Context Flow

```
User Login
    ↓
Authenticate User
    ↓
Get User's Default Company
    ↓
Set Company Context
    ├─ CompanyId
    ├─ CompanyCode
    └─ CompanyName
    ↓
Validate Company Exists
    ↓
Validate User Has Access
    ↓
Company Context Active
```

---

## Company Context Switch Flow

```
User Requests Company Switch
    ↓
Validate User Has Access to Target Company
    ↓
Clear Current Company Context
    ↓
Set New Company Context
    ├─ CompanyId
    ├─ CompanyCode
    └─ CompanyName
    ↓
Get Company's Default Assessment Year
    ↓
Set Assessment Year Context
    ↓
Publish Company Switched Event
    ↓
Return Success Response
```

---

## Company Engine Components

### ICompanyEngine Interface
**Purpose:** Manage company context and operations

**Methods:**
- `SetCompanyAsync(companyId, companyCode, companyName)` - Set current company
- `ClearCompanyAsync()` - Clear current company
- `CompanyExistsAsync(companyId)` - Validate company exists
- `GetAvailableCompaniesAsync()` - Get all available companies
- `GetCompanyAsync(companyId)` - Get company information

**Properties:**
- `CurrentCompanyId` - Currently selected company ID
- `CurrentCompanyCode` - Currently selected company code
- `CurrentCompanyName` - Currently selected company name
- `HasCompanyContext` - Whether company context is set

### CompanyInfo Model
**Properties:**
- `CompanyId` - Unique company identifier
- `CompanyCode` - Company code for display
- `CompanyName` - Company full name
- `DatabaseName` - Database name for company
- `IsActive` - Whether company is active
- `CreatedDate` - Company creation date
- `ModifiedDate` - Last modification date

---

## Company Resolution Sources

### Priority Order
1. **X-Company-Id Header** - Explicit company selection in API request
2. **Session Cookie** - User's selected company from session
3. **User's Default Company** - User's default company from user profile
4. **Query Parameter** - company_id parameter in URL

### Example Headers
```
X-Company-Id: COMP001
```

### Example Cookie
```
company_id=COMP001; expires=...
```

---

## Company Validation Rules

### Existence Validation
- Company ID must not be empty
- Company must exist in database
- Company must be active

### Access Validation
- User must have access to company
- User's role must have company access permission
- Company must be in user's assigned companies

### Context Validation
- Company context must be initialized before operations
- Company context must not be expired
- Company context must be consistent with other contexts

---

## Multi-Company Architecture

### Database Strategy
**Current:** Single database for all companies  
**Future:** Per-company databases or shared database with company isolation

### Data Isolation
**Current:** All data in single database with company_id column  
**Future:** Per-company databases or company_id partitioning

### Connection Factory
**Current:** Single connection to default database  
**Future:** Connection factory switches database based on company context

### Implementation Path
```
Phase 1: Single database with company_id column (Current)
Phase 2: Add company_id to all tables
Phase 3: Implement company filtering in repositories
Phase 4: Add per-company database support
Phase 5: Implement database switching in connection factory
```

---

## Company Context Usage

### Controller Usage
```csharp
[ApiController]
[Route("api/[controller]")]
public class AccountController : ControllerBase
{
    private readonly IContextProvider _contextProvider;

    public AccountController(IContextProvider contextProvider)
    {
        _contextProvider = contextProvider;
    }

    [HttpGet]
    public async Task<IActionResult> GetAccounts()
    {
        var companyId = _contextProvider.CurrentCompanyId;
        // Use companyId for filtering
        return Ok();
    }
}
```

### Service Usage
```csharp
public class AccountService : IAccountService
{
    private readonly IContextProvider _contextProvider;

    public AccountService(IContextProvider contextProvider)
    {
        _contextProvider = contextProvider;
    }

    public async Task<AccountDto> CreateAccountAsync(CreateAccountRequest request)
    {
        var companyId = _contextProvider.CurrentCompanyId;
        // Create account for current company
        return accountDto;
    }
}
```

### Repository Usage
```csharp
public class AccountRepository : IAccountRepository
{
    private readonly IContextProvider _contextProvider;

    public AccountRepository(IContextProvider contextProvider)
    {
        _contextProvider = contextProvider;
    }

    public async Task<Account?> GetByIdAsync(int id)
    {
        var companyId = _contextProvider.CurrentCompanyId;
        // Filter by company_id
        var sql = "SELECT * FROM SocAccount WHERE SocAccId = @id AND CompanyId = @companyId";
        return account;
    }
}
```

---

## Company Switching API

### Switch Company Request
```http
POST /api/context/switch-company
Content-Type: application/json

{
  "companyId": "COMP002"
}
```

### Switch Company Response
```json
{
  "success": true,
  "message": "Company switched successfully",
  "data": {
    "companyId": "COMP002",
    "companyCode": "COMP002",
    "companyName": "Second Company Ltd"
  }
}
```

---

## Company Events

### CompanySwitchedEvent
```csharp
public class CompanySwitchedEvent
{
    public string UserId { get; set; }
    public string PreviousCompanyId { get; set; }
    public string NewCompanyId { get; set; }
    public DateTime SwitchedAt { get; set; }
}
```

### Event Handlers
- Clear user-specific cache for previous company
- Load user-specific data for new company
- Update UI with new company information
- Audit company switch

---

## Error Handling

### Company Not Found
```json
{
  "success": false,
  "message": "Company not found",
  "errors": ["Company with ID 'COMP999' does not exist"]
}
```

### Access Denied
```json
{
  "success": false,
  "message": "Access denied",
  "errors": ["User does not have access to company 'COMP002'"]
}
```

### Company Inactive
```json
{
  "success": false,
  "message": "Company inactive",
  "errors": ["Company 'COMP002' is not active"]
}
```

---

## Future Enhancements

### Company Settings
- Company-specific settings
- Company-specific configurations
- Company-specific workflows

### Company Hierarchy
- Parent company relationships
- Sub-company management
- Consolidated reporting

### Company Features
- Feature flags per company
- Module availability per company
- Customizations per company

### Company Analytics
- Company usage statistics
- Company performance metrics
- Company comparison reports
