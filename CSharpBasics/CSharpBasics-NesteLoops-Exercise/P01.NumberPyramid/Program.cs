using System;

namespace P01.NumberPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int num = 1;

            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{num} ");
                    num++;

                    if (num > number)
                    {
                        break;
                    }
                }
                if (num > number)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
