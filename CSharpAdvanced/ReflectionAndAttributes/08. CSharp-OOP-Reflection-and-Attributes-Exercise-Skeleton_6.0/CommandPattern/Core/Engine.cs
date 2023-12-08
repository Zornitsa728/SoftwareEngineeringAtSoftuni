using CommandPattern.Core.Contracts;
using System;

namespace CommandPattern.Core
{
    public class Engine : IEngine
    {
        private readonly ICommandInterpreter commandInterpreter;
        public Engine(ICommandInterpreter commandInterpreter)
        {

            this.commandInterpreter = commandInterpreter;

        }
        public void Run()
        {
            while (true)
            {
                string input = Console.ReadLine();

                try
                {
                    string result = commandInterpreter.Read(input);
                    Console.WriteLine(result);
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
