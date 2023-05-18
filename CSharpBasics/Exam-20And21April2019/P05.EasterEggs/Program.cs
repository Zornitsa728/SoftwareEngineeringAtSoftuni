using System;

namespace P05.EasterEggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int paintedEggs = int.Parse(Console.ReadLine());
            string eggColor; //• червено (red) • оранжев (orange) • син (blue) • зелен (green)
            int red = 0;
            int orange = 0;
            int blue = 0;
            int green = 0;
            int maxNum = 0;
            string maxColor = string.Empty;

            while (paintedEggs != 0)
            {
                eggColor = Console.ReadLine();

                if (eggColor == "red")
                {
                    red++;
                }
                else if (eggColor == "orange")
                {
                    orange++;
                }
                else if (eggColor == "blue")
                {
                    blue++;
                }
                else
                {
                    green++;
                }

                paintedEggs--;
            }

            if (red > orange && red > blue && red > green)
            {
                maxNum = red;
                maxColor = "red";
            }
            else if (blue > red && blue > orange && blue > green)
            {
                maxNum = blue;
                maxColor = "blue";
            }
            else if (orange > red && orange > blue && orange > green)
            {
                maxNum = orange;
                maxColor = "orange";
            }
            else
            {
                maxNum = green;
                maxColor = "green";
            }

            Console.WriteLine($"Red eggs: {red}");
            Console.WriteLine($"Orange eggs: {orange}");
            Console.WriteLine($"Blue eggs: {blue}");
            Console.WriteLine($"Green eggs: {green}");
            Console.WriteLine($"Max eggs: {maxNum} -> {maxColor}");

        }
    }
}
