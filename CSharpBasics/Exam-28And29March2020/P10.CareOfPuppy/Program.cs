using System;

namespace P10.CareOfPuppy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogFood = int.Parse(Console.ReadLine())*1000;
            string input;

            while ((input = Console.ReadLine()) != "Adopted")
            {
                int dailyFood = int.Parse(input);

                dogFood -= dailyFood;
            }

            if (dogFood >= 0)
            {
                Console.WriteLine($"Food is enough! Leftovers: {dogFood} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {Math.Abs(dogFood)} grams more.");
            }
        }
    }
}
