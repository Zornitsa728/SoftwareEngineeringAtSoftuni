using System;

namespace P03.SumPrimeNonPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            int primeSum = 0;
            int nonPrimeSum = 0;
            

            while ((input=Console.ReadLine()) != "stop")
            {
                int currentNumber = int.Parse(input);
                int count = 0;

                if (currentNumber < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }

                for (int i = 1; i <= currentNumber; i++)
                {
                    if (currentNumber % i == 0)
                    {
                        count++;
                    }
                }

                if (count == 2)
                {
                    primeSum += currentNumber;
                }
                else
                {
                    nonPrimeSum += currentNumber;
                }
            }

            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}
