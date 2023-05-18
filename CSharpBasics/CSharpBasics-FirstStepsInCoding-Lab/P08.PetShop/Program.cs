using System;
using System.Reflection.Metadata;

namespace P08.PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogFood = int.Parse(Console.ReadLine());
            int catFood = int.Parse(Console.ReadLine());
            int priceCatFood= catFood * 4;
            double priceDogFood = dogFood * 2.50;
            string currency = " lv."; 
            Console.WriteLine((priceDogFood + priceCatFood) + currency);




        }
    }
}
