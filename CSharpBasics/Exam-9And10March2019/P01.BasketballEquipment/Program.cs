using System;

namespace P01.BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tax = int.Parse(Console.ReadLine());
            double shoes = tax- tax*0.4;
            double clothes = shoes - shoes * 0.2;
            double ball = clothes / 4;
            double accessories = ball / 5;
            tax += shoes + clothes + ball + accessories;

            Console.WriteLine($"{tax:f2}");
        }
    }
}
