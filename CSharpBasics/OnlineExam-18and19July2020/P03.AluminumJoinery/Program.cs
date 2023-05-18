using System;

namespace P03.AluminumJoinery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Брой дограми – цяло число в интервала [0..1000];
            int numJoinery = int.Parse(Console.ReadLine());
            //Вид на дограмите – текст "90X130" или "100X150" или "130X180" или "200X300";
            string typeOfJoinery = Console.ReadLine();
            //Начин на получаване – текст
            string delivery = Console.ReadLine(); //С доставка -"With delivery" Без доставка -"Without delivery"
            double price = 0;

            if (typeOfJoinery == "90X130")
            {
                price = numJoinery * 110;
                if (numJoinery > 60)
                {
                    price -= price * 0.08; 
                }
                else if (numJoinery > 30)
                {
                    price -= price * 0.05;
                }
            }
            else if (typeOfJoinery == "100X150")
            {
                price = numJoinery * 140;
                if (numJoinery > 80)
                {
                    price -= price * 0.1;
                }
                else if (numJoinery > 40)
                {
                    price -= price * 0.06;
                }
            }
            else if (typeOfJoinery == "130X180")
            {
                price = numJoinery * 190;
                if (numJoinery > 50)
                {
                    price -= price * 0.12;
                }
                else if (numJoinery > 20)
                {
                    price -= price * 0.07;
                }
            }
            else
            {
                price = numJoinery * 250;
                if (numJoinery > 50)
                {
                    price -= price * 0.14;
                }
                else if (numJoinery > 25)
                {
                    price -= price * 0.09;
                }
            }

            if (delivery == "With delivery")
            {
                price += 60;
            }

            if (numJoinery > 99)
            {
                price -= price * 0.04;
            }

            if (numJoinery <= 10)
            {
                Console.WriteLine("Invalid order");
            }
            else 
            {
                Console.WriteLine($"{price:f2} BGN");
            }
          
        }
    }
}
