using System;

namespace P02.TriangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sideOfTriangle = double.Parse(Console.ReadLine());
            double hightOfTriangle = double.Parse(Console.ReadLine());
            double area = sideOfTriangle * hightOfTriangle / 2;
            Console.WriteLine($"{area:f2}");
        }
    }
}
