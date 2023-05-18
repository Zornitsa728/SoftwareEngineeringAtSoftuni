using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P06.BasketballTournament
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfTournament;
            int numGames;
            int winCount = 0;
            int loseCount = 0;
            int allGames = 0;

            while ((nameOfTournament=Console.ReadLine()) != "End of tournaments")
            {
                numGames = int.Parse(Console.ReadLine());

                for (int i = 1; i <= numGames; i++)
                {
                    int teamDesi = int.Parse(Console.ReadLine());
                    int teamOpponent = int.Parse(Console.ReadLine());
                    allGames++;
                    if (teamDesi>teamOpponent)
                    {
                        winCount++;
                        Console.WriteLine($"Game {i} of tournament {nameOfTournament}: win with {teamDesi-teamOpponent} points.");
                    }
                    else
                    {
                        loseCount++;
                        Console.WriteLine($"Game {i} of tournament {nameOfTournament}: lost with {teamOpponent-teamDesi} points.");
                    } 
                }
            }

            if (nameOfTournament == "End of tournaments")
            {
                Console.WriteLine($"{(double)winCount/allGames*100:f2}% matches win");
                Console.WriteLine($"{(double)loseCount/allGames*100:f2}% matches lost");
            }
        }
    }
}
