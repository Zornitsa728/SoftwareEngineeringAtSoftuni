using System;

namespace P05.EasterBake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int easterBread = int.Parse(Console.ReadLine());
            double allSugar = 0;
            double allFlour = 0;
            int maxSugar = int.MinValue;
            int maxFlour = int.MinValue;

            for (int i = 1; i <= easterBread; i++)
            { 
                int sugar = int.Parse(Console.ReadLine());
                int flour = int.Parse(Console.ReadLine());

                if (sugar > maxSugar)
                {
                    maxSugar = sugar;
                }
                if (flour > maxFlour)
                {
                    maxFlour = flour;
                }

                allSugar += sugar;
                allFlour += flour;
            }

            Console.WriteLine($"Sugar: {Math.Ceiling(allSugar / 950)}");
            Console.WriteLine($"Flour: {Math.Ceiling(allFlour / 750)}");
            Console.WriteLine($"Max used flour is {maxFlour} grams, max used sugar is {maxSugar} grams.");
        }
    }
}
