using System;

namespace P04.TouristShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int count = 0;
            double leftMoney = budget;

            while (input != "Stop") //или при заявка за купуване на продукт, чиято стойност е по-висока от наличния бюджет
            {
                //Всеки трети продукт е на половин цена.
                double priceForProduct = double.Parse(Console.ReadLine());
                count++;

                if (count % 3 == 0)
                {
                    priceForProduct /= 2;
                }

                leftMoney -= priceForProduct;

                if (leftMoney < 0)
                {
                    Console.WriteLine($"You don't have enough money!");
                    Console.WriteLine($"You need {Math.Abs(leftMoney):f2} leva!");
                    break;
                }

                input = Console.ReadLine();
            }

            if (input == "Stop")
            {
                Console.WriteLine($"You bought {count} products for {budget-leftMoney:f2} leva.");
            }
        }
    }
}
