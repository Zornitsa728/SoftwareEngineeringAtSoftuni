using System.Diagnostics.Metrics;

namespace P06.ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = string.Empty;
            char currLetter = ' ';
            
            for (int i = 0; i < input.Length; i++) 
            {
                if (currLetter != input[i])
                {
                    result += input[i];
                    currLetter = input[i];
                }
            }

            Console.WriteLine(result);
        }
    }
}