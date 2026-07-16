namespace Shared.Interfaces;

/// <summary>
/// Interface for event bus operations
/// </summary>
public interface IEventBus
{
    /// <summary>
    /// Publishes an event to the bus
    /// </summary>
    Task PublishAsync<TEvent>(TEvent @event) where TEvent : class;

    /// <summary>
    /// Subscribes to an event type
    /// </summary>
    Task SubscribeAsync<TEvent>(Func<TEvent, Task> handler) where TEvent : class;

    /// <summary>
    /// Unsubscribes from an event type
    /// </summary>
    Task UnsubscribeAsync<TEvent>(Func<TEvent, Task> handler) where TEvent : class;
}

/// <summary>
/// Base interface for domain events
/// </summary>
public interface IDomainEvent
{
    string EventType { get; }
    DateTime OccurredOn { get; }
    string CorrelationId { get; }
}

/// <summary>
/// Base interface for integration events
/// </summary>
public interface IIntegrationEvent
{
    string EventType { get; }
    DateTime OccurredOn { get; }
    string CorrelationId { get; }
}
