using System;

namespace P03.CelsiusToFahrenheit
{
        class Program
    {
        static void Main(string[] args)
        {
            //T (° F) = T (° C) × 1,8 + 32
            double celsius = double.Parse(Console.ReadLine());
            double formulaForFahrenheit = celsius * 1.8 + 32;
            Console.WriteLine($"{formulaForFahrenheit:f2}");
        }
    }
}
