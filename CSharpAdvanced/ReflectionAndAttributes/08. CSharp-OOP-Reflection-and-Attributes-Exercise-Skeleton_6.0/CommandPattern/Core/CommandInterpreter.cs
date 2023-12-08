using CommandPattern.Core.Contracts;
using System;
using System.Linq;
using System.Reflection;

namespace CommandPattern.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] arguments = args.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string cmdName = arguments[0];

            Type commandType = Assembly
                .GetEntryAssembly()
                .GetTypes()
                .FirstOrDefault(t => t.Name == $"{cmdName}Command");

            if (commandType is null)
            {
                throw new InvalidOperationException("Command not found!");
            }

            ICommand commandInstance = Activator.CreateInstance(commandType) as ICommand;

            string result = commandInstance.Execute(arguments.Skip(1).ToArray());

            return result;
        }
    }
}
