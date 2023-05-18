using System;

namespace P02.BirthdayParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Наем за залата – реално число в интервала[100.00..10000.00]
            double rent = double.Parse(Console.ReadLine());

            //Торта  – цената ѝ е 20% от наема на залата
            double cake = rent * 0.2;
            //Напитки – цената им е 45 % по - малко от тази на тортата
            double drinks = cake - (cake* 0.45);
            //Аниматор – цената му е 1 / 3 от цената за наема на залата
            double animator = rent / 3;
            double sum = rent + cake + drinks + animator;
            Console.WriteLine(sum);
        }
    }
}
