using System;

namespace P02.EqualSumsEvenOddPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingNum = int.Parse(Console.ReadLine());
            int endingNum= int.Parse(Console.ReadLine());

            for (int start = startingNum; start <= endingNum; start++)
            {
                int oddSum = 0;
                int evenSum =0;
                string currentNum = start.ToString();

                for (int i = 0; i < 6; i++)
                {
                    if (i % 2 == 0)
                    {
                        evenSum += currentNum[i];
                    }
                    else
                    {
                        oddSum+= currentNum[i];
                    }
                }

                if (evenSum == oddSum)
                {
                    Console.Write($"{start} ");
                }
            }
        }
    }
}
