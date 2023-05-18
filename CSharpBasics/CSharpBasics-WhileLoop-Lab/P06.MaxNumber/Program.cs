using System;

namespace P06.MaxNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numbers;
            int maxNum = int.MinValue;

            while ((numbers = Console.ReadLine()) != "Stop")
            {
                int currentNumber = int.Parse(numbers);
                if (currentNumber > maxNum)
                {
                    maxNum = currentNumber;
                }

            }
            Console.WriteLine(maxNum);
        }
    }
}
