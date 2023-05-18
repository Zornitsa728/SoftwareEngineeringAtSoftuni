using System;

namespace P01.PoolDay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            double taxEntrance = double.Parse(Console.ReadLine());
            double priceLounger = double.Parse(Console.ReadLine());
            double priceUmbrella = double.Parse(Console.ReadLine());

            priceLounger = (Math.Ceiling(people * 0.75)) * priceLounger;
            priceUmbrella = (Math.Ceiling((double)people / 2)) * priceUmbrella;
            double totalPrice = people * taxEntrance + priceLounger + priceUmbrella;

            Console.WriteLine($"{totalPrice:f2} lv.");
        }
    }
}
