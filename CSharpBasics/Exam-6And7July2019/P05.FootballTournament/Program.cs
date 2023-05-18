using System;

namespace P05.FootballTournament
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string teamName = Console.ReadLine();
            int countGames = int.Parse(Console.ReadLine());
            int points = 0;
            int countW = 0;
            int countD = 0;
            int countL = 0;

            for (int i = 1; i <= countGames; i++)
            {
                char result = char.Parse(Console.ReadLine());

                if (result == 'W')
                {
                    points += 3;
                    countW++;
                }
                else if (result == 'D')
                {
                    points++;
                    countD++;
                }
                else
                {
                    countL++;
                }
            }

            if (countGames == 0)
            {
                Console.WriteLine($"{teamName} hasn't played any games during this season.");
            }
            else
            {
                Console.WriteLine($"{teamName} has won {points} points during this season.");
                Console.WriteLine($"Total stats:");
                Console.WriteLine($"## W: {countW}");
                Console.WriteLine($"## D: {countD}" );
                Console.WriteLine($"## L: {countL}" );
                Console.WriteLine($"Win rate: {(double)countW /countGames*100:f2}%");
            }
        }
    }
}
