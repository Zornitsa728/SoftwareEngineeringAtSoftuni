using System;

namespace P01.MatchTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	На първия ред е бюджетът – реално число в интервала [1 000.00 ... 1 000 000.00]
            double budget = double.Parse(Console.ReadLine());
            //•На втория ред е категорията – "VIP" или "Normal"
            string category = Console.ReadLine();
            //•На третия ред е броят на хората в групата – цяло число в интервала[1... 200]
            int numPeople = int.Parse(Console.ReadLine());
            double price = 0;
            
            switch (category)
            {
                case "VIP":
                    price = numPeople * 499.99;
                    break;
                case "Normal":
                    price = numPeople * 249.99;
                    break;
            }
            if (numPeople >= 1 && numPeople <= 4) //От 1 до 4 – 75% от бюджета.
            {
                budget -= budget * 0.75;
            }
            else if (numPeople >= 5 && numPeople <= 9) //От 5 до 9 – 60 % от бюджета.
            {
                budget -= budget * 0.6;
            }        
            else if (numPeople>=10 && numPeople<=24) //От 10 до 24 – 50 % от бюджета.
            {
                budget -= budget * 0.5;
            }
            else if (numPeople>=25 && numPeople<=49) //От 25 до 49 – 40 % от бюджета.
            {
                budget -= budget * 0.4;
            }
            else if (numPeople>=50) //50 или повече – 25 % от бюджета.
            {
                budget -= budget * 0.25;
            }

            if (budget >= price)
            {
                Console.WriteLine($"Yes! You have {budget-price:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(budget - price):f2} leva.");
            }

        }
    }
}
