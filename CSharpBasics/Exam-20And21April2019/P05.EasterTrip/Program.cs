using System;

namespace P05.EasterTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Първи ред - дестинация - текст с възможности"France", "Italy" или "Germany"
            string destination = Console.ReadLine();
	       //Втори ред -дати, през които си е резервирала екскурзията -текст  с възможности "21-23", "24-27" или "28-31"
           string dates = Console.ReadLine();
	       //Трети ред -брой нощувки - цяло число в интервала[1… 100]
           int nightsToStayIn = int.Parse(Console.ReadLine());
            int price = 0;

            if (destination == "France")
            {
                if (dates == "21-23")
                {
                    price = 30;
                }
                else if (dates == "24-27")
                {
                    price = 35;
                }
                else if(dates == "28-31")
                {
                    price = 40;
                }
            }
            else if (destination == "Italy")
            {
                if (dates == "21-23")
                {
                    price = 28;
                }
                else if (dates == "24-27")
                {
                    price = 32;
                }
                else if (dates == "28-31")
                {
                    price = 39;
                }
            }
            else
            {
                if (dates == "21-23")
                {
                    price = 32;
                }
                else if (dates == "24-27")
                {
                    price = 37;
                }
                else if (dates == "28-31")
                {
                    price = 43;
                }
            }
            int expenses = price * nightsToStayIn;
            Console.WriteLine($"Easter trip to {destination} : {expenses:f2} leva.");

        }
    }
}
