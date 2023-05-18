using System;

namespace P01.EasterLunch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Брой козунаци - цяло число в интервала [0 … 99]
            int easterBread = int.Parse(Console.ReadLine());
            //Брой кори с яйца -цяло число в интервала[0 … 99]
            int eggs = int.Parse(Console.ReadLine());
            //Килограми курабии -цяло число в интервала[0 … 99]
            int biscuits = int.Parse(Console.ReadLine());

            double price = easterBread * 3.20; //Козунак  – 3.20 лв.
            price += eggs * 4.35; //Яйца –  4.35 лв.за кора с 12 яйца
            price += biscuits * 5.4;//Курабии – 5.40 лв.за килограм
            double paintForEggs = (eggs * 12) * 0.15; //Боя за яйца - 0.15 лв.за яйце
            double totalPrice = price + paintForEggs;
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
