namespace P02.StackSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            Stack<int> stack = new Stack<int>(numbers);    

            string cmd;
            while ((cmd = Console.ReadLine().ToLower()) != "end")
            {
                string[] cmdArgs = cmd
                    .Split(" ");
                string operation = cmdArgs[0];

                if (operation == "add")
                { // pushing two numbers into stack
                    stack.Push(int.Parse(cmdArgs[1]));
                    stack.Push(int.Parse(cmdArgs[2]));
                }
                else if (operation == "remove")
                {
                    int numbersToRemove = int.Parse(cmdArgs[1]);
                    if (stack.Count >= numbersToRemove)
                    {
                        for (int i = 0; i < numbersToRemove; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
            }
            
            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}