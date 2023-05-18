using System;

namespace P03.TravelAgency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Име на града - текст с възможности ("Bansko",  "Borovets", "Varna" или "Burgas")
            string city = Console.ReadLine();
            //Вид на пакета - текст с възможности ("noEquipment",  "withEquipment", "noBreakfast" или "withBreakfast")
            string type = Console.ReadLine();
            //Притежание на VIP отстъпка - текст с възможности  "yes" или "no"
            string vip = Console.ReadLine();
            //Дни за престой - цяло число в интервала [1 … 10000]
            int days = int.Parse(Console.ReadLine());
            double price = 0;
            bool invalidInput = true;

            if (city == "Bansko" || city == "Borovets")
            {
                if (type == "withEquipment")
                {
                    price = 100;
                    if (vip == "yes")
                    {
                        price -= price * 0.1;
                    }
                }
                else if (type == "noEquipment")
                {
                    price = 80;
                    if (vip == "yes")
                    {
                        price -= price * 0.05;
                    }
                }
                else
                {
                    invalidInput = false;
                }
            }
            else if (city == "Varna" || city == "Burgas")
            {
                if (type == "withBreakfast")
                {
                    price = 130;
                    if (vip == "yes")
                    {
                        price -= price * 0.12;
                    }
                }
                else if (type == "noBreakfast")
                {
                    price = 100;
                    if (vip == "yes")
                    {
                        price -= price * 0.07;
                    }
                }
                else
                {
                    invalidInput = false;
                }

            }
            else
            {
                invalidInput = false;
            }



            if (days < 1)
            {
                Console.WriteLine("Days must be positive number!");
            }
            else if (!invalidInput)
            {
                Console.WriteLine("Invalid input!");
            }
            else
            {
                if (days > 7)
                {
                    days -= 1;
                }
                Console.WriteLine($"The price is {price * days:f2}lv! Have a nice time!");
            }


        }
    }
}
