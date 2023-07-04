using System.Collections.Generic;

namespace P01.CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            SortedDictionary <double,int> counts = new SortedDictionary<double,int>();

            foreach (double number in numbers)
            {
                if (!counts.ContainsKey(number))
                {
                    counts.Add(number, 1);
                    continue;
                }
                counts[number]++;
            }

            foreach (var kvp in counts)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}