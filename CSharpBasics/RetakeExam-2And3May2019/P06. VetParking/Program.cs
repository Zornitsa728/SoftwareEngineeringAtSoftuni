using System;

namespace P06._VetParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Брой дни – цяло число в интервала [1 … 5]
            int days = int.Parse(Console.ReadLine());
            //Брой часове за всеки един от дните - цяло число в интервала[1 … 24
            int hours = int.Parse(Console.ReadLine());
            double price = 0;
            double totalPrice = 0;

            for (int i = 1; i <= days; i++)
            {
                bool even = false;
                price = 0;

                if (i % 2 == 0)
                {
                    even = true;
                }

                for (int f = 1; f <= hours; f++)
                {
                    if (f % 2== 1 && even == true)
                    {
                        price += 2.5;
                    }
                    else if (f % 2 == 0 && even == false)
                    {
                        price += 1.25;
                    }
                    else
                    {
                        price += 1;
                    }  
                }

                totalPrice += price;
                Console.WriteLine($"Day: {i} - {price:f2} leva");
            }

            Console.WriteLine($"Total: {totalPrice:f2} leva");
        }
    }
}
