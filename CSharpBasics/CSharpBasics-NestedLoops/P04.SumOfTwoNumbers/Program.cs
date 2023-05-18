using System;

namespace P04.SumOfTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingNum = int.Parse(Console.ReadLine());
            int endingNum = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int combinations = 0;
            int result = 0;
            bool magic = false;

            for (int x1 = startingNum; x1 <= endingNum; x1++)
            {
                for (int x2 = startingNum; x2 <= endingNum; x2++)
                {
                    result = x1 + x2;
                    combinations++;

                   if (result == magicNum)
                   {
                       Console.WriteLine($"Combination N:{combinations} ({x1} + {x2} = {magicNum})");
                       magic = true;
                       break;
                   }
                  
                }

                if (magic)
                {
                    break;
                }
            }

            if (!magic)
            {
                Console.WriteLine($"{combinations} combinations - neither equals {magicNum}");
            }
        }
    }
}
