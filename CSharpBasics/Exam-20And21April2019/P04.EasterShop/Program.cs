using System;

namespace P04.EasterShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	На първи ред - Началното количество яйца в магазина - цяло число в интервала [1… 10000]
            int eggsInTheStore = int.Parse(Console.ReadLine());
            string input;
            int soldEggs = 0;
            //•	След това поредица от два реда(до получаване на команда "Close" или при заявка за купуване на повече от наличните в магазина яйца) :
            while ((input = Console.ReadLine()) != "Close")
            {
                //o Брой на яйца цяло число в интервала [1… 1000]
                int eggs = int.Parse(Console.ReadLine());

                if (input =="Buy") //o Команда ("Buy" или "Fill")
                {
                    
                    if (eggsInTheStore <= eggs)
                    {
                        if (eggsInTheStore == eggs)
                        {
                            eggsInTheStore -= eggs;
                        }
                        break;
                    }
                    else
                    {
                        eggsInTheStore -= eggs;
                    }
                    soldEggs += eggs;
                }
                else  
                {
                    eggsInTheStore += eggs;
                }

            }

            if (input == "Close")
            {
                Console.WriteLine("Store is closed!");
                Console.WriteLine($"{soldEggs} eggs sold.");
            }
            else
            {
                Console.WriteLine("Not enough eggs in store!");
                Console.WriteLine($"You can buy only {eggsInTheStore}.");
            }

        }
    }
}
