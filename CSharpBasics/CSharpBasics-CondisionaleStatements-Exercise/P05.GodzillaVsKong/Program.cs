using System;

namespace P05.GodzillaVsKong
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            double movieBudget = double.Parse(Console.ReadLine());
            int extras = int.Parse(Console.ReadLine());
            double priceForClothes = double.Parse(Console.ReadLine());
            double decor = movieBudget*0.1;
            double totalClothes = extras * priceForClothes;
            if (extras >= 150)
            {
                totalClothes -= totalClothes * 0.1;
            }
            double allSum = totalClothes + decor;
            if (allSum>movieBudget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {allSum-movieBudget:F2} leva more.");
            }
             else if(allSum<=movieBudget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {movieBudget-allSum:F2} leva left.");
            }


        }
    }
}
