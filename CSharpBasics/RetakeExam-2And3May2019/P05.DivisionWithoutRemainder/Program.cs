using System;

namespace P05.DivisionWithoutRemainder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int checkNum;
            double count2 = 0;
            double count3 = 0;
            double count4 = 0;

            for (int i = 1; i <= n; i++)
            {
                checkNum = int.Parse(Console.ReadLine());

                if (checkNum % 2 == 0)
                {
                    count2++;
                }
                if (checkNum % 3 == 0)
                {
                    count3++;   
                }
                if (checkNum % 4 == 0)
                {
                    count4++;
                }
            }

            Console.WriteLine($"{count2 / n * 100:f2}%");
            Console.WriteLine($"{count3 / n * 100:f2}%");
            Console.WriteLine($"{count4 / n * 100:f2}%");
        }
    }
}
