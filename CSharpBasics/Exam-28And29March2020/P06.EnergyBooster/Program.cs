using System;

namespace P06.EnergyBooster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Плод - текст с възможности: "Watermelon", "Mango", "Pineapple" или "Raspberry"
            string fruit = Console.ReadLine();
            //Размерът на сета -текст с възможности: "small" или "big"
            string setSize = Console.ReadLine();
            //Брой на поръчаните сетове - цяло число в интервала[1 … 10000]
            int numberSet = int.Parse(Console.ReadLine());
            double price = 0;

            if (setSize == "small")
            {
                if (fruit == "Watermelon")
                {
                    numberSet *= 2;
                    price = numberSet * 56;
                }
                else if (fruit == "Mango")
                {
                    numberSet *= 2;
                    price = numberSet * 36.66;
                }
                else if (fruit == "Pineapple")
                {
                    numberSet *= 2;
                    price = numberSet * 42.1;
                }
                else if (fruit == "Raspberry")
                {
                    numberSet *= 2;
                    price = numberSet * 20;
                }
            }
            else
            {
                if (fruit == "Watermelon")
                {
                    numberSet *= 5;
                    price = numberSet * 28.7;
                }
                else if (fruit == "Mango")
                {
                    numberSet *= 5;
                    price = numberSet * 19.6;
                }
                else if (fruit == "Pineapple")
                {
                    numberSet *= 5;
                    price = numberSet * 24.8;
                }
                else if (fruit == "Raspberry")
                {
                    numberSet *= 5;
                    price = numberSet * 15.2;
                }
            }

            if (price >= 400 && price <= 1000)
            {
                price -= price * 0.15; //•	от 400 лв. до 1000 лв. включително има 15% отстъпка
            }
            else if (price > 1000)
            {
                price -= price * 0.5;  //над 1000 лв.има 50 % отстъпка
            }

            Console.WriteLine($"{price:f2} lv.");
        }
    }
}
