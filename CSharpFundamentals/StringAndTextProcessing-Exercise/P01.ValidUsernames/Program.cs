namespace P01.ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            foreach (string username in userNames)
            {
                if (username.Length >= 3 && username.Length <= 16)
                {
                    bool isNameCorrect = true;

                    for (int i = 0; i < username.Length; i++)
                    {
                        char currChar = username[i];

                        if (!char.IsLetterOrDigit(currChar) && !(currChar == '-') && !(currChar == '_'))
                        {
                            isNameCorrect = false;
                            break;
                        }
                    }

                    if (isNameCorrect)
                    {
                        Console.WriteLine(username);
                    }
                }
            }
        }
    }
}