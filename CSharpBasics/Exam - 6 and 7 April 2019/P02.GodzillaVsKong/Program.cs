using System;

namespace P02.GodzillaVsKong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int extrasNum = int.Parse(Console.ReadLine());
            double priceForClothesForOneExtra = double.Parse(Console.ReadLine());

            double decor = budget * 0.1;

            if (extrasNum > 150)
            {
                priceForClothesForOneExtra *= 0.9;
            }

            double totalPrice = decor + extrasNum * priceForClothesForOneExtra;

            if (totalPrice > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {totalPrice - budget:f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget-totalPrice:f2} leva left.");
            }
        }
    }
}
