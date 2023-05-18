using System;

namespace P03.OscarsWeekInCinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();  
            string typeHall = Console.ReadLine();
            int tickets = int.Parse(Console.ReadLine());
            double price = 0;

            if (movieName == "A Star Is Born")
            {
                if (typeHall == "normal")
                {
                    price = 7.5;
                }
                if (typeHall == "luxury")
                {
                    price = 10.5;
                }
                if (typeHall == "ultra luxury")
                {
                    price = 13.5;
                }
            }
            else if (movieName == "Bohemian Rhapsody")
            {
                if (typeHall == "normal")
                {
                    price = 7.35;
                }
                if (typeHall == "luxury")
                {
                    price = 9.45;
                }
                if (typeHall == "ultra luxury")
                {
                    price = 12.75;
                }
            }
            else if(movieName == "Green Book")
            {
                if (typeHall == "normal")
                {
                    price = 8.15;
                }
                if (typeHall == "luxury")
                {
                    price = 10.25;
                }
                if (typeHall == "ultra luxury")
                {
                    price = 13.25;
                }
            }
            else if (movieName == "The Favourite")
            {
                if (typeHall == "normal")
                {
                    price = 8.75;
                }
                if (typeHall == "luxury")
                {
                    price = 11.55;
                }
                if (typeHall == "ultra luxury")
                {
                    price = 13.95;
                }
            }

            double totalPrice = tickets * price;
            Console.WriteLine($"{movieName} -> {totalPrice:f2} lv.");
        }
    }
}
