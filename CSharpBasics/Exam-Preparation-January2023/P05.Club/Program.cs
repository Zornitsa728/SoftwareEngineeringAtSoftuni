using System;

namespace P05.Club
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //цената на един коктейл е дължината неговото име
            //. Ако цената на една поръчка е нечетно число, има 25% отстъпка от цената на поръчката. 
            double wantedProfit = double.Parse(Console.ReadLine());
            string input;
            double price = 0;
            double totalSum = 0;

            while ((input=Console.ReadLine()) != "Party!")
            {
                price = 0;
                int cocktails = int.Parse(Console.ReadLine());
                price = input.Length;
                price *= cocktails;

                if (price % 2 != 0)
                {
                    price -= price * 0.25;
                }

                totalSum+= price;
                if (wantedProfit <= totalSum)
                {
                    break;
                }
            }

            if (input == "Party!")
            {
                Console.WriteLine($"We need {wantedProfit-totalSum:f2} leva more.");
            }
            else if (wantedProfit <= totalSum)
            {
                Console.WriteLine("Target acquired.");
            }

            Console.WriteLine($"Club income - {totalSum:f2} leva.");
            
        }
    }
}
