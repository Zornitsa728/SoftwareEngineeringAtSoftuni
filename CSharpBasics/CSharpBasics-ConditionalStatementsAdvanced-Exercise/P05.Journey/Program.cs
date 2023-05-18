using System;

namespace P05.Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	Първи ред – Бюджет, реално число в интервала [10.00...5000.00]
            double budget = double.Parse(Console.ReadLine());
            //Втори ред –  Един от двата възможни сезона: „summer” или “winter”
            string seasson = Console.ReadLine();
            double price = 0;
            string destination = string.Empty; //“Bulgaria", "Balkans” и ”Europe”
            string placeToStay = string.Empty;
            //Бюджета определя дестинацията, а сезона определя колко от бюджета ще изхарчи. 
            //Ако е лято ще почива на къмпинг, а зимата в хотел. 
            if (budget <= 100)
            {
                destination = "Bulgaria"; //При 100лв. или по-малко – някъде в България
                if (seasson == "summer")  // Лято – 30 % от бюджета
                {
                    price = budget * 30 / 100;
                    placeToStay = "Camp";
                }
                else if (seasson == "winter") //Зима – 70 % от бюджета
                {
                    price = budget * 70 / 100;
                    placeToStay = "Hotel";
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans"; //При 1000лв.или по малко – някъде на Балканите
                if (seasson == "summer") //Лято – 40 % от бюджета
                {
                    price = budget * 40 / 100;
                    placeToStay = "Camp";
                }
                else if (seasson == "winter") //Зима – 80 % от бюджета
                {
                    price = budget * 80 / 100;
                    placeToStay = "Hotel";
                }
            }
            else if (budget > 1000) //При повече от 1000лв. – някъде из Европа
            {
                destination = "Europe";
                price = budget * 90 / 100; //При пътуване из Европа, независимо от сезона ще похарчи 90 % от бюджета.
                placeToStay = "Hotel";
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{placeToStay} - {price:f2}");

        }
    }
}
