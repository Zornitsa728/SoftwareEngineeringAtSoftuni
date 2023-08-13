namespace P01.TheImitationGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string cmd;

            while ((cmd = Console.ReadLine()) != "Decode")
            {
                string[] cmdArgs = cmd.Split('|');
                string action = cmdArgs[0];

                if (action == "Move")
                {
                    int lettersCount = int.Parse(cmdArgs[1]);

                    string getLetters = message.Substring(0, lettersCount);
                    message = message.Remove(0, lettersCount);
                    message += getLetters;
                }
                else if (action == "Insert")
                {
                    int index = int.Parse(cmdArgs[1]);
                    string value = cmdArgs[2];

                    message = message.Insert(index, value);
                }
                else if(action == "ChangeAll")
                {
                    string substring = cmdArgs[1];
                    string replacement = cmdArgs[2];

                    message = message.Replace(substring, replacement);
                }
            }

            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}