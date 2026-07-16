namespace Application.Commands;

/// <summary>
/// Base class for commands
/// </summary>
public abstract class CommandBase : ICommand
{
    public string CommandId { get; } = Guid.NewGuid().ToString();
}

/// <summary>
/// Base class for commands with return value
/// </summary>
/// <typeparam name="TResult">Result type</typeparam>
public abstract class CommandBase<TResult> : CommandBase, ICommand<TResult>
{
}
