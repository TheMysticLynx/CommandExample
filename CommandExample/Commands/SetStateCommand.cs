namespace CommandExample.Commands;

public class SetStateCommand : ICommand
{
    public readonly int ValueOne;
    public readonly int ValueTwo;

    public SetStateCommand(int valueOne, int valueTwo)
    {
        ValueOne = valueOne;
        ValueTwo = valueTwo;
    }

    public void Execute(CommandInvokerState state)
    {
        state.valueOne = ValueOne;
        state.valueTwo = ValueTwo;
    }
}