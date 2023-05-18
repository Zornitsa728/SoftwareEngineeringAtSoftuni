using System;

namespace П04.GameNumberWars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string player1 = Console.ReadLine();
            string player2 = Console.ReadLine();
            string input;
            int pointsPlayer1 = 0;
            int pointsPlayer2 = 0;

            while ((input=Console.ReadLine()) != "End of game")
            {
                int cardPlayer1 = int.Parse(input);
                int cardPlayer2 = int.Parse(Console.ReadLine());

                if (cardPlayer1 > cardPlayer2)
                {
                    pointsPlayer1 += cardPlayer1 - cardPlayer2;
                }
                else if (cardPlayer2 > cardPlayer1)
                {
                    pointsPlayer2 += cardPlayer2 - cardPlayer1;
                }
                else if (cardPlayer1 == cardPlayer2)
                {
                    cardPlayer1 = int.Parse(Console.ReadLine());
                    cardPlayer2 = int.Parse(Console.ReadLine());

                    if (cardPlayer1 > cardPlayer2)
                    {
                        Console.WriteLine("Number wars!");
                        Console.WriteLine($"{player1} is winner with {pointsPlayer1} points");
                    }
                    else
                    {
                        Console.WriteLine("Number wars!");
                        Console.WriteLine($"{player2} is winner with {pointsPlayer2} points");
                    }
                    break;
                }
            }

            if (input == "End of game")
            {
                Console.WriteLine($"{player1} has {pointsPlayer1} points");
                Console.WriteLine($"{player2} has {pointsPlayer2} points");
            }

        }
    }
}
