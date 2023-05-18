using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace P05.SmallShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;

            if(city == "Sofia")
            {
                if(product == "coffee")
                {
                    price = 0.5;
                }
                else if (product == "water")
                {
                    price = 0.8;
                }
                else if (product == "beer")
                {
                    price = 1.2;
                }
                else if (product == "sweets")
                {
                    price = 1.45;
                }
                else if (product == "peanuts")
                {
                    price = 1.6;
                }
            }
            else if (city == "Plovdiv")
            {
                if (product == "coffee")
                {
                    price = 0.4;
                }
                else if (product == "water")
                {
                    price = 0.7;
                }
                else if (product == "beer")
                {
                    price = 1.15;
                }
                else if (product == "sweets")
                {
                    price = 1.30;
                }
                else if (product == "peanuts")
                {
                    price = 1.5;
                }
            }
            else if (city == "Varna")
            {
                if (product == "coffee")
                {
                    price = 0.45;
                }
                else if (product == "water")
                {
                    price = 0.7;
                }
                else if (product == "beer")
                {
                    price = 1.10;
                }
                else if (product == "sweets")
                {
                    price = 1.35;
                }
                else if (product == "peanuts")
                {
                    price = 1.55;
                }   
            }

             double totalPrice = price * quantity;
             Console.WriteLine(totalPrice);

        }
    }
}
