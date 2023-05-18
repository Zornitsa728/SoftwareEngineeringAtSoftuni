using System;

namespace P04.CinemaVoucher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valueVoucher = double.Parse(Console.ReadLine());
            string purchase;
            int countTickets = 0;
            int countPurchase = 0;

            while ((purchase = Console.ReadLine()) != "End")
            {
                double price = 0;

                if (purchase.Length > 8)
                {
                    
                    price += purchase[0] + purchase[1];
                    valueVoucher -= price;

                    if (valueVoucher - price < 0)
                    {
                        break;
                    }
                    else if (valueVoucher == 0)
                    {
                        countTickets++;
                        break;
                    }
                    countTickets++;
                }
                else
                {
                    price += purchase[0];
                    valueVoucher -= price; 

                    if (valueVoucher < 0)
                    {
                        break;
                    }
                    else if (valueVoucher == 0)
                    {
                        countPurchase++;
                        break;
                    }
                    countPurchase++;
                }
            }

            Console.WriteLine($"{countTickets}");
            Console.WriteLine($"{countPurchase}");
        }
    }
}
