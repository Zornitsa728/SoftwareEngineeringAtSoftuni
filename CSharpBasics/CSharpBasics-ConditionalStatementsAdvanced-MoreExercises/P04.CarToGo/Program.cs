using System;

namespace P04.CarToGo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	Първи ред – Бюджет – реално число в интервала [10.00...10000.00]
            double budget = double.Parse(Console.ReadLine());
            //•Втори ред –  Сезон – текст "Summer" или "Winter"
            string seasson = Console.ReadLine();
            string carClass = string.Empty;
            string carType = string.Empty;
            double price = 0;

            if (budget <= 100) //•	При бюджет по-малък или равен от 100лв.
            {
                carClass = "Economy class";
                if (seasson == "Summer")
                {
                    carType = "Cabrio";
                    price = budget * 0.35;
                }
                else
                {
                    carType = "Jeep";
                    price = budget * 0.65;
                }
            } //•При бюджет по - голям от 100лв.и по-малък или равен от 500лв.
            else if (budget > 100 && budget <= 500)
            {
                carClass = "Compact class";
                if (seasson == "Summer")
                {
                    carType = "Cabrio";
                    price = budget * 0.45;
                }
                else
                {
                    carType = "Jeep";
                    price = budget * 0.8;
                }
            }//•	При бюджет по - голям от 500лв.
            else if (budget > 500)
            {
                carClass = "Luxury class";
                carType = "Jeep";
                price = budget * 0.9;

            }

            Console.WriteLine($"{carClass}");
            Console.WriteLine($"{carType} - {price:f2}");
        }
    }
}
