using System;

namespace P01.IncomeFromMovie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Име на филм - текст
            string title = Console.ReadLine();
            //2.Брой дни - цяло число в диапазона[1… 90]
            int days = int.Parse(Console.ReadLine());
            //3.Брой билети - цяло число в диапазона[100… 100000]
            int tickets = int.Parse(Console.ReadLine());
            //4.Цена на билет -реално число в диапазона[5.0… 25.0]
            double price = double.Parse(Console.ReadLine());
            //5.Процент за киното -цяло число в диапазона[5... 35]
            double percentForCinema = double.Parse(Console.ReadLine())/100;

            double income = days * (tickets * price);
            income -= income* percentForCinema;

            Console.WriteLine($"The profit from the movie {title} is {income:f2} lv.");
        }
    }
}
