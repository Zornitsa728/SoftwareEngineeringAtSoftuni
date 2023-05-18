using System;

namespace P07.Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int wholeRoom = width * length * height;
            string input;
            
            while ((input = Console.ReadLine()) != "Done")
            {
                int cartonBox = int.Parse(input);
                wholeRoom -= cartonBox;

                if (wholeRoom <= 0)
                {
                    break;
                }
            }

            if (input == "Done")
            {
                Console.WriteLine($"{wholeRoom} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(wholeRoom)} Cubic meters more.");
            }
        }
    }
}
