namespace P02.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            Console.WriteLine(NumberOfVowels(input));
        }

        static int NumberOfVowels(string text)
        {
            int countOfVowels = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a' || text[i] == 'o' || text[i] == 'e' || text[i] == 'i' || text[i] == 'u' || text[i] == 'y')
                {
                    countOfVowels++;
                }
            }

            return countOfVowels;
        }
    }
}