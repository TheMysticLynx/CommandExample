namespace CommandExample.Commands;

public class AddCommandWithAdditionalInputs : ICommand<int>
{
    public readonly List<int> AdditionalValues;

    public AddCommandWithAdditionalInputs(List<int> additionalValues)
    {
        this.AdditionalValues = additionalValues;
    }


    public int Execute(CommandInvokerState state)
    {
        var sum = state.valueOne + state.valueTwo;
        foreach (var value in this.AdditionalValues)
        {
            sum += value;
        }
        
        return sum;
    }
}