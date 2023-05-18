using System;

namespace P04.Darts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string playerName = Console.ReadLine();
            string input;
            int points = 301;
            int countUnsuccessful = 0;
            int countSuccessful = 0;

            while ((input = Console.ReadLine()) != "Retire")
            {
                int currentPoints = int.Parse(Console.ReadLine());

                if (input == "Double")
                {
                    currentPoints *= 2;
                }
                else if (input == "Triple")
                {
                    currentPoints *= 3;
                }

                if (currentPoints > points)
                {
                    countUnsuccessful++;
                    continue;
                }

                points -= currentPoints;
                countSuccessful++;

                if (points == 0)
                {
                    break;
                }
            }

            if (input == "Retire")
            {
                Console.WriteLine($"{playerName} retired after {countUnsuccessful} unsuccessful shots.");
            }
            else
            {
                Console.WriteLine($"{playerName} won the leg with {countSuccessful} shots.");
            }

        }
    }
}
