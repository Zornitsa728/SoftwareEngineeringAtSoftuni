using System;
using System.Diagnostics.CodeAnalysis;

namespace P09.YardGreening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cmSquare = double.Parse(Console.ReadLine());
            double price = 7.61;
            string currency = " lv.";
            double sum = cmSquare * price;
            double discount = sum * 0.18;
            Console.WriteLine($"The final price is: {sum - discount} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
