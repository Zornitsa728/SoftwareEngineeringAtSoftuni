using System;
using System.Diagnostics.CodeAnalysis;

namespace p05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            double bankAccount = 0;

            while ((input=Console.ReadLine()) != "NoMoreMoney")
            {
                double sum = double.Parse(input); 

                if (sum > 0)
                {
                    Console.WriteLine($"Increase: {sum:f2}");
                    bankAccount += sum;
                }
                else
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
            }

            Console.WriteLine($"Total: {bankAccount:f2}");
        }
    }
}
