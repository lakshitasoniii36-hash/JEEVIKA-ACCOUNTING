# Future Database Switching Documentation

**Version:** 1.0  
**Last Updated:** 2026-07-07  
**Purpose:** Document database switching infrastructure for future multi-database support

---

## Overview

The ERP platform architecture includes infrastructure for future database switching. Although the current implementation uses a single SQLite database, the connection factory and context engine are designed to support multiple databases without code changes.

---

## Database Switching Architecture

### Current State
- **Single Database:** All data in one SQLite database
- **Connection Factory:** Single connection factory
- **Context Engine:** Single database context

### Future State
- **Multiple Databases:** Per-company, per-year, or per-module databases
- **Connection Factory:** Dynamic connection switching
- **Context Engine:** Database context management

---

## Database Switching Flow

```
Context Change (Company/Year)
    ↓
Check Database Strategy
    ↓
Strategy: Single Database
    └─ Continue with current connection
    ↓
Strategy: Per-Company Database
    ├─ Get database path for company
    ├─ Update DatabaseContext
    └─ Switch connection factory
    ↓
Strategy: Per-Year Database
    ├─ Get database path for year
    ├─ Update DatabaseContext
    └─ Switch connection factory
    ↓
Strategy: Per-Module Database
    ├─ Get database path for module
    ├─ Update DatabaseContext
    └─ Switch connection factory
    ↓
Publish Database Switched Event
    ↓
Continue with new connection
```

---

## Database Context Infrastructure

### IDatabaseContext Interface
**Purpose:** Manage database context information

**Properties:**
- `DatabaseName` - Current database name
- `DatabasePath` - Current database file path
- `ConnectionString` - Current connection string
- `HasDatabaseContext` - Whether database context is set

**Methods:**
- `SetDatabaseAsync(databaseName, databasePath, connectionString)` - Set database context
- `ClearDatabaseAsync()` - Clear database context

### DatabaseContext Implementation
**Current:** Simple in-memory context storage  
**Future:** Integration with connection factory for actual switching

---

## Connection Factory Integration

### Current Connection Factory
```csharp
public class SqliteConnectionFactory : IDbConnectionFactory
{
    private readonly string _defaultDatabasePath;

    public SqliteConnectionFactory(string defaultDatabasePath)
    {
        _defaultDatabasePath = defaultDatabasePath;
    }

    public SqliteConnection CreateConnection()
    {
        return CreateConnection(_defaultDatabasePath);
    }

    public SqliteConnection CreateConnection(string databasePath)
    {
        // Create connection with specified path
        var connectionStringBuilder = new SqliteConnectionStringBuilder
        {
            DataSource = databasePath,
            Mode = SqliteOpenMode.ReadWriteCreate,
            Cache = SqliteCacheMode.Shared,
            Pooling = true
        };

        var connection = new SqliteConnection(connectionStringBuilder.ToString());
        connection.Open();

        // Configure WAL mode
        using var command = connection.CreateCommand();
        command.CommandText = "PRAGMA journal_mode=WAL;";
        command.ExecuteNonQuery();

        return connection;
    }
}
```

### Future Connection Factory with Switching
```csharp
public class SqliteConnectionFactory : IDbConnectionFactory
{
    private readonly string _defaultDatabasePath;
    private readonly IDatabaseContext _databaseContext;

    public SqliteConnectionFactory(
        string defaultDatabasePath,
        IDatabaseContext databaseContext)
    {
        _defaultDatabasePath = defaultDatabasePath;
        _databaseContext = databaseContext;
    }

    public SqliteConnection CreateConnection()
    {
        // Check if database context is set
        if (_databaseContext.HasDatabaseContext && 
            !string.IsNullOrEmpty(_databaseContext.DatabasePath))
        {
            return CreateConnection(_databaseContext.DatabasePath);
        }

        return CreateConnection(_defaultDatabasePath);
    }

    public SqliteConnection CreateConnection(string databasePath)
    {
        // Create connection with specified path
        var connectionStringBuilder = new SqliteConnectionStringBuilder
        {
            DataSource = databasePath,
            Mode = SqliteOpenMode.ReadWriteCreate,
            Cache = SqliteCacheMode.Shared,
            Pooling = true
        };

        var connection = new SqliteConnection(connectionStringBuilder.ToString());
        connection.Open();

        // Configure WAL mode
        using var command = connection.CreateCommand();
        command.CommandText = "PRAGMA journal_mode=WAL;";
        command.ExecuteNonQuery();

        return connection;
    }
}
```

---

## Database Switching Scenarios

### Scenario 1: Per-Company Databases
**Use Case:** Each company has its own database for data isolation

**Implementation:**
```csharp
public async Task SetCompanyAsync(string companyId, string companyCode, string companyName)
{
    _currentCompanyId = companyId;
    _currentCompanyCode = companyCode;
    _currentCompanyName = companyName;

    // Get company database path
    var companyInfo = await GetCompanyAsync(companyId);
    if (companyInfo != null && !string.IsNullOrEmpty(companyInfo.DatabaseName))
    {
        // Switch to company database
        await _databaseContext.SetDatabaseAsync(
            companyInfo.DatabaseName,
            $"/Data/{companyInfo.DatabaseName}.sqlite",
            ""
        );
    }

    return Task.CompletedTask;
}
```

### Scenario 2: Per-Year Databases
**Use Case:** Each assessment year has its own database for performance

