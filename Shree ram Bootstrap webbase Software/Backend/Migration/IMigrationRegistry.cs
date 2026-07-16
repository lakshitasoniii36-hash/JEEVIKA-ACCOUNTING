namespace Migration;

/// <summary>
/// Migration status enumeration
/// </summary>
public enum MigrationStatus
{
    /// <summary>
    /// Module is in legacy state (not migrated)
    /// </summary>
    Legacy,

    /// <summary>
    /// Module is currently being migrated
    /// </summary>
    Migrating,

    /// <summary>
    /// Module migration is completed
    /// </summary>
    Completed,

    /// <summary>
    /// Module migration is rolled back
    /// </summary>
    RolledBack
}

/// <summary>
/// Module migration information
/// </summary>
public class ModuleMigrationInfo
{
    /// <summary>
    /// Gets or sets the module name
    /// </summary>
    public string ModuleName { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the migration status
    /// </summary>
    public MigrationStatus Status { get; set; }

    /// <summary>
    /// Gets or sets the migration start date
    /// </summary>
    public DateTime? StartedAt { get; set; }

    /// <summary>
    /// Gets or sets the migration completion date
    /// </summary>
    public DateTime? CompletedAt { get; set; }

    /// <summary>
    /// Gets or sets the migration notes
    /// </summary>
    public string? Notes { get; set; }

    /// <summary>
    /// Gets or sets the migrated by user
    /// </summary>
    public string? MigratedBy { get; set; }
}

/// <summary>
/// Migration registry interface for tracking module migrations
/// </summary>
public interface IMigrationRegistry
{
    /// <summary>
    /// Registers a module for migration tracking
    /// </summary>
    /// <param name="moduleName">Module name</param>
    void RegisterModule(string moduleName);

    /// <summary>
    /// Gets the migration status of a module
    /// </summary>
    /// <param name="moduleName">Module name</param>
    /// <returns>Module migration info</returns>
    ModuleMigrationInfo? GetModuleStatus(string moduleName);

    /// <summary>
    /// Updates the migration status of a module
    /// </summary>
    /// <param name="moduleName">Module name</param>
    /// <param name="status">Migration status</param>
    /// <param name="notes">Migration notes</param>
    void UpdateModuleStatus(string moduleName, MigrationStatus status, string? notes = null);

    /// <summary>
    /// Gets all module migration statuses
    /// </summary>
    /// <returns>All module migration info</returns>
    IEnumerable<ModuleMigrationInfo> GetAllModuleStatuses();

    /// <summary>
    /// Gets modules by migration status
    /// </summary>
    /// <param name="status">Migration status</param>
    /// <returns>Modules with specified status</returns>
    IEnumerable<ModuleMigrationInfo> GetModulesByStatus(MigrationStatus status);
}

/// <summary>
/// Default migration registry implementation
/// </summary>
public class MigrationRegistry : IMigrationRegistry
{
    private readonly Dictionary<string, ModuleMigrationInfo> _modules = new();

    public void RegisterModule(string moduleName)
    {
        if (!_modules.ContainsKey(moduleName))
        {
            _modules[moduleName] = new ModuleMigrationInfo
            {
                ModuleName = moduleName,
                Status = MigrationStatus.Legacy
            };
        }
    }

    public ModuleMigrationInfo? GetModuleStatus(string moduleName)
    {
        return _modules.TryGetValue(moduleName, out var info) ? info : null;
    }

    public void UpdateModuleStatus(string moduleName, MigrationStatus status, string? notes = null)
    {
        if (!_modules.ContainsKey(moduleName))
        {
            RegisterModule(moduleName);
        }

        var info = _modules[moduleName];
        info.Status = status;
        info.Notes = notes;

        if (status == MigrationStatus.Migrating && info.StartedAt == null)
        {
            info.StartedAt = DateTime.UtcNow;
        }

        if (status == MigrationStatus.Completed && info.CompletedAt == null)
        {
            info.CompletedAt = DateTime.UtcNow;
        }
    }

    public IEnumerable<ModuleMigrationInfo> GetAllModuleStatuses()
    {
        return _modules.Values;
    }

    public IEnumerable<ModuleMigrationInfo> GetModulesByStatus(MigrationStatus status)
    {
        return _modules.Values.Where(m => m.Status == status);
    }
}
