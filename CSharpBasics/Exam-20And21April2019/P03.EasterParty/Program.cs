using System;

namespace P03.EasterParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Брой гости – цяло число в интервала [1...99] 
            int guests = int.Parse(Console.ReadLine());
            //Цена на куверт за един човек – реално число в интервала[0.00 … 99.00]
            double priceForPerson = double.Parse(Console.ReadLine());
            //Бюджетът на Деси  – реално число в интервала[0.00 … 9999.00]
            double budget = double.Parse(Console.ReadLine());
            double totalPrice = 0;

            if (guests >= 10 && guests <= 15)
            {
                priceForPerson -= priceForPerson * 0.15; //15 % отстъпка от куверта за един човек

            }
            else if (guests > 15 && guests <= 20)
            {
                priceForPerson -= priceForPerson * 0.2; // 20 % отстъпка от куверта за един човек

            }
            else if (guests > 20)
            {
                priceForPerson -= priceForPerson * 0.25; //25 % отстъпка от куверта за един човек

            }

            double cake = budget * 0.1; //Цената на тортата е 10% от бюджета на Деси
            totalPrice = priceForPerson * guests + cake;

            if (budget >= totalPrice)
            {
                Console.WriteLine($"It is party time! {budget-totalPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"No party! {totalPrice-budget:f2} leva needed.");
            }
        }
    }
}
