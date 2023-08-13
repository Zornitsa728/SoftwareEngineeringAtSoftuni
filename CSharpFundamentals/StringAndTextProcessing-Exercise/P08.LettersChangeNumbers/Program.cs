using System.Text;

namespace P08.LettersChangeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            char firstLetter = ' ';
            char lastLetter = ' ';
            double number = 0;
            double sum = 0;

            foreach (string text in input)
            {
                firstLetter = text[0];
                lastLetter = text[text.Length - 1];

                number = double.Parse(text.Substring(1, text.Length - 2));

                if (char.IsUpper(firstLetter))
                {
                    int dividingNum = (firstLetter - 'A') + 1;
                    number /= dividingNum;
                }
                else
                {
                    int dividingNum = (firstLetter - 'a') + 1;
                    number *= dividingNum;
                }

                if (char.IsUpper(lastLetter))
                {
                    int dividingNum = (lastLetter - 'A') + 1;
                    number -= dividingNum;
                }
                else
                {
                    int dividingNum = (lastLetter - 'a') + 1;
                    number += dividingNum;
                }

                sum += number;
            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}