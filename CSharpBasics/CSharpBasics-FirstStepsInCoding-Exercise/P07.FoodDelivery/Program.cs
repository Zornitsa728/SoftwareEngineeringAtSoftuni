using System;

namespace P07.FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double chickenMenu = double.Parse(Console.ReadLine())*10.35;
            double fishMenu = double.Parse(Console.ReadLine())*12.40;
            double vegetarianMenu = double.Parse(Console.ReadLine())*8.15;
            double sum = chickenMenu + fishMenu + vegetarianMenu;
            double dessert = sum * 0.2;
            double delivery = 2.50;
            double totalSum = sum + dessert + delivery;
            Console.WriteLine(totalSum);
        }
    }
}
