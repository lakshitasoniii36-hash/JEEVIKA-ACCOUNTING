# Query Framework Documentation

**Version:** 1.0  
**Last Updated:** 2026-07-07  
**Purpose:** Document the query infrastructure for filtering, sorting, searching, pagination, and projection

---

## Overview

The Query Framework provides a flexible, type-safe way to build and execute queries with filtering, sorting, searching, pagination, and projection capabilities. It supports both query objects and specification patterns for different use cases.

---

## Query Object Pattern

### Query<TEntity>
Query object for building complex queries.

**Properties:**
- `Filter` - Filter criteria
- `Sort` - Sort criteria
- `Pagination` - Pagination criteria
- `Search` - Search criteria
- `Includes` - Navigation properties to include

### FilterCriteria
Criteria for filtering data.

**Properties:**
- `Property` - Property name to filter on
- `Operation` - Filter operation
- `Value` - Filter value

### FilterOperation
Supported filter operations:
- `Equal` - Property equals value
- `NotEqual` - Property does not equal value
- `GreaterThan` - Property greater than value
- `GreaterThanOrEqual` - Property greater than or equal to value
- `LessThan` - Property less than value
- `LessThanOrEqual` - Property less than or equal to value
- `Contains` - Property contains value (string)
- `StartsWith` - Property starts with value (string)
- `EndsWith` - Property ends with value (string)
- `In` - Property in list of values
- `NotIn` - Property not in list of values

### SortCriteria
Criteria for sorting data.

**Properties:**
- `Property` - Property name to sort on
- `Direction` - Sort direction

### SortDirection
Sort direction options:
- `Ascending` - Sort ascending
- `Descending` - Sort descending

### PaginationCriteria
Criteria for paginating data.

**Properties:**
- `PageNumber` - Page number (1-based)
- `PageSize` - Page size

### SearchCriteria
Criteria for searching across multiple properties.

**Properties:**
- `Term` - Search term
- `Properties` - Properties to search in

---

## Specification Pattern

### ISpecification<TEntity>
Specification interface for encapsulating query logic.

**Properties:**
- `Criteria` - Filter expression
- `Includes` - Include expressions (navigation properties)
- `IncludeStrings` - Include strings (navigation properties as strings)
- `OrderBy` - Order by expression
- `OrderByDescending` - Order by descending expression
- `GroupBy` - Group by expression
- `Pagination` - Pagination (skip and take)
- `AsNoTracking` - Whether tracking is disabled

### BaseSpecification<TEntity>
Base specification with common functionality.

**Methods:**
- `AddCriteria(criteria)` - Add filter criteria
- `AddInclude(includeExpression)` - Add include expression
- `AddInclude(includeString)` - Add include string
- `ApplyOrderBy(orderByExpression)` - Apply order by ascending
- `ApplyOrderByDescending(orderByDescendingExpression)` - Apply order by descending
- `ApplyGroupBy(groupByExpression)` - Apply group by
- `ApplyPaging(skip, take)` - Apply pagination
- `DisableTracking()` - Disable change tracking

---

## PagedResult<T>

### Properties
- `Items` - Items in current page
- `TotalCount` - Total number of items
- `PageNumber` - Current page number
- `PageSize` - Page size
- `TotalPages` - Total number of pages
- `HasPreviousPage` - Whether there is a previous page
- `HasNextPage` - Whether there is a next page

### Usage
```csharp
var pagedResult = await _repository.GetPagedAsync(query);
Console.WriteLine($"Page {pagedResult.PageNumber} of {pagedResult.TotalPages}");
Console.WriteLine($"Total items: {pagedResult.TotalCount}");
foreach (var item in pagedResult.Items)
{
    Console.WriteLine(item);
}
```

---

## Query Object Usage

### Basic Filter
```csharp
var query = new Query<Account>
{
    Filter = new FilterCriteria
    {
        Property = "IsActive",
        Operation = FilterOperation.Equal,
        Value = true
    }
};

var accounts = await _repository.FindAsync(query);
```

