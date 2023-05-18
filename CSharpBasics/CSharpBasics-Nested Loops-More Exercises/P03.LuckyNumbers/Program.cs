using System;

namespace P03.LuckyNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //Щастливо число е 4-цифрено число, на което сбора от първите две цифри е равен на сбора от последните две.
            //Числото N трябва да се дели без остатък от сбора на първите две цифри на "щастливото" число.
            for (int a = 1; a <=9; a++)
            {
                for (int b = 1; b <=9; b++)
                {
                    for (int c = 1; c <=9; c++)
                    {
                        for (int d = 1; d <=9; d++)
                        {
                            if (n % (a + b) == 0)
                            {
                                if (a + b == c + d)
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
}
