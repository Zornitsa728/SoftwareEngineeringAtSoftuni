using System;

namespace P04.Renovation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int high = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            double percentNotPainting = double.Parse(Console.ReadLine())/100;
            string input;
            int wholeRoom = (high * width) * 4;
            double roomForPainting = Math.Ceiling(wholeRoom - (wholeRoom * percentNotPainting));

            while ((input = Console.ReadLine()) != "Tired!")
            {
                int literPaint = int.Parse(input);
                roomForPainting -= literPaint;

                if (roomForPainting <= 0)
                {
                    break;
                }

            }

            if (input == "Tired!")
            {
                Console.WriteLine($"{roomForPainting} quadratic m left.");
            }
            else if (roomForPainting < 0)
            {
                Console.WriteLine($"All walls are painted and you have {Math.Abs(roomForPainting)} l paint left!");
            }
            else
            {
                Console.WriteLine($"All walls are painted! Great job, Pesho!");
            }
        }
    }
}