### Multiple Filters
```csharp
// Note: Multiple filters require implementation of AND/OR logic
// This is infrastructure preparation for future implementation
```

### Sorting
```csharp
var query = new Query<Account>
{
    Sort = new SortCriteria
    {
        Property = "AccountName",
        Direction = SortDirection.Ascending
    }
};

var accounts = await _repository.FindAsync(query);
```

### Pagination
```csharp
var query = new Query<Account>
{
    Pagination = new PaginationCriteria
    {
        PageNumber = 1,
        PageSize = 20
    }
};

var pagedResult = await _repository.GetPagedAsync(query);
```

### Combined Query
```csharp
var query = new Query<Account>
{
    Filter = new FilterCriteria
    {
        Property = "IsActive",
        Operation = FilterOperation.Equal,
        Value = true
    },
    Sort = new SortCriteria
    {
        Property = "AccountName",
        Direction = SortDirection.Ascending
    },
    Pagination = new PaginationCriteria
    {
        PageNumber = 1,
        PageSize = 20
    }
};

var pagedResult = await _repository.GetPagedAsync(query);
```

### Search
```csharp
var query = new Query<Account>
{
    Search = new SearchCriteria
    {
        Term = "Savings",
        Properties = new List<string> { "AccountName", "AccountCode" }
    }
};

var accounts = await _repository.FindAsync(query);
```

---

## Specification Usage

### Basic Specification
```csharp
public class ActiveAccountSpecification : BaseSpecification<Account>
{
    public ActiveAccountSpecification()
    {
        AddCriteria(a => a.IsActive);
    }
}

var accounts = await _repository.FindAsync(new ActiveAccountSpecification());
```

### Specification with Sorting
```csharp
public class ActiveAccountSpecification : BaseSpecification<Account>
{
    public ActiveAccountSpecification()
    {
        AddCriteria(a => a.IsActive);
        ApplyOrderBy(a => a.AccountName);
    }
}

var accounts = await _repository.FindAsync(new ActiveAccountSpecification());
```

### Specification with Pagination
```csharp
public class ActiveAccountSpecification : BaseSpecification<Account>
{
    public ActiveAccountSpecification(int pageNumber, int pageSize)
    {
        AddCriteria(a => a.IsActive);
        ApplyOrderBy(a => a.AccountName);
        ApplyPaging((pageNumber - 1) * pageSize, pageSize);
    }
}

var accounts = await _repository.FindAsync(new ActiveAccountSpecification(1, 20));
```

### Specification with Includes
```csharp
public class AccountWithMembersSpecification : BaseSpecification<Account>
{
    public AccountWithMembersSpecification()
    {
        AddInclude(a => a.Members);
        AddCriteria(a => a.IsActive);
    }
}

var accounts = await _repository.FindAsync(new AccountWithMembersSpecification());
```

### Specification with No Tracking
```csharp
public class ReadOnlyAccountSpecification : BaseSpecification<Account>
{
    public ReadOnlyAccountSpecification()
    {
        AddCriteria(a => a.IsActive);
        DisableTracking();
    }
}

var accounts = await _repository.FindAsync(new ReadOnlyAccountSpecification());
```

---

## Projection

### Project to DTO
```csharp
public class AccountDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Balance { get; set; }
}

var specification = new ActiveAccountSpecification();
var accountDtos = await _repository.ProjectAsync<AccountDto>(specification);
```

---

## Query vs Specification

### When to Use Query Objects
- Dynamic queries built from user input
- Simple filtering and sorting
- Pagination requirements
- Search across multiple properties

### When to Use Specifications
- Complex business logic encapsulation
- Reusable query logic
- Type-safe expressions
- Include navigation properties
- Custom query logic

### Comparison
| Feature | Query Object | Specification |
|---------|--------------|---------------|
| Type Safety | String-based property names | Expression-based |
| Reusability | Less reusable | Highly reusable |
| Complexity | Simple queries | Complex queries |
| Dynamic | Yes | Limited |
| Includes | Limited | Full support |
| Performance | May require reflection | Compile-time optimized |

