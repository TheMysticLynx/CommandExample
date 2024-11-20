namespace CommandExample.Commands;

public class AddCommand : ICommand<int>
{
    public int Execute(CommandInvokerState state)
    {
        return state.valueOne + state.valueTwo;
    }
}