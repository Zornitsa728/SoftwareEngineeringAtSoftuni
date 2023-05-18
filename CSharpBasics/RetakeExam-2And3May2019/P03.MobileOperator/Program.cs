using System;

namespace P03.MobileOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Срок на договор – текст – "one", или "two"
            string durationOfContract = Console.ReadLine();
            //Тип на договор – текст – "Small",  "Middle", "Large"или "ExtraLarge"
            string typeOfContract = Console.ReadLine();
            //Добавен мобилен интернет – текст – "yes" или "no"
            string internet = Console.ReadLine();
            //Брой месеци за плащане - цяло число в интервала [1 … 24]
            int months = int.Parse(Console.ReadLine());
            double pricePerMont = 0;
            double totalPrice = 0;

            if (durationOfContract == "one")
            {
                if (typeOfContract == "Small")
                {
                    pricePerMont = 9.98;
                }
                else if (typeOfContract =="Middle")
                {
                    pricePerMont = 18.99;
                }
                else if (typeOfContract == "Large")
                {
                    pricePerMont = 25.98;
                }
                else
                {
                    pricePerMont = 35.99;
                }
            }
            else
            {
                if (typeOfContract == "Small")
                {
                    pricePerMont = 8.58;
                }
                else if (typeOfContract == "Middle")
                {
                    pricePerMont = 17.09;
                }
                else if (typeOfContract == "Large")
                {
                    pricePerMont = 23.59;
                }
                else
                {
                    pricePerMont = 31.79;
                }
            }

            if (internet == "yes")
            {
                if (pricePerMont <= 10)
                {
                    pricePerMont += 5.5;
                }
                else if (pricePerMont <= 30)
                {
                    pricePerMont += 4.35;
                }
                else
                {
                    pricePerMont += 3.85;
                }
            }

            totalPrice = pricePerMont * months;

            if (durationOfContract == "two")
            {
                totalPrice -= totalPrice * 0.0375;
                Console.WriteLine($"{totalPrice:f2} lv.");
            }
            else
            {
                Console.WriteLine($"{pricePerMont*months:f2} lv.");
            }
        }
    }
}
