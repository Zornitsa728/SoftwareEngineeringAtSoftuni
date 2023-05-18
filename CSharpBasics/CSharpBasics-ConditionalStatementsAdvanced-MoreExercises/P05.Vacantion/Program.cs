using System;

namespace P05.Vacantion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	Първи ред – Бюджет – реално число в интервала [10.00...10000.00]
            double budget = double.Parse(Console.ReadLine());
            //• Втори ред –  Сезон – текст "Summer" или "Winter"
            string seasson = Console.ReadLine();
            string placeToStay = string.Empty;
            string location = string.Empty;
            double price = 0;

            if (budget <= 1000)
            {
                placeToStay = "Camp";
                switch (seasson)
                {
                    case "Summer":
                        location = "Alaska";
                        price = budget * 0.65;
                        break;
                    case "Winter":
                        location = "Morocco";
                        price = budget * 0.45;
                        break;
                }

            }
            else if (budget >1000 && budget <= 3000)
            {
                placeToStay = "Hut";
                switch (seasson)
                {
                    case "Summer":
                        location = "Alaska";
                        price = budget * 0.8;
                        break;
                    case "Winter":
                        location = "Morocco";
                        price = budget * 0.6;
                        break;
                }
            }
            else
            {
                placeToStay = "Hotel";
                switch (seasson)
                {
                    case "Summer":
                        location = "Alaska";
                        price = budget * 0.9;
                        break;
                    case "Winter":
                        location = "Morocco";
                        price = budget * 0.9;
                        break;
                }
            }
            Console.WriteLine($"{location} - {placeToStay} - {price:f2}");

        }
    }
}
