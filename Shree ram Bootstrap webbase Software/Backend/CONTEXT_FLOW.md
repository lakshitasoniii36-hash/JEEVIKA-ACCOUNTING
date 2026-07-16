# ERP Context Flow Documentation

**Version:** 1.0  
**Last Updated:** 2026-07-07  
**Purpose:** Document the complete context flow for the ERP platform

---

## Overview

The ERP Context Engine provides centralized management of all contextual information required for request processing. Context flows from HTTP requests through middleware, validation, and into controllers/services via dependency injection.

---

## Context Flow Diagram

```
HTTP Request
    ↓
Context Middleware
    ├─ Resolve User Context (from headers/cookies/JWT)
    ├─ Resolve Company Context (from headers/cookies/session)
    ├─ Resolve Assessment Year Context (from headers/cookies/session)
    ├─ Resolve Branch Context (from headers/cookies/session)
    ├─ Resolve Language (from Accept-Language header)
    ├─ Resolve Currency (from header/cookie/company settings)
    └─ Resolve Timezone (from header/cookie/user settings)
    ↓
Context Validator
    ├─ Validate Company Exists
    ├─ Validate Assessment Year Exists
    ├─ Validate Context Initialized
    └─ Validate Context Not Expired
    ↓
Controller (via IContextProvider)
    ├─ CurrentUserId
    ├─ CurrentCompanyId
    ├─ CurrentYearId
    ├─ CurrentBranch
    ├─ CurrentLanguage
    ├─ CurrentCurrency
    ├─ CurrentTimezone
    └─ CurrentPermissions
    ↓
Service (via IContextProvider)
    └─ Same context information available
```

---

## Context Components

### 1. Context Resolver (IContextResolver)
**Purpose:** Resolves context information from HTTP requests

**Responsibilities:**
- Extract user context from headers, cookies, or JWT tokens
- Extract company context from headers, cookies, or session
- Extract assessment year context from headers, cookies, or session
- Extract branch context from headers, cookies, or session
- Resolve language from Accept-Language header or cookie
- Resolve currency from header, cookie, or company settings
- Resolve timezone from header, cookie, or user settings

**Implementation Status:** Infrastructure complete, placeholder implementations ready for JWT/header integration

### 2. Context Validator (IContextValidator)
**Purpose:** Validates context information before request processing

**Responsibilities:**
- Validate company exists in database
- Validate assessment year exists in database
- Validate context is initialized (user, company, year)
- Validate context is not expired (session, token)
- Validate user has access to company
- Validate assessment year is accessible (not closed/archived)

**Implementation Status:** Infrastructure complete, repository integration pending

### 3. Context Provider (IContextProvider)
**Purpose:** Provides context information to controllers and services

**Responsibilities:**
- Expose all context properties as read-only
- Provide permission checking methods
- Provide role checking methods
- Centralized access point for context

**Implementation Status:** Complete

### 4. Context Middleware
**Purpose:** Automatic context resolution and validation for each request

**Responsibilities:**
- Invoke context resolver for each request
- Invoke context validator for each request
- Return error response if validation fails
- Continue to next middleware if validation succeeds

**Implementation Status:** Complete

### 5. Application Context Manager (IApplicationContextManager)
**Purpose:** Centralized management of all contexts

**Responsibilities:**
- Initialize default context values
- Validate all contexts
- Get context snapshot
- Set context from snapshot
- Clear all contexts

**Implementation Status:** Complete

---

## Context Lifecycle

### Request Lifecycle

1. **HTTP Request Received**
   - Context middleware intercepts request

2. **Context Resolution**
   - ContextResolver extracts context from HTTP request
   - Context is set in ApplicationContextManager

3. **Context Validation**
   - ContextValidator validates all contexts
   - Returns error if validation fails
   - Continues if validation succeeds

4. **Controller Execution**
   - Controller receives IContextProvider via DI
   - Controller accesses context properties
   - Controller performs business logic

5. **Service Execution**
   - Service receives IContextProvider via DI
   - Service accesses context properties
   - Service performs business logic

6. **Response Returned**
   - Context is cleared if needed (optional)

### Session Lifecycle

1. **User Login**
   - User context set from authentication
   - Company context set from user's default company
   - Assessment year context set from company's default year

2. **Context Switch**
   - User can switch company (if multi-company)
   - User can switch assessment year
   - Context is validated after switch

3. **User Logout**
   - All contexts cleared
   - Session terminated

---

## Context Resolution Sources

### User Context
**Priority Order:**
1. JWT token (Authorization header)
2. Session cookie
3. API key (X-API-Key header)
4. Basic authentication (Authorization header)

### Company Context
**Priority Order:**
1. X-Company-Id header
2. Session cookie
3. User's default company
4. Query parameter (company_id)

### Assessment Year Context
**Priority Order:**
1. X-Year-Id header
2. Session cookie
3. Company's default year
4. Query parameter (year_id)

### Branch Context
**Priority Order:**
1. X-Branch-Id header
2. Session cookie
3. User's default branch
4. Query parameter (branch_id)

### Language
**Priority Order:**
1. Accept-Language header
2. X-Language header
3. Session cookie
4. User's language preference
5. Default: en-US

### Currency
**Priority Order:**
1. X-Currency header
2. Session cookie
3. Company's default currency
4. User's currency preference
5. Default: INR

### Timezone
**Priority Order:**
1. X-Timezone header
2. Session cookie
3. User's timezone preference
4. Company's default timezone
5. Default: Asia/Kolkata

---

## Context Validation Rules

### Company Validation
- Company ID must not be empty
- Company must exist in database
- User must have access to company
- Company must be active

### Assessment Year Validation
- Assessment Year ID must not be empty
- Assessment Year must exist in database
- Assessment Year must belong to current company
- Assessment Year must be accessible (not closed/archived)

### User Validation
- User must be authenticated
- User session must not be expired
- User must have valid permissions

### Context Validation
- All required contexts must be initialized
- Context must not be expired
- Context must be consistent (company/year relationship)

---

## Error Handling

### Context Resolution Errors
- **Missing Context:** Return 400 Bad Request with error message
- **Invalid Context:** Return 400 Bad Request with error message
- **Expired Context:** Return 401 Unauthorized

### Context Validation Errors
- **Company Not Found:** Return 404 Not Found
- **Assessment Year Not Found:** Return 404 Not Found
- **Access Denied:** Return 403 Forbidden
- **Context Expired:** Return 401 Unauthorized

---

## Usage Examples

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
        var yearId = _contextProvider.CurrentYearId;
        var userId = _contextProvider.CurrentUserId;

        // Use context for business logic
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
        var yearId = _contextProvider.CurrentYearId;

        // Check permission
        if (!_contextProvider.HasPermission(PermissionCodes.ACCOUNT_CREATE))
        {
            throw new ForbiddenException(PermissionCodes.ACCOUNT_CREATE);
        }

        // Business logic
        return accountDto;
    }
}
```

---

## Future Enhancements

### Context Caching
- Cache resolved context for performance
- Invalidate cache on context change
- Cache expiration policies

### Context Events
- Publish events on context change
- Subscribe to context change events
- Audit context changes

### Context History
- Track context changes over time
- Provide context change history
- Enable context rollback

### Context Analytics
- Track context usage patterns
- Analyze context switch frequency
- Optimize context resolution
