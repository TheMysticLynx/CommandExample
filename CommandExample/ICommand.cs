namespace CommandExample;

public interface ICommand<T>
{
    public T Execute(CommandInvokerState state);
}

public interface ICommand
{
    public void Execute(CommandInvokerState state);
}