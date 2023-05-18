using System;
using System.Collections.Generic;

namespace P06.BarcodeGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int lastNum = int.Parse(Console.ReadLine());

            int firstStart = firstNum / 1000;
            int firstEnd = lastNum/ 1000;
            int secondStart = (firstNum/100) %10;
            int secondEnd = (lastNum / 100) % 10;
            int thirdStart = (firstNum / 10) % 10;
            int thirdEnd = (lastNum / 10) % 10;
            int fourthStart = firstNum% 10;
            int fourthEnd = lastNum% 10;

            for (int a = firstStart; a <= firstEnd; a++)
            {
                for (int b = secondStart; b <= secondEnd; b++)
                {
                    for (int c = thirdStart; c <= thirdEnd; c++)
                    {
                        for (int d = fourthStart; d <= fourthEnd; d++)
                        {

                            if (a % 2 != 0 && b % 2 != 0 && c % 2 != 0 && d % 2 != 0)
                            {
                                Console.Write($"{a}{b}{c}{d} ");
                            }
                        }
                    }
                }    
            }
        }
    }
}
