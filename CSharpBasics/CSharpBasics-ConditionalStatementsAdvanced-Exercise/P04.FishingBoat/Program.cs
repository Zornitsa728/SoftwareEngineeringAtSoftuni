using System;

namespace P04.FishingBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fisherman = int.Parse(Console.ReadLine());
            double price = 0;
            double discount = 0;
            double specialDiscount = 0;

            if (season=="Spring")
            {
                price = 3000;
            }
            else if (season=="Summer"||season=="Autumn")
            {
                price = 4200;
            }
            else if (season == "Winter")
            {
                price = 2600;
            }

            if(fisherman<=6)
            {
                discount = price * 10 / 100;
            }
            else if(fisherman>=7 && fisherman<=11)
            {
                discount = price * 15 / 100;
            }
            else 
            {
                discount = price * 25 / 100;
            }

            if (fisherman%2==0 && season!="Autumn") 
            {
                specialDiscount = (price-discount) * 5 / 100;
            }

            double totalPrice = price - (discount+specialDiscount);

            if (totalPrice <= budget)
            {
                Console.WriteLine($"Yes! You have {budget - totalPrice:f2} leva left.");
            }
            else if (budget < totalPrice)
            {
                Console.WriteLine($"Not enough money! You need {totalPrice - budget:f2} leva.");
            }
        }
    }
}
