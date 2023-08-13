namespace P01_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string cmd = string.Empty;

            while ((cmd = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = cmd
                    .Split(" ");
                string operation = cmdArgs[0];

                if (operation == "Translate")
                {
                    char oldChar = char.Parse(cmdArgs[1]);
                    char replacement = char.Parse(cmdArgs[2]);
                    input = input.Replace(oldChar, replacement);
                    Console.WriteLine(input);
                }
                else if (operation == "Includes")
                {
                    string substring = cmdArgs[1];

                    if (input.Contains(substring))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (operation == "Start")
                {
                    string substring = cmdArgs[1];

                    if (input.StartsWith(substring))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (operation == "Lowercase")
                {
                    input = input.ToLower();
                    Console.WriteLine(input);
                }
                else if (operation == "FindIndex")
                {
                    char symbol = char.Parse(cmdArgs[1]);
                    int lastEl = input.LastIndexOf(symbol);
                    Console.WriteLine(lastEl);
                }
                else if (operation == "Remove")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int count = int.Parse(cmdArgs[2]);
                    input = input.Remove(startIndex, count);
                    Console.WriteLine(input);
                }
            }
        }
    }
}