using System;

namespace P04.VegetableMarket
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double priceForKgVegetables = double.Parse(Console.ReadLine());
            double priceForKgFruits = double.Parse(Console.ReadLine());
            double totalKgVegetables = double.Parse(Console.ReadLine()) * priceForKgVegetables;
            double totalKgFruits = double.Parse(Console.ReadLine()) * priceForKgFruits;
            double totalSum = totalKgVegetables + totalKgFruits;
            double convertLvToEuro = totalSum / 1.94;
            Console.WriteLine($"{convertLvToEuro:f2}");

        }
    }
}
