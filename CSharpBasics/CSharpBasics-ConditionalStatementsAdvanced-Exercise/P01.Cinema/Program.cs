using System;

namespace P01.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ticket = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());
            int seats = row * column;
            double totalSum =0;
            if(ticket == "Premiere")
            {
                totalSum = seats * 12.00;
            }
            else if(ticket == "Normal")
            {
                totalSum = seats * 7.50;
            }
            else if(ticket == "Discount")
            {
                totalSum = seats * 5.00;

            }

            Console.WriteLine($"{totalSum:f2}");
            
        }
    }
}
