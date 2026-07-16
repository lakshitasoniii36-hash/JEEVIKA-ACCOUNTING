namespace Core.Constants;

/// <summary>
/// Standard error codes for the ERP system
/// </summary>
public static class ErrorCodes
{
    // General Errors (1000-1999)
    public const string GENERAL_ERROR = "ERR_1000";
    public const string VALIDATION_ERROR = "ERR_1001";
    public const string NOT_FOUND = "ERR_1002";
    public const string UNAUTHORIZED = "ERR_1003";
    public const string FORBIDDEN = "ERR_1004";
    public const string CONFLICT = "ERR_1005";
    public const string OPERATION_FAILED = "ERR_1006";

    // Database Errors (2000-2999)
    public const string DATABASE_ERROR = "ERR_2000";
    public const string CONNECTION_ERROR = "ERR_2001";
    public const string QUERY_ERROR = "ERR_2002";
    public const string TRANSACTION_ERROR = "ERR_2003";
    public const string CONSTRAINT_VIOLATION = "ERR_2004";

    // Authentication Errors (3000-3999)
    public const string AUTHENTICATION_FAILED = "ERR_3000";
    public const string INVALID_CREDENTIALS = "ERR_3001";
    public const string TOKEN_EXPIRED = "ERR_3002";
    public const string TOKEN_INVALID = "ERR_3003";
    public const string ACCOUNT_LOCKED = "ERR_3004";
    public const string ACCOUNT_DISABLED = "ERR_3005";

    // Authorization Errors (4000-4999)
    public const string ACCESS_DENIED = "ERR_4000";
    public const string INSUFFICIENT_PERMISSIONS = "ERR_4001";
    public const string ROLE_NOT_FOUND = "ERR_4002";
    public const string PERMISSION_NOT_FOUND = "ERR_4003";

    // Company Errors (5000-5999)
    public const string COMPANY_NOT_FOUND = "ERR_5000";
    public const string COMPANY_ALREADY_EXISTS = "ERR_5001";
    public const string COMPANY_INACTIVE = "ERR_5002";
    public const string COMPANY_CONTEXT_MISSING = "ERR_5003";

    // Assessment Year Errors (6000-6999)
    public const string YEAR_NOT_FOUND = "ERR_6000";
    public const string YEAR_ALREADY_EXISTS = "ERR_6001";
    public const string YEAR_CLOSED = "ERR_6002";
    public const string YEAR_CONTEXT_MISSING = "ERR_6003";

    // Accounting Errors (7000-7999)
    public const string ACCOUNT_NOT_FOUND = "ERR_7000";
    public const string ACCOUNT_ALREADY_EXISTS = "ERR_7001";
    public const string VOUCHER_NOT_FOUND = "ERR_7002";
    public const string VOUCHER_ALREADY_POSTED = "ERR_7003";
    public const string VOUCHER_CANNOT_DELETE = "ERR_7004";
    public const string INVALID_DEBIT_CREDIT = "ERR_7005";
    public const string BALANCE_MISMATCH = "ERR_7006";

    // Inventory Errors (8000-8999)
    public const string ITEM_NOT_FOUND = "ERR_8000";
    public const string ITEM_ALREADY_EXISTS = "ERR_8001";
    public const string INSUFFICIENT_STOCK = "ERR_8002";
    public const string WAREHOUSE_NOT_FOUND = "ERR_8003";

    // Member Errors (9000-9999)
    public const string MEMBER_NOT_FOUND = "ERR_9000";
    public const string MEMBER_ALREADY_EXISTS = "ERR_9001";
    public const string MEMBER_INACTIVE = "ERR_9002";
}
