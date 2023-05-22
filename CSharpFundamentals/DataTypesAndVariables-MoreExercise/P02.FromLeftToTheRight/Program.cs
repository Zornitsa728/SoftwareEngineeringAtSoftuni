using System.Drawing;

namespace P02.FromLeftToTheRight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            long firstNum = 0L;
            long secondNum = 0L;
            

            for (long i = 0; i < input; i++)
            {
                long[] numbers = Console.ReadLine().Split().Select(long.Parse).ToArray();
                firstNum = numbers[0];
                secondNum = numbers[1];
                long sum = 0L;
                long lastDigit = 0L;

                if (firstNum > secondNum)
                {
                    while (firstNum != 0)
                    {
                        lastDigit = firstNum % 10;
                        sum += Math.Abs(lastDigit);
                        firstNum = firstNum / 10;
                    }
                }
                else
                {
                    while (secondNum != 0)
                    {
                        lastDigit = secondNum % 10;
                        sum += Math.Abs(lastDigit);
                        secondNum = secondNum / 10;
                    }
                }

                Console.WriteLine(sum);
            }
        }
    }
}