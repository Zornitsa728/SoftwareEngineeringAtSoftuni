using System;

namespace P03.WorldSnookerChampionship
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.	Етап на първенството – текст - “Quarter final ”, “Semi final” или “Final”
            string stage = Console.ReadLine();
            //2.Вид на билета – текст - “Standard”, “Premium” или “VIP”
            string ticketType = Console.ReadLine();
            //3.Брой билети – цяло число в интервала[1 … 30]
            int numTickets = int.Parse(Console.ReadLine());
            //4.Снимка с трофея – символ – 'Y'(да) или 'N'(не)
            char picture = char.Parse(Console.ReadLine());
            double price = 0;

            if (ticketType == "Standard")
            {
                if (stage == "Quarter final")
                {
                    price = 55.5;
                }
                else if (stage == "Semi final")
                {
                    price = 75.88;
                }
                else
                {
                    price = 110.1;
                }
            }
            else if (ticketType == "Premium")
            {
                if (stage == "Quarter final")
                {
                    price = 105.2;
                }
                else if (stage == "Semi final")
                {
                    price = 125.22;
                }
                else
                {
                    price = 160.66;
                }
            }
            else
            {
                if (stage == "Quarter final")
                {
                    price = 118.9;
                }
                else if (stage == "Semi final")
                {
                    price = 300.4;
                }
                else
                {
                    price = 400;
                }
            }
            double totalPrice = numTickets * price;

            if (totalPrice < 2500)
            {
                if (picture == 'Y')
                {
                    totalPrice += numTickets * 40;
                }
            }else if (totalPrice > 4000)
            {
                totalPrice -= totalPrice * 0.25; //25% отстъпка и безплатни снимки с трофея 
            }
            else if (totalPrice > 2500)
            {
                // 10% и проверка за снимка 
                totalPrice -= totalPrice * 0.10;
                if (picture == 'Y')
                {
                    totalPrice += numTickets* 40;
                }
            }

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
