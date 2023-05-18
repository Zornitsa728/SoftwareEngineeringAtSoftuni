using System;
using System.Xml.Schema;

namespace P03.NewHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfFlowers = Console.ReadLine();
            int numberOfFlowers = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double price = 0;
            double discount = 0;
            double overprice = 0;
            double totalPrice= 0;

            if (typeOfFlowers == "Roses")
            {
                price = 5;
                if (numberOfFlowers > 80)
                {
                    discount = numberOfFlowers * price * 10 / 100;
                }
            }
            else if (typeOfFlowers == "Dahlias")
            {
                price = 3.8;
                if(numberOfFlowers>90)
                {
                    discount = numberOfFlowers * price * 15 / 100;
                }
            }
            else if (typeOfFlowers == "Tulips")
            {
                price = 2.8;
                if (numberOfFlowers > 80)
                {
                   discount = numberOfFlowers * price * 15 / 100;
                }
            }
            else if(typeOfFlowers== "Narcissus")
            {
                price = 3;
                if (numberOfFlowers < 120)
                {
                    overprice = numberOfFlowers * price * 15 / 100;
                }
            }
            else if(typeOfFlowers=="Gladiolus")
            {
                price = 2.5;
                if(numberOfFlowers < 80)
                {
                    overprice = numberOfFlowers * price * 20 / 100;
                }
            }
            
            if(discount > 0)
            {
                totalPrice = numberOfFlowers * price - discount;
            }
            else if (overprice > 0)
            {
                totalPrice = numberOfFlowers * price + overprice;
            }
            else
            { 
                totalPrice = numberOfFlowers * price;
            }
            
            if (budget >= totalPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {typeOfFlowers} and {budget-totalPrice:f2} leva left.");
            }
            else 
            {
                Console.WriteLine($"Not enough money, you need {totalPrice-budget:f2} leva more.");
            }

           
        }
    }
}
