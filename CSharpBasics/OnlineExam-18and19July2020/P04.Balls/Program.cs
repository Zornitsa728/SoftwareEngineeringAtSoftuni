using System;
using System.ComponentModel;

namespace P04.Balls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //От конзолата се чете 1 цяло число N, което е броят на топките в диапазон (0-1000)
            int numberOfBalls = int.Parse(Console.ReadLine());
            //След това се четат N на брой цветове.
            double points = 0;
            int red = 0;
            int orange = 0;
            int yellow = 0;
            int white = 0;
            int black = 0;
            int otherColours = 0;
            for (int i = 0; i < numberOfBalls; i++)
            {
                string colour = Console.ReadLine();
                if (colour == "red")
                {
                    red++;
                    points += 5; //Ако топката е “red” точките ни се повишават с 5.
                }
                else if (colour == "orange") 
                {
                    orange++;
                    points += 10; //Ако топката е “orange” точките ни се повишават с 10.
                }
                else if (colour == "yellow")
                {
                    yellow++;
                    points += 15; //Ако топката е “yellow” точките ни се повишават с 15.
                }
                else if (colour == "white")
                {
                    white++;
                    points += 20; //Ако топката е “white” точките ни се повишават с 20.
                }
                else if (colour == "black")
                {
                    black++;
                    points = Math.Floor(points / 2); //Ако топката е “black” точките ни се делят на 2, като закръгляме към по-малкото цяло число.
                }
                else
                {
                    otherColours++; //Ако топката е с какъвто и да е цвят, различен от по-горните, точките не се манипулират 
                }
            }
            Console.WriteLine($"Total points: {points}");
            Console.WriteLine($"Red balls: {red}");
            Console.WriteLine($"Orange balls: {orange}");
            Console.WriteLine($"Yellow balls: {yellow}");
            Console.WriteLine($"White balls: {white}");
            Console.WriteLine($"Other colors picked: {otherColours}");
            Console.WriteLine($"Divides from black balls: {black}");

        }
    }
}
