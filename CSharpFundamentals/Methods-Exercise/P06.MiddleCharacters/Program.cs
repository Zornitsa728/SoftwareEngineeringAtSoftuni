namespace P06.MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(FoundMiddleCharacter(input));
        }

        static string FoundMiddleCharacter(string text)
        {
            string middleChar = string.Empty;

            if (text.Length % 2 != 0)
            {
                middleChar = text[(text.Length / 2)].ToString();
            }
            else
            {
                middleChar = text[(text.Length / 2) - 1].ToString();
                middleChar += text[(text.Length / 2)];
            }

            return middleChar;
        }
    }
}