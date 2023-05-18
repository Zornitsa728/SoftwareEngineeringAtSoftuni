using System;

namespace P07.HotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //На първия ред е месецът – May, June, July, August, September или October
            string month = Console.ReadLine();
	       //На втория ред е броят на нощувките – цяло число в интервала[0... 200]
           int nights = int.Parse(Console.ReadLine());
            double studio = 0;
            double apartment = 0;
       
            if (month == "May" || month == "October") //За студио, при повече от 7 нощувки през май и октомври : 5% намаление.
            {                                       //За студио, при повече от 14 нощувки през май и октомври: 30 % намаление.
                studio = nights * 50;
                apartment = nights * 65;
                if (nights > 7 && nights <= 14)
                {
                    studio -= studio* 0.05;
                }
                else if (nights > 14)
                {
                    studio -= studio * 0.3;
                }
            }  //За студио,при повече от 14 нощувки през юни и септември:20% намаление
            else if (month == "June" || month == "September")
            {
                studio = nights * 75.2;
                apartment = nights * 68.7;
                if (nights > 14)
                {
                    studio -= studio * 0.2;
                }
            }
            else if (month == "July" || month == "August")
            {
                studio = nights * 76;
                apartment = nights * 77;
            }

            if (nights > 14)
            {
                //За апартамент, при повече от 14 нощувки, без значение от месеца: 10% намаление.
                apartment -= apartment * 0.1;
            }

            Console.WriteLine($"Apartment: {apartment:f2} lv.");
	        Console.WriteLine($"Studio: {studio:f2} lv.");

        }
    }
}
