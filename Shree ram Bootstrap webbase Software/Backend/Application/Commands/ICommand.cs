namespace Application.Commands;

/// <summary>
/// Base interface for commands (write operations)
/// </summary>
public interface ICommand
{
    /// <summary>
    /// Gets the command ID for tracking
    /// </summary>
    string CommandId { get; }
}

/// <summary>
/// Command interface with return value
/// </summary>
/// <typeparam name="TResult">Result type</typeparam>
public interface ICommand<TResult> : ICommand
{
}
