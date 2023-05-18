using System;

namespace P06.EasterCompetition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int easterBread = int.Parse(Console.ReadLine());
            string input;
            int maxPoints = int.MinValue;
            string topBaker = string.Empty;

            for (int i = 1; i <= easterBread; i++)
            {
                string bakerName = Console.ReadLine();
                int allPoints = 0;
                while ((input = Console.ReadLine()) != "Stop")
                {
                    int points = int.Parse(input);
                    allPoints+= points;
                }

                Console.WriteLine($"{bakerName} has {allPoints} points.");

                if (allPoints>maxPoints)
                {
                    maxPoints= allPoints;
                    topBaker = bakerName;
                    Console.WriteLine($"{topBaker} is the new number 1!");
                }
                
            }

            Console.WriteLine($"{topBaker} won competition with {maxPoints} points!");
        }
    }
}
