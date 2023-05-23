using System.Drawing;

namespace P01.RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string rock = "Rock";
            string paper = "Paper";
            string scissors = "Scissors";
            bool newGame = true;


            while (newGame)
            {
                int countInavalidInput = 1;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("Choose [r]ock, [p]aper or [s]cissors: ");
                string playerMove = Console.ReadLine();

                while (playerMove != "rock" && playerMove != "r" && playerMove != "paper" && playerMove != "p" && playerMove != "scissors" && playerMove != "s")
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid input. Try Again...");
                    Console.Write("Choose [r]ock, [p]aper or [s]cissors: ");
                    playerMove = Console.ReadLine();

                    if (playerMove != "rock" && playerMove != "r" && playerMove != "paper" && playerMove != "p" && playerMove != "scissors" && playerMove != "s")
                    {
                        countInavalidInput++;
                    }

                    if (countInavalidInput == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine($"You have entered an invalid input {countInavalidInput} times.");
                        Console.WriteLine("Do you want to quit game?");
                        Console.Write("Type [yes] or [no]: ");
                        string decision = Console.ReadLine();

                        if (decision == "yes")
                        {
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("Thank you for playing!");
                            return;
                        }
                        else if (decision == "no")
                        {
                            countInavalidInput = 0;
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.Write("Choose [r]ock, [p]aper or [s]cissors: ");
                            playerMove = Console.ReadLine();
                            continue;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine($"You have entered an invalid input too many times.");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write($"Game Over!");
                            return;
                        }
                    }
                }

                if (playerMove == "r" || playerMove == "rock")
                {
                    playerMove = rock;
                }
                else if (playerMove == "p" || playerMove == "paper")
                {
                    playerMove = paper;
                }
                else if (playerMove == "s" || playerMove == "scissors")
                {
                    playerMove = scissors;
                }

                Random random = new Random();
                int computerRandomNumber = random.Next(1, 4);
                string computerMove = "";

                switch (computerRandomNumber)
                {
                    case 1:
                        computerMove = rock;
                        break;
                    case 2:
                        computerMove = paper;
                        break;
                    case 3:
                        computerMove = scissors;
                        break;
                }

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"The computer chose {computerMove}.");
                Console.ForegroundColor = ConsoleColor.Green;

                if ((playerMove == rock && computerMove == scissors) ||
                    (playerMove == paper && computerMove == rock) ||
                    (playerMove == scissors && computerMove == paper))
                {
                    Console.WriteLine("You win.");
                }
                else if ((playerMove == rock && computerMove == paper) ||
                         (playerMove == paper && computerMove == scissors) ||
                         (playerMove == scissors && computerMove == rock))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You lose.");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("This game was a draw.");
                }

                countInavalidInput = 1;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Type [yes] to Play Again or [no] to quit: ");
                string playAgain = Console.ReadLine();

                if (playAgain == "yes")
                {
                    newGame = true;
                }
                else if (playAgain == "no")
                {
                    newGame = false;
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Thank you for playing!");
                }

                while (playAgain != "yes" && playAgain != "no")
                {

                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid input. Try Again...");
                    Console.Write("Type [yes] to Play Again or [no] to quit: ");
                    playAgain = Console.ReadLine();

                    if (playAgain != "yes" && playAgain != "no")
                    {
                        countInavalidInput++;
                    }
                    
                    if (countInavalidInput == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine($"You have entered an invalid input {countInavalidInput} times.");
                        Console.WriteLine("Do you want to quit game?");
                        Console.Write("Type [yes] or [no]: ");
                        string decision = Console.ReadLine();

                        if (decision == "yes")
                        {
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("Thank you for playing!");
                            return;
                        }
                        else if (decision == "no")
                        {
                            countInavalidInput = 0;
                            playerMove = "yes";
                            continue;
                        }
                    }
                    else if (countInavalidInput > 3)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"You have entered an invalid input too many times.");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($"Game Over!");
                        return;
                    }

                    if (playAgain == "yes")
                    {
                        newGame = true;
                    }
                    else if (playAgain == "no")
                    {
                        newGame = false;
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Thank you for playing!");
                    }

                }
            }

        }
    }
}
