using System;

namespace P00.Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int numOne = input / 100;
            int numTwo = (input/10) % 10;
            int numThree = input % 10;

            for (int a = 1; a <= numThree; a++)
            {
                for (int b = 1; b <= numTwo; b++)
                {
                    for (int c = 1; c <= numOne; c++)
                    {
                        Console.WriteLine($"{a} * {b} * {c} = {c * a * b};");
                    }
                }
            }
        }
    }
}
