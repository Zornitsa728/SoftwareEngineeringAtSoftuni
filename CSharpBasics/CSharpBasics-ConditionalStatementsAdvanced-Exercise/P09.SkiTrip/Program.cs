using System;

namespace P09.SkiTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine(); 
            string rating = Console.ReadLine();  
            int nights = days - 1;
            double price = 0;
            switch (typeOfRoom)
            {
               case "room for one person": 
                    price = 18 *nights;
                    break;
                case "apartment": 
                    price = 25 * nights;
                    break;
                case "president apartment": 
                    price = 35*nights;
                    break;
            }
            if (nights < 10)
            {
                if (typeOfRoom == "apartment")
                {
                    price -= price * 0.3;
                }
                else if (typeOfRoom == "president apartment")
                {
                    price -= price * 0.1;
                }
            }
            else if (nights >= 10 && nights <= 15)
            {
                if (typeOfRoom == "apartment")
                {
                    price -= price * 0.35;
                }
                else if (typeOfRoom == "president apartment")
                {
                    price -= price * 0.15;
                }
            }
            else if (nights > 15)
            {
                if (typeOfRoom == "apartment")
                {
                    price -= price * 0.5;
                }
                else if (typeOfRoom == "president apartment")
                {
                    price -= price * 0.2;
                }
            }

            if (rating == "positive")
            {
                price += price * 0.25;
            }
            else if (rating == "negative")
            {
                price -= price * 0.1;
            }

            Console.WriteLine($"{price:f2}");
        }
    }
}
