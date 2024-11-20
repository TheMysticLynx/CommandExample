namespace CommandExample;

public class CommandInvoker
{
    CommandInvokerState state;
    
    public CommandInvoker()
    {
        state = new CommandInvokerState();
    }
    
    public void SetState(CommandInvokerState state)
    {
        this.state = state;
    }
    
    public void ExecuteCommand(ICommand command)
    {
        command.Execute(state);
    }
    
    public T ExecuteCommand<T>(ICommand<T> command)
    {
        return command.Execute(state);
    }
}