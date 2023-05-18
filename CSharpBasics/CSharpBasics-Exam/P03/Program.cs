using System;

namespace P03_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string season = Console.ReadLine(); 
            double price = 0;
            if (season == "spring")
            {
                if (people <= 5)
                {
                    price = people * 50;
                }
                else
                {
                    price = people * 48;
                }
            }
            else if (season == "summer")
            {
                if (people <= 5)
                {
                    price = people * 48.5;
                    price -= price * 0.15;
                }
                else
                {
                    price = people * 45;
                    price -= price * 0.15;
                }
            }
            else if (season == "autumn")
            {
                if (people <= 5)
                {
                    price = people * 60;
                }
                else
                {
                    price = people * 49.5;
                }
            }
            else
            {
                if (people <= 5)
                {
                    price = people * 86;
                    price += price * 0.08;
                }
                else
                {
                    price = people * 85;
                    price += price * 0.08;
                }
            }

            Console.WriteLine($"{price:f2} leva.");
        }
    }
}
