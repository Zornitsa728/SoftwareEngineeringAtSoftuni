using System;

namespace P05_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            double budget;
            double savings;
            double savingsSum = 0;

            while (destination != "End")
            {
                budget = double.Parse(Console.ReadLine());

                while (savingsSum < budget)
                {
                    savings = double.Parse(Console.ReadLine());
                    savingsSum += savings;
                   
                }

                if (savingsSum >= budget)
                {
                    Console.WriteLine($"Going to {destination}!");
                    savingsSum = 0;
                }

                destination= Console.ReadLine();
            }
        }
    }
}
