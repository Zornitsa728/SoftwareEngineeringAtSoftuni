using System;

namespace P01_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wrappingPaper = int.Parse(Console.ReadLine());
            int fabric = int.Parse(Console.ReadLine());
            double glue = double.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine())/100;

            double totalPrice = wrappingPaper * 5.8 + fabric * 7.2 + glue * 1.2;
            totalPrice -= totalPrice * discount;

            Console.WriteLine($"{totalPrice:f3}");
        }
    }
}
