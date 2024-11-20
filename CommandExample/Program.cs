// See https://aka.ms/new-console-template for more information

using CommandExample;
using CommandExample.Commands;

var invoker = new CommandInvoker();
var state = new CommandInvokerState()
{
    valueOne = 10,
    valueTwo = 20
};
invoker.SetState(state);

var addCommand = new AddCommand();
var multiplyCommand = new MultiplyCommand();

Console.WriteLine(invoker.ExecuteCommand(addCommand));
Console.WriteLine(invoker.ExecuteCommand(multiplyCommand));