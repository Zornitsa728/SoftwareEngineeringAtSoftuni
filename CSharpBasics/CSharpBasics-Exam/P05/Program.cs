using System;

namespace P05_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int seaVacantion = int.Parse(Console.ReadLine());
            int mountainVacantion = int.Parse(Console.ReadLine());
            string input;
            double price = 0;

            while ((input = Console.ReadLine()) != "Stop")
            {
               

                if (input == "sea")
                {
                    
                    if (seaVacantion > 0)
                    {
                        price += 680;
                    }
                    seaVacantion--;
                }
                else
                {
                    if (mountainVacantion > 0)
                    {
                        price += 499;
                    }
                    mountainVacantion--;
                }

                if (seaVacantion <= 0 && mountainVacantion <= 0)
                {
                    break;
                }
            }

            if (seaVacantion <= 0 && mountainVacantion <= 0)
            {
                Console.WriteLine("Good job! Everything is sold.");
            }

            Console.WriteLine($"Profit: {price} leva.");
            
        }
    }
}
