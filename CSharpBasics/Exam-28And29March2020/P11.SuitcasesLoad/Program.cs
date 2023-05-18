using System;

namespace P11.SuitcasesLoad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double luggageArea = double.Parse(Console.ReadLine());
            string input;
            int loadedSuitcases = 0;
            int count = 0;

            while ((input = Console.ReadLine()) != "End")
            {
                double luggageVolume = double.Parse(input);
                count++;
                if (count % 3 == 0)
                {
                    luggageVolume += luggageVolume * 0.1;   
                }
                luggageArea -= luggageVolume;
                if (luggageArea < 0)
                {
                    Console.WriteLine("No more space!");
                    break;
                }
                loadedSuitcases++;
            }

            if (input == "End")
            {
                Console.WriteLine($"Congratulations! All suitcases are loaded!");
            }
            Console.WriteLine($"Statistic: {loadedSuitcases} suitcases loaded.");
        }
    }
}
