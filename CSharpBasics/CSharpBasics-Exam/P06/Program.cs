using System;

namespace P06_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            for (int a = 1; a <= input[2]-'0'; a++)
            {
                for (int b = 1; b <= input[1]-'0'; b++)
                {
                    for (int c = 1; c <= input[0]-'0'; c++)
                    {
                        Console.WriteLine($"{a} * {b} * {c} = {c*a*b};");
                    }
                }
            }
        }
    }
}
