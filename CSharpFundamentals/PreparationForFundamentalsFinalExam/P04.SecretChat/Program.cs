namespace P04.SecretChat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string concealedMessage = Console.ReadLine();
            string cmd = string.Empty;

            while ((cmd = Console.ReadLine()) != "Reveal")
            {
                string[] cmdArgs = cmd
                    .Split(":|:");
                string operation = cmdArgs[0];

                if (operation == "InsertSpace")
                {
                    int index = int.Parse(cmdArgs[1]);
                    concealedMessage = concealedMessage.Insert(index, " ");
                }
                else if (operation == "Reverse")
                {
                    string substring = cmdArgs[1];

                    if (DoesSubstringExist(concealedMessage, substring))
                    {
                        concealedMessage = concealedMessage.Remove(concealedMessage.IndexOf(substring),substring.Length);
                        List<char> reversedSubstring = substring.Reverse().ToList();

                        foreach (char letter in reversedSubstring)
                        {
                            concealedMessage += letter;
                        }
                    }
                    else
                    {
                        Console.WriteLine("error");
                        continue;
                    }
                }
                else if (operation == "ChangeAll")
                {
                    string substring = cmdArgs[1];
                    string replacement = cmdArgs[2];

                    concealedMessage = concealedMessage.Replace(substring, replacement);
                }

                Console.WriteLine(concealedMessage);
            }

            Console.WriteLine($"You have a new text message: {concealedMessage}");
        }

        static bool DoesSubstringExist(string text, string substring)
        {
            if (text.Contains(substring))
            {
                return true;
            }

            return false;
        }
    }
}