using System;

namespace P01.SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[3];
            CreateArray(num);
            Console.WriteLine(SmallestOfThreeNumbers(num));
        }

        static int[] CreateArray(int[] num)
        {
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());

            }
            return num;
        }
        static int SmallestOfThreeNumbers(int[] num)
        {
            int smallestNum = int.MaxValue;

            for (int i = 0; i < 3; i++)
            {
                if (num[i] < smallestNum)
                {
                    smallestNum = num[i];
                }
            }

            return smallestNum;
        }
    }
}