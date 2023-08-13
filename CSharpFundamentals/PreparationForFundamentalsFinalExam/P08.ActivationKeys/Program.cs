namespace P08.ActivationKeys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();
            string cmd = string.Empty;

            while ((cmd = Console.ReadLine()) != "Generate")
            {
                string[] cmdArgs = cmd.Split(">>>");
                string operation = cmdArgs[0];

                if (operation == "Contains")
                {
                    string substring = cmdArgs[1];

                    if (activationKey.Contains(substring))
                    {
                        Console.WriteLine($"{activationKey} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (operation == "Flip")
                {
                    string upperOrLower = cmdArgs[1];
                    int startIndex = int.Parse(cmdArgs[2]);
                    int endIndex = int.Parse(cmdArgs[3]);
                    string substring = activationKey.Substring(startIndex, endIndex - startIndex);

                    if (upperOrLower == "Upper")
                    {
                        activationKey = activationKey.Replace(substring, substring.ToUpper());
                    }
                    else if (upperOrLower == "Lower")
                    {
                        activationKey = activationKey.Replace(substring, substring.ToLower());
                    }

                    Console.WriteLine(activationKey);
                }
                else if(operation == "Slice")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);

                    activationKey = activationKey.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine(activationKey);
                }
            }

            Console.WriteLine($"Your activation key is: {activationKey}");
        }
    }
}