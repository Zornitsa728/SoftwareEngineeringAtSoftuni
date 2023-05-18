using System;

namespace P06.EasterDecoration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int clients = int.Parse(Console.ReadLine());
            string input;
            double sum = 0;

            for (int i = 1; i <= clients; i++)
            {
                int countPurchase = 0;
                double price = 0;

                while ((input = Console.ReadLine()) != "Finish") 
                {
                    if (input == "basket")
                    {
                        price += 1.5;
                        countPurchase++;
                    }
                    else if (input == "wreath")
                    {
                        price += 3.8;
                        countPurchase++;
                    }
                    else
                    {
                        price += 7; 
                        countPurchase++;
                    }

                }
                if (countPurchase % 2 == 0)
                {
                    sum += price - price * 0.2;
                    price -= price * 0.2;
                }
                else
                {
                    sum += price;
                }

                Console.WriteLine($"You purchased {countPurchase} items for {price:f2} leva.");
            }

            Console.WriteLine($"Average bill per client is: {sum/clients:f2} leva.");
           
        }
    }
}
