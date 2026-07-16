namespace Shared.Enums;

/// <summary>
/// Account types for the accounting system
/// </summary>
public enum AccountType
{
    Asset = 1,
    Liability = 2,
    Income = 3,
    Expense = 4,
    Capital = 5
}

/// <summary>
/// Debit/Credit indicators
/// </summary>
public enum DrCrType
{
    Dr = 1,
    Cr = 2
}

/// <summary>
/// Voucher types
/// </summary>
public enum VoucherType
{
    Receipt = 1,
    Payment = 2,
    Journal = 3,
    Contra = 4,
    Sales = 5,
    Purchase = 6,
    DebitNote = 7,
    CreditNote = 8
}

/// <summary>
/// User types
/// </summary>
public enum UserType
{
    Admin = 1,
    Manager = 2,
    Operator = 3,
    Viewer = 4
}

/// <summary>
/// Status types
/// </summary>
public enum StatusType
{
    Active = 1,
    Inactive = 2,
    Deleted = 3,
    Pending = 4
}