---

## Best Practices

### Use Specifications for Reusable Logic
```csharp
// Good: Reusable specification
public class ActiveAccountSpecification : BaseSpecification<Account>
{
    public ActiveAccountSpecification()
    {
        AddCriteria(a => a.IsActive);
    }
}

// Bad: Query object in multiple places
var query1 = new Query<Account> { Filter = new FilterCriteria { Property = "IsActive", Operation = FilterOperation.Equal, Value = true } };
var query2 = new Query<Account> { Filter = new FilterCriteria { Property = "IsActive", Operation = FilterOperation.Equal, Value = true } };
```

### Use Query Objects for Dynamic Queries
```csharp
// Good: Dynamic query from user input
var query = new Query<Account>
{
    Filter = new FilterCriteria
    {
        Property = request.FilterProperty,
        Operation = request.FilterOperation,
        Value = request.FilterValue
    },
    Sort = new SortCriteria
    {
        Property = request.SortProperty,
        Direction = request.SortDirection
    },
    Pagination = new PaginationCriteria
    {
        PageNumber = request.PageNumber,
        PageSize = request.PageSize
    }
};
```

### Disable Tracking for Read-Only Queries
```csharp
// Good: Disable tracking for read-only queries
var specification = new ActiveAccountSpecification();
specification.DisableTracking();
var accounts = await _repository.FindAsync(specification);
```

### Use Includes Wisely
```csharp
// Good: Include only what you need
AddInclude(a => a.Members);

// Bad: Include everything
AddInclude(a => a.Members);
AddInclude(a => a.Transactions);
AddInclude(a => a.LedgerEntries);
```

---

## Future Enhancements

### Query Object Implementation
- Implement actual query object parsing
- Add support for multiple filters (AND/OR)
- Add support for nested property filtering
- Add support for complex sorting (multiple properties)

### Specification Implementation
- Implement actual specification execution
- Add support for complex expressions
- Add support for specification composition (AND/OR/NOT)
- Add support for parameterized specifications

### Performance Optimization
- Add query result caching
- Add query plan optimization
- Add query performance monitoring
- Add query compilation caching

### Advanced Features
- Add support for full-text search
- Add support for spatial queries
- Add support for JSON queries
- Add support for custom operators

---

## Integration with Repository

### Repository Methods
- `FindAsync(specification)` - Find entities using specification
- `GetPagedAsync(query)` - Get paged results using query object
- `ProjectAsync<TProjection>(specification)` - Project using specification

### Context Integration
Queries automatically receive context from IRepositoryContext:
- Company ID for filtering
- Year ID for filtering
- User ID for filtering
- Branch for filtering

---

## Testing

### Query Object Testing
```csharp
[Fact]
public void Query_ShouldBuildCorrectFilter()
{
    var query = new Query<Account>
    {
        Filter = new FilterCriteria
        {
            Property = "IsActive",
            Operation = FilterOperation.Equal,
            Value = true
        }
    };

    Assert.Equal("IsActive", query.Filter.Property);
    Assert.Equal(FilterOperation.Equal, query.Filter.Operation);
    Assert.Equal(true, query.Filter.Value);
}
```

### Specification Testing
```csharp
[Fact]
public void Specification_ShouldBuildCorrectCriteria()
{
    var specification = new ActiveAccountSpecification();
    
    Assert.NotNull(specification.Criteria);
    // Additional assertions
}
```

---

## Compliance

### ✅ Architecture Compliance
- Follows Clean Architecture principles
- Follows ARCHITECTURE.md guidelines
- Follows DEVELOPMENT_GUIDELINES.md standards
- No architectural boundary violations

### ✅ Phase 3 Compliance
- No business logic implemented
- No accounting logic implemented
- No voucher logic implemented
- No SQL changes
- No database schema changes
- No controller refactoring
- No frontend changes
