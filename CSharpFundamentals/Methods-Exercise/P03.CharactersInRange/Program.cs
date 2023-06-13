namespace P03.CharactersInRange
{
    internal class Program
    {
        public static int ASCIICode { get; private set; }

        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            Console.WriteLine(string.Join(" ", CharactersBetweenTwoChars(firstChar, secondChar)));
        }

        static string[] CharactersBetweenTwoChars(char firstChar, char secondChar)
        {
            
            char swap = firstChar;
            if (firstChar > secondChar)
            {
                firstChar = secondChar;
                secondChar = swap;
            }

            int arrayLength = secondChar - firstChar;
            string[] allCharacters = new string[arrayLength];
            for (int i = 0; i < arrayLength - 1; i++)
            {
                allCharacters[i] += (char)(firstChar + 1 + i);
            }

            return allCharacters;
        }
    }
}