using System;

namespace P03.ThirdTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string plant = Console.ReadLine();
            double number = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double bonus = 0;


            double priceRosa = number * 5;
            double priceDahlas = number * 3.8;
            double priceTulips = number * 2.8;
            double priceNarcis = number * 3;
            double priceGladio = number * 2.5;


            if (plant == "Roses" && number > 80)
            {
                bonus = (priceRosa * 0.9);
            }

            else if (plant == "Roses" && number <= 80)
                bonus = priceRosa;

            else if (plant == "Dahlias" && number > 90)
            {
                bonus = priceDahlas * 0.85;
            }

            else if (plant == "Dahlias" && number <= 90)
                bonus = priceDahlas;

            else if (plant == "Tulips" && number > 80)
            {
                bonus = priceTulips * 0.85;
            }

            else if (plant == "Tulips" && number <= 80)
                bonus = priceTulips;

            else if (plant == "Narcissus" && number < 120)
            {
                bonus = priceNarcis + (priceNarcis * 0.15);
            }

            else if (plant == "Narcissus" && number >= 120)
                bonus = priceNarcis;

            else if (plant == "Gladiolus" && number < 80)
            {
                bonus = priceGladio + (priceGladio * 0.2);
            }

            else if (plant == "Gladiolus" && number <= 80)
                bonus = priceGladio;

            if (bonus <= budget)
            {
                double price = Math.Abs(bonus - budget);
                Console.WriteLine($"Hey, you have a great garden with {number} {plant} and {price:f2} leva left.");
            }
            else
            {
                double price = Math.Abs(bonus - budget);
                Console.WriteLine("Not enough money, you need {0:f2} leva more.", price);
            }

            }
    }
}
