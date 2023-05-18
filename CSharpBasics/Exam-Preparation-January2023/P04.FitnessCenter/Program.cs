using System;

namespace P04.FitnessCenter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int customers = int.Parse(Console.ReadLine());
            int back = 0;
            int chest = 0;
            int legs = 0;
            int abs = 0;
            int proteinShake = 0;
            int proteinBar = 0;

            for (int i = 0; i < customers; i++)
            {
                string fitnessActivity = Console.ReadLine();
                //("Back", "Chest", "Legs", "Abs", "Protein shake" или "Protein bar")
                if (fitnessActivity == "Back")
                {
                    back++;
                }
                else if (fitnessActivity == "Chest")
                {
                    chest++;
                }
                else if (fitnessActivity == "Legs")
                {
                    legs++;
                }
                else if (fitnessActivity == "Abs")
                {
                    abs++;
                }
                else if (fitnessActivity == "Protein shake")
                {
                    proteinShake++;
                }
                else
                {
                    proteinBar++;
                }

            }

            Console.WriteLine($"{back} - back");
            Console.WriteLine($"{chest} - chest");
            Console.WriteLine($"{legs} - legs");
            Console.WriteLine($"{abs} - abs");
            Console.WriteLine($"{proteinShake} - protein shake");
            Console.WriteLine($"{proteinBar} - protein bar");
            Console.WriteLine($"{((double)customers - (proteinBar + proteinShake)) / customers * 100:f2}% - work out");
            Console.WriteLine($"{(proteinShake + proteinBar) / (double)customers * 100:f2}% - protein");
        }
    }
}
