using System;

namespace P01.FruitMarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Цена на ягодите в лева – реално число в интервала [0.00 … 10000.00]
            double priceStrawberries = double.Parse(Console.ReadLine());
            //Количество на бананите в килограми – реално число в интервала [0.00 … 1 0000.00]
            double kgBananas = double.Parse(Console.ReadLine());
            //Количество на портокалите в килограми – реално число в интервала [0.00 … 10000.00]
            double kgOranges = double.Parse(Console.ReadLine());
            //Количество на малините в килограми – реално число в интервала [0.00 … 10000.00]
            double kgRaspberry = double.Parse(Console.ReadLine());
            //Количество на ягодите в килограми – реално число в интервала [0.00 … 10000.00]
            double kgStrawberries = double.Parse(Console.ReadLine());

            //цената на малините е на половина по-ниска от тази на ягодите;
            double priceRaspberry = priceStrawberries/2;
            //цената на портокалите е с 40% по-ниска от цената на малините;
            double priceOranges = priceRaspberry - priceRaspberry * 0.4;
            //цената на бананите е с 80% по-ниска от цената на малините.
            double priceBananas = priceRaspberry - priceRaspberry * 0.8;

            double totalPrice = priceRaspberry*kgRaspberry+priceBananas*kgBananas+priceOranges*kgOranges+priceStrawberries*kgStrawberries;
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