**Implementation:**
```csharp
public async Task SetAssessmentYearAsync(string yearId, string year, DateTime yearStart, DateTime yearEnd)
{
    _currentYearId = yearId;
    _currentYear = year;
    _yearStart = yearStart;
    _yearEnd = yearEnd;

    // Get year database path
    var yearInfo = await GetAssessmentYearAsync(yearId);
    if (yearInfo != null && !string.IsNullOrEmpty(yearInfo.DatabaseName))
    {
        // Switch to year database
        await _databaseContext.SetDatabaseAsync(
            yearInfo.DatabaseName,
            $"/Data/{yearInfo.DatabaseName}.sqlite",
            ""
        );
    }

    return Task.CompletedTask;
}
```

### Scenario 3: Per-Module Databases
**Use Case:** Each module has its own database for scalability

**Implementation:**
```csharp
public async Task SetModuleDatabaseAsync(string moduleName, string databasePath)
{
    await _databaseContext.SetDatabaseAsync(
        moduleName,
        databasePath,
        ""
    );
}
```

---

## Database Switching Events

### DatabaseSwitchedEvent
```csharp
public class DatabaseSwitchedEvent
{
    public string PreviousDatabaseName { get; set; }
    public string NewDatabaseName { get; set; }
    public string SwitchReason { get; set; }
    public DateTime SwitchedAt { get; set; }
    public string UserId { get; set; }
}
```

### Event Handlers
- Clear connection pool for previous database
- Warm up connection pool for new database
- Cache invalidation for previous database
- Audit database switch

---

## Connection Pooling Considerations

### Current Pooling
- Single connection pool for single database
- Shared cache enabled
- WAL mode for concurrency

### Future Pooling
- Per-database connection pools
- Connection pool management
- Pool size configuration
- Pool eviction policies

### Implementation
```csharp
public class ConnectionPoolManager
{
    private readonly Dictionary<string, SqliteConnectionPool> _pools = new();

    public SqliteConnection GetConnection(string databasePath)
    {
        if (!_pools.ContainsKey(databasePath))
        {
            _pools[databasePath] = new SqliteConnectionPool(databasePath);
        }

        return _pools[databasePath].GetConnection();
    }

    public void EvictPool(string databasePath)
    {
        if (_pools.ContainsKey(databasePath))
        {
            _pools[databasePath].EvictAll();
            _pools.Remove(databasePath);
        }
    }
}
```

---

## Data Migration Considerations

### Single to Multi-Database Migration
**Phase 1:** Add company_id to all tables  
**Phase 2:** Implement company filtering in repositories  
**Phase 3:** Create per-company databases  
**Phase 4:** Migrate data to per-company databases  
**Phase 5:** Switch to per-company database strategy

### Data Consistency
- Transaction management across databases
- Distributed transactions (if needed)
- Data synchronization between databases
- Backup and restore strategies

---

## Performance Considerations

### Connection Switching Overhead
- Connection pool warm-up time
- Database file open time
- WAL checkpoint overhead
- Cache invalidation overhead

### Mitigation Strategies
- Pre-warm connection pools for frequently used databases
- Cache database metadata
- Lazy connection initialization
- Connection keep-alive for frequently used databases

---

## Security Considerations

### Database Access Control
- User permissions per database
- Company access validation
- Year access validation
- Module access validation

### Connection String Security
- Encrypt connection strings
- Secure storage of database paths
- Validate database paths
- Prevent directory traversal attacks

---

## Monitoring and Logging

### Database Switch Metrics
- Switch frequency
- Switch latency
- Connection pool statistics
- Database-specific query performance

### Logging
- Log all database switches
- Log connection pool events
- Log database-specific errors
- Audit database access

---

## Future Database Technologies

### PostgreSQL Migration Path
**Current:** SQLite  
**Future:** PostgreSQL for enterprise scale

**Implementation:**
```csharp
public interface IDbConnectionFactory
{
    IDbConnection CreateConnection();
    IDbConnection CreateConnection(string databasePath);
}

// SQLite Implementation
public class SqliteConnectionFactory : IDbConnectionFactory { }

// PostgreSQL Implementation
public class PostgreSqlConnectionFactory : IDbConnectionFactory { }

// Factory Selection
public class DatabaseConnectionFactory : IDbConnectionFactory
{
    private readonly IDbConnectionFactory _sqliteFactory;
    private readonly IDbConnectionFactory _postgresFactory;

    public IDbConnection CreateConnection()
    {
        // Select factory based on configuration
        return _sqliteFactory.CreateConnection();
    }
}
```

### Distributed Database Support
**Future:** Multiple database servers for scalability

**Implementation:**
- Connection load balancing
- Read replica support
- Write replica support
- Automatic failover

---

## Testing Strategy

### Unit Tests
- Test database context switching
- Test connection factory switching
- Test connection pool management
- Test event publishing

### Integration Tests
- Test actual database switching
- Test data consistency after switch
- Test performance impact
- Test error handling

### Load Tests
- Test connection pool under load
- Test database switching under load
- Test concurrent access to multiple databases
- Test memory usage

---

## Rollback Strategy

### Switch Failure Handling
```csharp
try
{
    await SwitchDatabaseAsync(newDatabasePath);
}
catch (Exception ex)
{
    // Rollback to previous database
    await RollbackDatabaseAsync(previousDatabasePath);
    
    // Log error
    _logger.LogError(ex, "Database switch failed, rolled back");
    
    // Notify user
    throw new DatabaseSwitchException("Database switch failed", ex);
}
```

### Rollback Validation
- Validate previous database is accessible
- Validate data consistency
- Validate connection pool state
- Validate context state

---

## Documentation Requirements

### Database Configuration
- Document database strategy per deployment
- Document connection pool configuration
- Document database path conventions
- Document backup and restore procedures

### Switch Procedures
- Document database switch procedures
- Document rollback procedures
- Document validation procedures
- Document troubleshooting procedures
