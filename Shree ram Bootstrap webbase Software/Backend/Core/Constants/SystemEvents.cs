namespace Core.Constants;

/// <summary>
/// Standard system event names for the ERP system
/// </summary>
public static class SystemEvents
{
    // Authentication Events
    public const string USER_REGISTERED = "UserRegistered";
    public const string USER_LOGGED_IN = "UserLoggedIn";
    public const string USER_LOGGED_OUT = "UserLoggedOut";
    public const string PASSWORD_CHANGED = "PasswordChanged";
    public const string ACCOUNT_LOCKED = "AccountLocked";

    // Company Events
    public const string COMPANY_CREATED = "CompanyCreated";
    public const string COMPANY_UPDATED = "CompanyUpdated";
    public const string COMPANY_DELETED = "CompanyDeleted";
    public const string COMPANY_CONTEXT_CHANGED = "CompanyContextChanged";

    // Assessment Year Events
    public const string YEAR_CREATED = "AssessmentYearCreated";
    public const string YEAR_CLOSED = "AssessmentYearClosed";
    public const string YEAR_OPENED = "AssessmentYearOpened";
    public const string YEAR_CONTEXT_CHANGED = "YearContextChanged";

    // Accounting Events
    public const string ACCOUNT_CREATED = "AccountCreated";
    public const string ACCOUNT_UPDATED = "AccountUpdated";
    public const string ACCOUNT_DELETED = "AccountDeleted";
    public const string VOUCHER_CREATED = "VoucherCreated";
    public const string VOUCHER_POSTED = "VoucherPosted";
    public const string VOUCHER_DELETED = "VoucherDeleted";
    public const string RECEIPT_SAVED = "ReceiptSaved";
    public const string PAYMENT_SAVED = "PaymentSaved";
    public const string LEDGER_UPDATED = "LedgerUpdated";

    // Member Events
    public const string MEMBER_CREATED = "MemberCreated";
    public const string MEMBER_UPDATED = "MemberUpdated";
    public const string MEMBER_DELETED = "MemberDeleted";
    public const string MEMBER_TRANSFERRED = "MemberTransferred";

    // Billing Events
    public const string BILL_GENERATED = "BillGenerated";
    public const string BILL_PAID = "BillPaid";
    public const string BILL_OVERDUE = "BillOverdue";

    // Report Events
    public const string REPORT_GENERATED = "ReportGenerated";
    public const string REPORT_EXPORTED = "ReportExported";

    // System Events
    public const string BACKUP_COMPLETED = "BackupCompleted";
    public const string BACKUP_FAILED = "BackupFailed";
    public const string DATA_IMPORTED = "DataImported";
    public const string DATA_EXPORTED = "DataExported";
}
