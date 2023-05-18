using System;

namespace P02_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceForParty = double.Parse(Console.ReadLine());
            int loveMessages = int.Parse(Console.ReadLine());
            int waxRoses = int.Parse(Console.ReadLine());
            int keyholder = int.Parse(Console.ReadLine());
            int caricature = int.Parse(Console.ReadLine());
            int luckSurprise = int.Parse(Console.ReadLine());

            int allItems = loveMessages + waxRoses + keyholder + caricature + luckSurprise;
            double price = loveMessages * 0.6 + waxRoses * 7.2 + keyholder * 3.6 + caricature * 18.2 + luckSurprise * 22;

            if (allItems >= 25)
            {
                price -= price * 0.35;
            }

            double expenses = price * 0.1;
            price -= expenses;

            if (price >= priceForParty)
            {
                Console.WriteLine($"Yes! {price - priceForParty:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {priceForParty - price:f2} lv needed.");
            }

        }
    }
}
