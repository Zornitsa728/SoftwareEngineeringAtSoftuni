using System;

namespace P03.SecondTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfFlowers = Console.ReadLine();
            int numberOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double price = 0;

            if (typeOfFlowers == "Roses")
            {
                price = 5;
                price = numberOfFlowers * price;
                if (numberOfFlowers > 80)
                {
                    price -= price * 0.1;
                }
            }
            else if (typeOfFlowers == "Dahlias")
            {
                price = 3.8;
                price = numberOfFlowers * price;
                if (numberOfFlowers > 90)
                {
                    price -= price * 0.15;
                }
            }
            else if (typeOfFlowers == "Tulips")
            {
                price = 2.8;
                price = numberOfFlowers * price;
                if (numberOfFlowers > 80)
                {
                    price -= price * 0.15;
                }
            }
            else if (typeOfFlowers == "Narcissus")
            {
                price = 3;
                price = numberOfFlowers * price;
                if (numberOfFlowers < 120)
                {
                    price += price * 0.15;
                }
            }
            else if (typeOfFlowers == "Gladiolus")
            {
                price = 2.5;
                price = numberOfFlowers * price;
                if (numberOfFlowers < 80)
                {
                    price += price * 0.2;
                }
            }

            if (budget >= price)
            {
                Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {typeOfFlowers} and {budget - price:f2} leva left.");
            }
            else if (budget < price)
            {
                Console.WriteLine($"Not enough money, you need {price - budget:f2} leva more.");
            }
        }
    }
}
