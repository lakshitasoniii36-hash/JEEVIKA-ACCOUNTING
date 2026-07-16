# Migration Report Template

**Module Name:** [Module Name]  
**Migration Date:** [Date]  
**Migrated By:** [Name]  
**Status:** [Legacy/Migrating/Completed/RolledBack]

---

## Executive Summary

[Brief summary of the migration]

---

## Migration Details

### Module Information
- **Module Name:** [Module Name]
- **Module Type:** [Accounting/Inventory/CRM/HR/Payroll/Billing/Society/Reporting/Settings]
- **Current Status:** [Legacy/Migrating/Completed/RolledBack]
- **Migration Started:** [Date]
- **Migration Completed:** [Date]
- **Migration Duration:** [Duration]

### Migration Scope
- **Controllers Migrated:** [List of controllers]
- **Services Migrated:** [List of services]
- **Repositories Migrated:** [List of repositories]
- **Database Changes:** [None/Schema changes/Data changes]
- **API Changes:** [None/Endpoint changes/Response changes]

---

## Implementation Details

### New Components Created
- [ ] Repository: [Repository Name]
- [ ] Service: [Service Name]
- [ ] Command Handlers: [List of command handlers]
- [ ] Query Handlers: [List of query handlers]
- [ ] Validators: [List of validators]
- [ ] DTOs: [List of DTOs]

### Adapters Created
- [ ] Controller Adapter: [Adapter Name]
- [ ] Repository Adapter: [Adapter Name]
- [ ] Service Adapter: [Adapter Name]

### Feature Flags Configured
- [ ] UseNewImplementation_[ModuleName]: [Enabled/Disabled]
- [ ] UseNewRepository_[ModuleName]: [Enabled/Disabled]
- [ ] UseNewService_[ModuleName]: [Enabled/Disabled]
- [ ] UseNewValidation_[ModuleName]: [Enabled/Disabled]

---

## Testing Results

### Unit Tests
- **Total Tests:** [Number]
- **Passed:** [Number]
- **Failed:** [Number]
- **Skipped:** [Number]
- **Coverage:** [Percentage]

### Integration Tests
- **Total Tests:** [Number]
- **Passed:** [Number]
- **Failed:** [Number]
- **Skipped:** [Number]

### Performance Tests
- **Legacy Implementation:** [Time]
- **New Implementation:** [Time]
- **Performance Change:** [Percentage]
- **Acceptable:** [Yes/No]

### Compatibility Tests
- **Compatibility Status:** [Compatible/Not Compatible]
- **Compatibility Issues:** [List of issues]
- **Issues Resolved:** [Yes/No]

---

## Issues Encountered

### Issues During Migration
1. [Issue Description]
   - **Severity:** [Low/Medium/High/Critical]
   - **Status:** [Open/In Progress/Resolved]
   - **Resolution:** [Resolution description]

### Issues During Testing
1. [Issue Description]
   - **Severity:** [Low/Medium/High/Critical]
   - **Status:** [Open/In Progress/Resolved]
   - **Resolution:** [Resolution description]

### Issues During Deployment
1. [Issue Description]
   - **Severity:** [Low/Medium/High/Critical]
   - **Status:** [Open/In Progress/Resolved]
   - **Resolution:** [Resolution description]

---

## Rollback Information

### Rollback Performed
- **Rollback Date:** [Date]
- **Rollback Reason:** [Reason]
- **Rollback Duration:** [Duration]

### Rollback Steps Taken
1. [Step 1]
2. [Step 2]
3. [Step 3]

### Rollback Validation
- **Legacy Implementation Works:** [Yes/No]
- **Data Integrity Verified:** [Yes/No]
- **User Impact:** [None/Minor/Major]

---

## Lessons Learned

### What Went Well
- [Success factor 1]
- [Success factor 2]
- [Success factor 3]

### What Could Be Improved
- [Improvement area 1]
- [Improvement area 2]
- [Improvement area 3]

### Recommendations for Future Migrations
- [Recommendation 1]
- [Recommendation 2]
- [Recommendation 3]

---

## Next Steps

### If Completed
- [ ] Remove legacy code
- [ ] Update documentation
- [ ] Archive migration artifacts
- [ ] Update migration registry

### If Rolled Back
- [ ] Fix issues
- [ ] Re-test
- [ ] Schedule re-migration
- [ ] Update migration registry

### If In Progress
- [ ] Continue implementation
- [ ] Complete testing
- [ ] Schedule deployment
- [ ] Update migration registry

---

## Sign-Off

### Migration Team
- **Migration Lead:** [Name] - [Signature]
- **Developer:** [Name] - [Signature]
- **Tester:** [Name] - [Signature]

### Approval
- **Technical Lead:** [Name] - [Signature] - [Date]
- **Product Owner:** [Name] - [Signature] - [Date]
- **Operations:** [Name] - [Signature] - [Date]

---

## Attachments
- [ ] Migration Plan
- [ ] Test Results
- [ ] Performance Metrics
- [ ] Compatibility Report
- [ ] Rollback Plan
