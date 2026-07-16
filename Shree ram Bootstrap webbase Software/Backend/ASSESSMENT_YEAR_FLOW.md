# Assessment Year Flow Documentation

**Version:** 1.0  
**Last Updated:** 2026-07-07  
**Purpose:** Document assessment year context management flow

---

## Overview

The Assessment Year Engine manages financial year context with support for multiple years, carry forward, freeze, close, and reopen operations. Infrastructure is complete for future business logic implementation.

---

## Assessment Year Context Flow

```
Company Context Set
    ↓
Get Company's Default Assessment Year
    ↓
Set Assessment Year Context
    ├─ YearId
    ├─ Year (e.g., "2024-25")
    ├─ YearStart (April 1)
    └─ YearEnd (March 31)
    ↓
Validate Assessment Year Exists
    ↓
Validate Assessment Year Belongs to Company
    ↓
Validate Assessment Year Accessible
    ↓
Assessment Year Context Active
```

---

## Assessment Year Switch Flow

```
User Requests Year Switch
    ↓
Validate Year Belongs to Current Company
    ↓
Validate Year Is Accessible (Not Closed/Archived)
    ↓
Clear Current Year Context
    ↓
Set New Year Context
    ↓
Publish Year Switched Event
    ↓
Return Success Response
```

---

## Assessment Year Status Flow

### Open → Frozen
```
User Requests Freeze Year
    ↓
Validate Year Is Open
    ↓
Validate No Pending Transactions
    ↓
Set Year Status to Frozen
    ↓
Publish Year Frozen Event
    ↓
Return Success Response
```

### Frozen → Open
```
User Requests Reopen Year
    ↓
Validate Year Is Frozen
    ↓
Validate User Has Permission
    ↓
Set Year Status to Open
    ↓
Publish Year Reopened Event
    ↓
Return Success Response
```

### Open → Closed
```
User Requests Close Year
    ↓
Validate Year Is Open or Frozen
    ↓
Validate All Transactions Posted
    ↓
Validate Year End Date Reached
    ↓
Set Year Status to Closed
    ↓
Publish Year Closed Event
    ↓
Return Success Response
```

### Closed → Archived
```
User Requests Archive Year
    ↓
Validate Year Is Closed
    ↓
Validate Year Is Older Than X Years
    ↓
Set Year Status to Archived
    ↓
Publish Year Archived Event
    ↓
Return Success Response
```

---

## Assessment Year Engine Components

### IAssessmentYearEngine Interface
**Purpose:** Manage assessment year context and operations

**Methods:**
- `SetAssessmentYearAsync(yearId, year, yearStart, yearEnd)` - Set current year
- `ClearAssessmentYearAsync()` - Clear current year
- `YearExistsAsync(yearId)` - Validate year exists
- `GetAvailableYearsAsync(companyId)` - Get all years for company
- `GetAssessmentYearAsync(yearId)` - Get year information
- `GetPreviousYearAsync(currentYearId)` - Get previous year
- `GetNextYearAsync(currentYearId)` - Get next year

**Properties:**
- `CurrentYearId` - Currently selected year ID
- `CurrentYear` - Currently selected year (e.g., "2024-25")
- `YearStart` - Financial year start date
- `YearEnd` - Financial year end date
- `YearStatus` - Current year status
- `HasYearContext` - Whether year context is set

### AssessmentYearStatus Enumeration
- `Open` - Year is open for transactions
- `Frozen` - Year is frozen, no new transactions
- `Closed` - Year is closed, read-only
- `Archived` - Year is archived, historical only

### AssessmentYearInfo Model
**Properties:**
- `YearId` - Unique year identifier
- `CompanyId` - Company identifier
- `Year` - Year display (e.g., "2024-25")
- `YearStart` - Financial year start date
- `YearEnd` - Financial year end date
- `Status` - Current status
- `IsCurrent` - Whether this is the current year
- `CreatedDate` - Year creation date
- `ModifiedDate` - Last modification date

---

## Assessment Year Resolution Sources

### Priority Order
1. **X-Year-Id Header** - Explicit year selection in API request
2. **Session Cookie** - User's selected year from session
3. **Company's Default Year** - Company's default assessment year
4. **Query Parameter** - year_id parameter in URL

### Example Headers
```
X-Year-Id: YEAR2024
```

### Example Cookie
```
year_id=YEAR2024; expires=...
```

---

## Assessment Year Validation Rules

### Existence Validation
- Year ID must not be empty
- Year must exist in database
- Year must belong to current company

### Access Validation
- Year must be accessible (not closed/archived)
- User must have permission to access year
- Year must be within user's allowed years

### Context Validation
- Year context must be initialized before operations
- Year context must not be expired
- Year context must be consistent with company context

---

## Carry Forward Infrastructure

