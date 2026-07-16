namespace Shared.Interfaces;

/// <summary>
/// Interface for audit logging operations
/// </summary>
public interface IAuditService
{
    /// <summary>
    /// Logs an audit entry
    /// </summary>
    Task LogAuditAsync(AuditEntry entry);

    /// <summary>
    /// Gets audit entries for an entity
    /// </summary>
    Task<IEnumerable<AuditEntry>> GetAuditHistoryAsync(string entityType, string entityId);

    /// <summary>
    /// Gets audit entries for a user
    /// </summary>
    Task<IEnumerable<AuditEntry>> GetUserAuditHistoryAsync(string userId, DateTime from, DateTime to);
}

/// <summary>
/// Audit entry model
/// </summary>
public class AuditEntry
{
    public string UserId { get; set; } = string.Empty;
    public string UserName { get; set; } = string.Empty;
    public string CompanyId { get; set; } = string.Empty;
    public string AssessmentYearId { get; set; } = string.Empty;
    public string EntityType { get; set; } = string.Empty;
    public string EntityId { get; set; } = string.Empty;
    public string Action { get; set; } = string.Empty;
    public string? OldValue { get; set; }
    public string? NewValue { get; set; }
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    public string MachineName { get; set; } = Environment.MachineName;
    public string? IpAddress { get; set; }
}
