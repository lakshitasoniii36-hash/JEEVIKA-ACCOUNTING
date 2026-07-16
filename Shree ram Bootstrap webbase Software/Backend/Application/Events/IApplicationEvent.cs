namespace Application.Events;

/// <summary>
/// Base interface for application events
/// </summary>
public interface IApplicationEvent
{
    /// <summary>
    /// Gets the event ID
    /// </summary>
    string EventId { get; }

    /// <summary>
    /// Gets the event timestamp
    /// </summary>
    DateTime OccurredAt { get; }

    /// <summary>
    /// Gets the event type
    /// </summary>
    string EventType { get; }
}

/// <summary>
/// Base class for application events
/// </summary>
public abstract class ApplicationEventBase : IApplicationEvent
{
    public string EventId { get; } = Guid.NewGuid().ToString();
    public DateTime OccurredAt { get; } = DateTime.UtcNow;
    public abstract string EventType { get; }
}

/// <summary>
/// Interface for event publisher
/// </summary>
public interface IEventPublisher
{
    /// <summary>
    /// Publishes an event
    /// </summary>
    /// <typeparam name="TEvent">Event type</typeparam>
    /// <param name="event">Event to publish</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task PublishAsync<TEvent>(TEvent @event, CancellationToken cancellationToken = default) where TEvent : IApplicationEvent;

    /// <summary>
    /// Publishes multiple events
    /// </summary>
    /// <typeparam name="TEvent">Event type</typeparam>
    /// <param name="events">Events to publish</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task PublishRangeAsync<TEvent>(IEnumerable<TEvent> events, CancellationToken cancellationToken = default) where TEvent : IApplicationEvent;
}

/// <summary>
/// Default event publisher implementation (placeholder)
/// </summary>
public class DefaultEventPublisher : IEventPublisher
{
    public Task PublishAsync<TEvent>(TEvent @event, CancellationToken cancellationToken = default) where TEvent : IApplicationEvent
    {
        // Infrastructure placeholder - will publish to event bus
        // Future: Implement actual event publishing logic
        return Task.CompletedTask;
    }

    public Task PublishRangeAsync<TEvent>(IEnumerable<TEvent> events, CancellationToken cancellationToken = default) where TEvent : IApplicationEvent
    {
        // Infrastructure placeholder - will publish multiple events to event bus
        // Future: Implement actual batch event publishing logic
        return Task.CompletedTask;
    }
}

/// <summary>
/// Interface for event handler
/// </summary>
/// <typeparam name="TEvent">Event type</typeparam>
public interface IEventHandler<TEvent> where TEvent : IApplicationEvent
{
    /// <summary>
    /// Handles the event
    /// </summary>
    /// <param name="event">Event to handle</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task HandleAsync(TEvent @event, CancellationToken cancellationToken = default);
}
