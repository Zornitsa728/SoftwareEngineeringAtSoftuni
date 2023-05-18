using System;

namespace P03.CoffeeMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	Първи ред - напитка - текст с възможности"Espresso", "Cappuccino" или "Tea"
            string drink = Console.ReadLine();
            //•	Втори ред - захар - текст  с възможности "Without", "Normal" или "Extra"
            string sugar = Console.ReadLine();
            //•	Трети ред - брой напитки - цяло число в интервала [1… 50]
            int numberDrinks = int.Parse(Console.ReadLine());
            double price = 0;

            if (drink == "Espresso")
            {
                if (sugar == "Without")
                {
                    price = 0.9 * numberDrinks;
                    price -= price * 0.35;
                }
                else if (sugar == "Normal")
                {
                    price = numberDrinks * 1;
                }
                else
                {
                    price = numberDrinks * 1.2;
                }

                if (numberDrinks >= 5)
                {
                    price -= price * 0.25;
                }
            }
            else if (drink == "Cappuccino")
            {
                if (sugar == "Without")
                {
                    price = 1 * numberDrinks;
                    price -= price * 0.35;
                }
                else if (sugar == "Normal")
                {
                    price = numberDrinks * 1.2;
                }
                else
                {
                    price = numberDrinks * 1.6;
                }
            }
            else
            {
                if (sugar == "Without")
                {
                    price = 0.5 * numberDrinks;
                    price -= price * 0.35;
                }
                else if (sugar == "Normal")
                {
                    price = numberDrinks * 0.6;
                }
                else
                {
                    price = numberDrinks * 0.7;
                }
            }

            if (price > 15)
            {
                price -= price * 0.2;
            }

            Console.WriteLine($"You bought {numberDrinks} cups of {drink} for {price:f2} lv.");
        }
    }
}
