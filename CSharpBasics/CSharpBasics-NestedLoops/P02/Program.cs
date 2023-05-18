using System;

namespace P02_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int num =1; num <= 10; num++)
            {
                for (int num1 = 1; num1 <= 10; num1++)
                {
                    Console.WriteLine($"{num} * {num1} = {num*num1}");
                }
            }
        }
    }
}
