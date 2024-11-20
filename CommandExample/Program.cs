// See https://aka.ms/new-console-template for more information

using CommandExample;
using CommandExample.Commands;

var invoker = new CommandInvoker();

var setStateCommand = new SetStateCommand(5, 10);
invoker.ExecuteCommand(setStateCommand);

var addCommand = new AddCommand();
var multiplyCommand = new MultiplyCommand();
var addCommandWithAdditionalInputs = new AddCommandWithAdditionalInputs(new List<int> { 5, 10 });

Console.WriteLine();
Console.WriteLine("Commands:");
Console.WriteLine(setStateCommand.GetType().Name + " with values: 5, 10");
Console.WriteLine(addCommand.GetType().Name);
Console.WriteLine(invoker.ExecuteCommand(addCommand));
Console.WriteLine(multiplyCommand.GetType().Name);
Console.WriteLine(invoker.ExecuteCommand(multiplyCommand));
Console.WriteLine(addCommandWithAdditionalInputs.GetType().Name + " with additional inputs: 5, 10");
Console.WriteLine(invoker.ExecuteCommand(addCommandWithAdditionalInputs));
