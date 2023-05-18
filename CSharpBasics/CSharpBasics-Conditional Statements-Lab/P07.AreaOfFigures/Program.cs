using System;

namespace P07.AreaOfFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string figure = Console.ReadLine();
            double area = 0;
            if (figure == "square")
            {
                double h = double.Parse(Console.ReadLine());
                area = h * h;
                Console.WriteLine($"{area:F3}");
            }
            else if (figure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                area = a * b;
                Console.WriteLine($"{area:F3}");
            }
            else if (figure == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                area = Math.PI * r * r;
                Console.WriteLine($"{area:F3}");
            }
            else if(figure == "triangle")
            {
                double b = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                area = h * b / 2;
                Console.WriteLine($"{area:F3}");
            }


        }
    }
}