### Carry Forward Flow (Infrastructure Only)
```
Year Closed
    ↓
Prepare Carry Forward
    ├─ Get Opening Balances from Closed Year
    ├─ Calculate Carry Forward Amounts
    └─ Create Opening Balances for Next Year
    ↓
Validate Carry Forward Data
    ↓
Publish Carry Forward Event
    ↓
Return Success Response
```

### Carry Forward Components (Future)
- `ICarryForwardService` - Carry forward business logic
- `CarryForwardValidator` - Validate carry forward data
- `CarryForwardEvent` - Carry forward event
- `CarryForwardHandler` - Handle carry forward events

---

## Database Switching Infrastructure

### Database Switch Flow (Infrastructure Only)
```
Year Context Changed
    ↓
Check if Year Has Separate Database
    ↓
If Yes:
    ├─ Get Database Path for Year
    ├─ Update Database Context
    └─ Switch Connection Factory
    ↓
If No:
    └─ Continue with Current Database
    ↓
Publish Database Switched Event
```

### Database Context Integration
```csharp
public class AssessmentYearEngine : IAssessmentYearEngine
{
    private readonly IDatabaseContext _databaseContext;

    public async Task SetAssessmentYearAsync(string yearId, string year, DateTime yearStart, DateTime yearEnd)
    {
        // Set year context
        _currentYearId = yearId;
        _currentYear = year;
        _yearStart = yearStart;
        _yearEnd = yearEnd;

        // Future: Switch database if year has separate database
        // var yearInfo = await GetAssessmentYearAsync(yearId);
        // if (yearInfo?.HasSeparateDatabase == true)
        // {
        //     await _databaseContext.SetDatabaseAsync(
        //         yearInfo.DatabaseName,
        //         yearInfo.DatabasePath,
        //         yearInfo.ConnectionString
        //     );
        // }

        return Task.CompletedTask;
    }
}
```

---

## Assessment Year Context Usage

### Controller Usage
```csharp
[ApiController]
[Route("api/[controller]")]
public class VoucherController : ControllerBase
{
    private readonly IContextProvider _contextProvider;

    public VoucherController(IContextProvider contextProvider)
    {
        _contextProvider = contextProvider;
    }

    [HttpGet]
    public async Task<IActionResult> GetVouchers()
    {
        var yearId = _contextProvider.CurrentYearId;
        var yearStart = _contextProvider.CurrentYearStart;
        var yearEnd = _contextProvider.CurrentYearEnd;

        // Filter vouchers by year
        return Ok();
    }
}
```

### Service Usage
```csharp
public class VoucherService : IVoucherService
{
    private readonly IContextProvider _contextProvider;

    public VoucherService(IContextProvider contextProvider)
    {
        _contextProvider = contextProvider;
    }

    public async Task<VoucherDto> CreateVoucherAsync(CreateVoucherRequest request)
    {
        var yearId = _contextProvider.CurrentYearId;
        var yearEnd = _contextProvider.CurrentYearEnd;

        // Validate voucher date is within year
        if (request.VoucherDate > yearEnd)
        {
            throw new ValidationException("Voucher date cannot be after year end");
        }

        // Create voucher
        return voucherDto;
    }
}
```

---

## Assessment Year Events

### YearSwitchedEvent
```csharp
public class YearSwitchedEvent
{
    public string UserId { get; set; }
    public string CompanyId { get; set; }
    public string PreviousYearId { get; set; }
    public string NewYearId { get; set; }
    public DateTime SwitchedAt { get; set; }
}
```

### YearFrozenEvent
```csharp
public class YearFrozenEvent
{
    public string YearId { get; set; }
    public string CompanyId { get; set; }
    public string UserId { get; set; }
    public DateTime FrozenAt { get; set; }
}
```

### YearClosedEvent
```csharp
public class YearClosedEvent
{
    public string YearId { get; set; }
    public string CompanyId { get; set; }
    public string UserId { get; set; }
    public DateTime ClosedAt { get; set; }
}
```

---

## Error Handling

### Year Not Found
```json
{
  "success": false,
  "message": "Assessment year not found",
  "errors": ["Assessment year with ID 'YEAR9999' does not exist"]
}
```

### Year Not Accessible
```json
{
  "success": false,
  "message": "Year not accessible",
  "errors": ["Assessment year 'YEAR2023' is closed and cannot be modified"]
}
```

### Year Belongs to Different Company
```json
{
  "success": false,
  "message": "Year belongs to different company",
  "errors": ["Assessment year 'YEAR2024' belongs to company 'COMP002', not current company 'COMP001'"]
}
```

---

## Future Enhancements

### Year Templates
- Pre-configured year templates
- Quick year creation from templates
- Year configuration presets

### Year Workflows
- Year closing workflow
- Carry forward workflow
- Year reopening workflow

### Year Analytics
- Year comparison reports
- Year performance metrics
- Year trend analysis

### Year Permissions
- Year-specific permissions
- Year-based access control
- Year approval workflows
