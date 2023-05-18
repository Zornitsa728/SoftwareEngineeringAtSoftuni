using System;

namespace P02.FootballResults
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string result1 = Console.ReadLine(); 
            string result2 = Console.ReadLine();
            string result3 = Console.ReadLine();
            int won = 0;
            int lost = 0;
            int drawnGames = 0;

            if (result1[0] > result1[2])
            {
                won++;
            }
            else if (result1[0] < result1[2])
            {
                lost++;
            }
            else if (result1[0] == result1[2])
            {
                drawnGames++;
            }

            if (result2[0] > result2[2])
            {
                won++;
            }
            else if (result2[0] < result2[2])
            {
                lost++;
            }
            else if (result2[0] == result2[2])
            {
                drawnGames++;
            }


            if (result3[0] > result3[2])
            {
                won++;
            }
            else if (result3[0] < result3[2])
            {
                lost++;
            }
            else if (result3[0] == result3[2])
            {
                drawnGames++;
            }

            Console.WriteLine($"Team won {won} games.");
            Console.WriteLine($"Team lost {lost} games.");
            Console.WriteLine($"Drawn games: {drawnGames}");
        }
    }
}
