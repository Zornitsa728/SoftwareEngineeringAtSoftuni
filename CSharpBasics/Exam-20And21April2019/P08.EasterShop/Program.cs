using System;

namespace P08.EasterShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int eggsInTheStore = int.Parse(Console.ReadLine());
            int boughtEggs = 0;

            for (int i = int.MaxValue; i > eggsInTheStore; i--)
            {
                string command = Console.ReadLine(); //– текст("Buy" или "Fill")

                if (command == "Close")
                {
                    Console.WriteLine("Store is closed!");
                    Console.WriteLine($"{boughtEggs} eggs sold.");
                    break;
                }

                int numEggs = int.Parse(Console.ReadLine()); //които да бъдат купени или допълнени в магазина

                if (command == "Buy")
                {
                    if (eggsInTheStore > numEggs)
                    {
                        boughtEggs += numEggs;
                        eggsInTheStore -= numEggs;
                    }
                    else if (eggsInTheStore == numEggs)
                    {
                        Console.WriteLine("Not enough eggs in store!");
                        Console.WriteLine($"You can buy only {eggsInTheStore-numEggs}.");
                        break;
                    }
                    else 
                    {
                        Console.WriteLine("Not enough eggs in store!");
                        Console.WriteLine($"You can buy only {eggsInTheStore}.");
                        break;
                    }
                }
                else if (command == "Fill")
                {
                    eggsInTheStore += numEggs;
                } 
            }
        }
    }
}
