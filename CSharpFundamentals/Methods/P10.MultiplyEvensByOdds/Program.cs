using System.Drawing;
using System.Linq;

namespace P10.MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine(GetMultipleOfEvenAndOdds(ConvertIntToArray(input)));
        }

        static int[] ConvertIntToArray(int input)
        {
            int inputLength = input.ToString().Length;
            int[] numbers = new int[inputLength];

            for (int i = inputLength - 1; i >= 0; i--)
            {
                int lastDigit = input % 10;
                numbers[i] = lastDigit;
                input /= 10;
            }

            return numbers;
        }

        static int GetSumOfEvenDigits(int[] numbers)
        {
            int evenSum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenSum += numbers[i];
                }
            }

            return evenSum;
        }

        static int GetSumOfOddDigits(int[] numbers)
        {
            int oddSum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    oddSum += numbers[i];
                }
            }

            return oddSum;
        }

        static int GetMultipleOfEvenAndOdds(int[] numbers)
        {
            return GetSumOfEvenDigits(numbers) * GetSumOfOddDigits(numbers);
        }
    }
}