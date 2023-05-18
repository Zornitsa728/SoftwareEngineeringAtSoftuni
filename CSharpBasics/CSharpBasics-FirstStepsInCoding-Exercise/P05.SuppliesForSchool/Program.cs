using System;

namespace P05.SuppliesForSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double pen = double.Parse(Console.ReadLine())*5.80;
            double marker = double.Parse(Console.ReadLine())*7.20; 
            double detergent = double.Parse(Console.ReadLine())* 1.20;
            double discount = double.Parse(Console.ReadLine())/100;
            double sum = (pen + marker + detergent);
            Console.WriteLine(sum-(sum*discount));


        }
    }
}
