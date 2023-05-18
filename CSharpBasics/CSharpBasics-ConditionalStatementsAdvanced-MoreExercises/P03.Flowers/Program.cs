using System;

namespace P03.Flowers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // броят на закупените хризантеми – цяло число в интервала [0 ... 200]
            double chrysanthemum = double.Parse(Console.ReadLine());
            // броят на закупените рози – цяло число в интервала[0... 200]
            double rose = double.Parse(Console.ReadLine());
            // броят на закупените лалета – цяло число в интервала[0... 200]
            double tulip = double.Parse(Console.ReadLine());
            // сезона – [Spring, Summer, Аutumn, Winter]
            string seasson = Console.ReadLine();
            // дали денят е празник – [Y – да / N - не]
            char holiday = char.Parse(Console.ReadLine());
            double price = 0;
            double flowersNum = chrysanthemum + rose + tulip;
            if (seasson == "Summer" || seasson == "Spring")
            {
                price = (chrysanthemum * 2) + (rose * 4.1) + (tulip * 2.5);
            }
            else if (seasson == "Autumn" || seasson == "Winter")
            {

                price = (chrysanthemum * 3.75) + (rose * 4.5) + (tulip * 4.15);
            }
            //В празнични дни цените на всички цветя се увеличават с 15%. Предлагат се следните отстъпки:
            if (holiday == 'Y')
            {
                price += price * 0.15;
            }

            if (tulip > 7 && seasson == "Spring") //За закупени повече от 7 лалета през пролетта – 5 % от цената на целият букет.
            {
                price -= price * 0.05;
            }
            else if (rose >= 10 && seasson == "Winter") //За закупени 10 или повече рози през зимата – 10 % от цената на целият букет.
            {
                price -= price * 0.1;
            }

            if (flowersNum > 20) //За закупени повече от 20 цветя общо през всички сезони – 20 % от цената на целият букет.
            {
                price -= price * 0.2;
            }

            price = price + 2;
            Console.WriteLine($"{price:f2}");
            
            
            


        }
    }
}
