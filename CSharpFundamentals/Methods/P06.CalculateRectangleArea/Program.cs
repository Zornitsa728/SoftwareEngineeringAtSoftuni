using System.Runtime.Serialization;

namespace P06.CalculateRectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine(CalculatesRectangleArea(length, width));
        }

        static double CalculatesRectangleArea(double length, double width)
        {
            double rectangleArea = length * width;
            return rectangleArea;
        }
    }
}