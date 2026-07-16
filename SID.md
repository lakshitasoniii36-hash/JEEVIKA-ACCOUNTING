# System Integration & Architecture Design (SID.md)

This document outlines the core architectural blueprint of the application, analyzing current system design, structural bottlenecks, and a concrete reshaping path for enterprise-grade performance.

---

## 1. Core System Topology (Base Core Path)

The software is structured as a decoupled two-tier architecture migrating from a legacy WinForms/Crystal Reports desktop application to a modern web-based platform:

```
[ Frontend Client ]  <--->  [ Web API Backend ]  <--->  [ Relational SQLite DB ]
 (Bootstrap + SPA)           (ASP.NET Core 8.0)              (WAL Mode Engine)
                                     |
                                     v
                            [ Legacy Reporting ]
                           (Crystal Reports RPT)
```

1. **Presentation Layer**: Custom Vanilla JS SPA Engine serving as a Single Page Application. It loads HTML fragments on-demand, injects CSS dynamically, and runs sequential JavaScript files.
2. **Business & API Layer**: ASP.NET Core Web API executing controllers to process business rules and return structured JSON responses.
3. **Data Access & Storage**: SQLite relational database using traditional ADO.NET client connections.
4. **Legacy Domain Layer**: Sub-system projects hosting legacy report configurations and Windows-only assembly wrappers.

---

## 2. Deep Architectural Bottleneck Analysis

### A. Frontend Layer (Vanilla SPA Engine)
*   **Dynamic Script & Style Injection Overhead**: The SPA framework injects `<link>` and `<script>` elements directly into the document `<head>` on every module transition without maintaining a dependency graph. This triggers redundant CSSOM rebuilds, style recalculations, and duplication of JavaScript runtimes.
*   **Global Namespace Pollution**: Loaded scripts lack module isolation, relying on global variables and namespace binding (e.g. `window.init_module`). This leads to state pollution, memory leaks, and collision risks when multiple tabs are open.
*   **Lack of DOM Virtualization**: Tables are rendered by building large DOM fragments from scratch. With hundreds or thousands of members, the browser experiences layout thrashing and high memory overhead.
*   **Request Cascades**: Open tabs load resources sequentially (HTML -> External Script -> API Fetch), creating nested latency loops.

### B. Backend Layer (ASP.NET Core Web API)
*   **Decentralized Connection Lifecycle**: The controllers define their own SQLite connection builder and open connection instances independently. This bypasses global locking options, busy timeouts, and connection pools.
*   **Inconsistent WAL Mode Configuration**: Pragma statements like `PRAGMA journal_mode=WAL` are run only within the setup utility. Because connections opened by controllers do not run this statement, they default to standard rollback journaling under concurrent workloads, causing database-locked exceptions.
*   **Synchronous Execution Bottlenecks**: Web API endpoints operate synchronously. Under load, thread starvation occurs, preventing the server from scaling efficiently.
*   **Slow Data Marshalling**: Query results are mapped row-by-row using string lookup indexers (e.g. `reader[columnName]`). This requires dictionary lookups for every single column on every row.
*   **Cache Invalidation Strategy**: Cache helpers manage lookup caching without thread-safe access controls, invalidation policies, or size limitations.

### C. Reporting & Legacy Storage
*   **Platform Lock-in**: The legacy Crystal Reports runtime engine (.rpt) is heavily reliant on Windows APIs, preventing the backend from being deployed in cross-platform Linux containers or serverless environments.

---

## 3. Reshaped Performance Blueprint (Target Architecture)

```
                     +---------------------------------------+
                     |        Client Browser (SPA)           |
                     |  +---------------------------------+  |
                     |  |  Virtual DOM / Virtualized Grid |  |
                     |  +---------------------------------+  |
                     |  |  Module Loader / ESM Modules    |  |
                     |  +---------------------------------+  |
                     +-------------------+-------------------+
                                         |
                                         | Async JSON / HTTP/2
                                         v
                     +-------------------+-------------------+
                     |      ASP.NET Core Web API Gateway     |
                     |  +---------------------------------+  |
                     |  | Async Endpoints (async/await)   |  |
                     |  +---------------------------------+  |
                     |  | Dependency Injected DB Manager  |  |
                     |  +---------------------------------+  |
                     +-------------------+-------------------+
                                         |
                       +-----------------+-----------------+
                       |                                   |
                       v (Pooled DB Connections)           v (Compiled Reports)
         +-------------+-------------+       +-------------+-------------+
         |      SQLite Engine        |       |    Cross-Platform PDF     |
         |  (WAL + Shared Cache +    |       |      Reporting Engine     |
         |   Pooled Connection)      |       +---------------------------+
         +---------------------------+
```

### A. Reshaping the Data Base Core
1.  **Centralized Connection Factory**: Implement a DI-managed connection factory in `Program.cs`. All controllers must receive their connections through constructor injection.
2.  **Strict SQLite WAL Configuration**: Configure SQLite connections globally using connection string options:
    ```ini
    Data Source=ShreeRam.sqlite;Cache=Shared;Mode=ReadWrite;Journal Mode=Wal;Pooling=True;Busy Timeout=5000
    ```
3.  **Asynchronous Data Pipeline**: Refactor database access, controllers, and helper classes to use asynchronous operations (`async/await`, `ExecuteReaderAsync`, `ReadAsync`).
4.  **Performant Column Mapping**: Retrieve column index ordinals once per query using `GetOrdinal(columnName)` outside the data reader loop. Use binary getters (`GetString(index)`, `GetDouble(index)`) or adopt a micro-ORM like Dapper to automate mapping.
5.  **Thread-Safe In-Memory Cache**: Move cache wrappers to `IMemoryCache` with expiration policies (Absolute/Sliding Expiration).

### B. Reshaping the Frontend Core
1.  **ESM Module Separation**: Transition scripts into ES modules (`type="module"`). Use `import` and `export` statements to prevent global namespace pollution and automatically manage component scoping.
2.  **Asset Load Manager**: Implement a global registry that tracks loaded stylesheets and scripts. Avoid reloading resources that are already present in the DOM.
3.  **Virtualized Rendering**: Integrate a virtual grid framework to render only the visible viewport rows for large datasets.
4.  **Batch & Cache HTTP Requests**: Implement a request batching mechanism and client-side response cache to prevent redundant API lookups.

### C. Modernizing the Reporting Core
1.  **Report Engine Abstraction**: Introduce a unified report generator interface.
2.  **Cross-Platform Reporting**: Rebuild reports using HTML-to-PDF libraries (like Puppeteer Sharp or QuestPDF) to remove dependency on Windows-native Crystal Reports.
