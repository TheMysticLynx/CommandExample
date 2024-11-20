namespace CommandExample.Commands;

public class MultiplyCommand : ICommand<int>
{
    public int Execute(CommandInvokerState state)
    {
        return state.valueOne * state.valueTwo;
    }
}