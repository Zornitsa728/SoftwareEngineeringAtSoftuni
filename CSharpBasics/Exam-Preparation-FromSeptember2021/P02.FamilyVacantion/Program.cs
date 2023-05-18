using System;

namespace P02.FamilyVacantion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	Бюджетът, с който разполагат – реално число в интервала[1.00 … 10000.00]
            double budget = double.Parse(Console.ReadLine());
            //•	Брой нощувки – цяло число в интервала[0 … 1000]
            int nights = int.Parse(Console.ReadLine());
            //•	Цена за нощувка – реално число в интервала[1.00 … 500.00]
            double priceForNight = double.Parse(Console.ReadLine());
            //•	Процент за допълнителни разходи – цяло число в интервала[0 … 100]
            double percent = double.Parse(Console.ReadLine())/100;
            //броят на нощувките е по-голям от 7, цената за нощувка се намаля с 5%.

            if (nights > 7)
            {
                priceForNight -= priceForNight * 0.05;
            }

            double totalPrice = nights * priceForNight + (budget * percent);

            if (totalPrice <= budget)
            {
                Console.WriteLine($"Ivanovi will be left with {budget-totalPrice:f2} leva after vacation.");
            }
            else
            {
                Console.WriteLine($"{totalPrice-budget:f2} leva needed.");
            }
        }
    }
}
