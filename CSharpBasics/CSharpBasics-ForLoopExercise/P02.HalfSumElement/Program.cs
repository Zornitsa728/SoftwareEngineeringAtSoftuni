using System;

namespace P02.HalfSumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //чете n-на брой цели числа
            int n = int.Parse(Console.ReadLine());
            int maxNum = int.MinValue;
            int sum = 0;

            for (int i =0; n>i; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                sum+= currentNumber;
                if (currentNumber > maxNum)
                {
                    maxNum= currentNumber;
                }
            }
            int sumWithoutMaxNum = sum - maxNum;
            if (sumWithoutMaxNum == maxNum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sumWithoutMaxNum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(maxNum-sumWithoutMaxNum)}");
            }
            
        }
    }
}
