using System;

namespace P02.BikeRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //броят младши велосипедисти. Цяло число в интервала [1…100]
            double juniorsBikers = double.Parse(Console.ReadLine());
            //броят старши велосипедисти.Цяло число в интервала[1… 100]
            double seniorsBikers = double.Parse(Console.ReadLine());
            //вид трасе – "trail", "cross-country", "downhill" или "road"
            string route = Console.ReadLine();
            double price = 0;
            double discount = 0;
            if (route == "trail")
            {
                juniorsBikers *= 5.50;
                seniorsBikers *= 7;
            }
            else if (route == "cross-country")
            {
                if (juniorsBikers + seniorsBikers < 50)
                {
                    juniorsBikers *= 8;
                    seniorsBikers *= 9.5;
                }
                else if (juniorsBikers + seniorsBikers >= 50)
                {
                    discount = (juniorsBikers * 8) * 0.25;
                    juniorsBikers = (juniorsBikers * 8) - discount;
                    discount = (seniorsBikers * 9.5) * 0.25;
                    seniorsBikers = (seniorsBikers * 9.5) - discount;
                }
            }
            else if (route == "downhill")
            {
                juniorsBikers *= 12.25;
                seniorsBikers *= 13.75;
            }
            else if (route == "road")
            {
                juniorsBikers *= 20;
                seniorsBikers *= 21.5;
            }
            price = juniorsBikers + seniorsBikers;
            price -= price * 0.05; 
            Console.WriteLine($"{price:f2}");
        }
    }
}
