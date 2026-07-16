namespace Core.Helpers;

/// <summary>
/// Helper methods for date/time operations
/// </summary>
public static class DateTimeHelper
{
    /// <summary>
    /// Gets the current UTC datetime
    /// </summary>
    public static DateTime UtcNow => DateTime.UtcNow;

    /// <summary>
    /// Converts datetime to ISO 8601 string
    /// </summary>
    public static string ToIsoString(DateTime dateTime)
    {
        return dateTime.ToString("o");
    }

    /// <summary>
    /// Parses ISO 8601 string to datetime
    /// </summary>
    public static DateTime FromIsoString(string isoString)
    {
        return DateTime.Parse(isoString, null, System.Globalization.DateTimeStyles.RoundtripKind);
    }

    /// <summary>
    /// Gets the start of the financial year (April 1st)
    /// </summary>
    public static DateTime GetFinancialYearStart(int year)
    {
        return new DateTime(year, 4, 1);
    }

    /// <summary>
    /// Gets the end of the financial year (March 31st)
    /// </summary>
    public static DateTime GetFinancialYearEnd(int year)
    {
        return new DateTime(year + 1, 3, 31, 23, 59, 59);
    }

    /// <summary>
    /// Determines if a date falls within the specified financial year
    /// </summary>
    public static bool IsInFinancialYear(DateTime date, int financialYear)
    {
        var start = GetFinancialYearStart(financialYear);
        var end = GetFinancialYearEnd(financialYear);
        return date >= start && date <= end;
    }
}
