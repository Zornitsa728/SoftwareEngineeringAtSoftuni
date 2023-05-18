using System;
using System.Xml.Schema;

namespace P02.Safari
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //•	Бюджет – реално число в интервала [0.00… 10000.00]
            double budget = double.Parse(Console.ReadLine());
            //•	Колко литра гориво ще са им нужни – реално число в интервала [1.00… 50.00]
            double fuel = double.Parse(Console.ReadLine());
            //•	Ден от седмицата – текст с възможности "Saturday" и "Sunday" 
            string day = Console.ReadLine();

            fuel *= 2.1;
            int priceForTourGuide = 100;
            double totalPrice = fuel + priceForTourGuide;

            if (day == "Saturday")
            {
                totalPrice -= totalPrice * 0.1;
            }
            else
            {
                totalPrice -= totalPrice * 0.2;
            }

            if (budget >= totalPrice)
            {
                Console.WriteLine($"Safari time! Money left: {budget - totalPrice:f2} lv. ");
            }
            else
            {
                Console.WriteLine($"Not enough money! Money needed: {totalPrice - budget:f2} lv.");
            }
        }
    }
}
