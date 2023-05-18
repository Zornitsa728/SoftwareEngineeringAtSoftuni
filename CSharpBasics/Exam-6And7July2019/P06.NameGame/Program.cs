using System;

namespace P06.NameGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string playerName;
            int maxPoints = int.MinValue;
            string winner = "";
            
            while ((playerName=Console.ReadLine()) != "Stop")
            {
                int points = 0;

                for (int i = 0; i < playerName.Length; i++)
                {
                    int num = int.Parse(Console.ReadLine());

                    for (int l = playerName[i]; l <= playerName[i]; l++)
                    {
                        if (playerName[i] == num)
                        {
                            points += 10;
                        }
                        else
                        {
                            points += 2;
                        }
                    }
                }

                if (points >= maxPoints)
                {
                    winner = playerName;
                    maxPoints = points;
                }
            }

            Console.WriteLine($"The winner is {winner} with {maxPoints} points!");
        }
    }
}
