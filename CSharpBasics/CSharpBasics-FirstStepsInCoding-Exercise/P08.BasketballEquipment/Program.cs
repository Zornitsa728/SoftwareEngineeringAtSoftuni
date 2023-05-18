using System;

namespace P08.BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int taxPerYear = int.Parse(Console.ReadLine());
            double shoes = taxPerYear - (taxPerYear*0.4);
            double sportsWear = shoes - (shoes*0.2);
            double ball = sportsWear * 0.25;           
            double accessories = ball * 0.2;
            double totalSum = taxPerYear + shoes + sportsWear + ball + accessories;
            Console.WriteLine(totalSum);


        }
    }
}
