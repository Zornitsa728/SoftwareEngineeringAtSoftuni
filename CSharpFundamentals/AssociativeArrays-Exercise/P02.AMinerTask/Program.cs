using System.Numerics;

namespace P02.AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, BigInteger> resources = new Dictionary<string, BigInteger>();
            string input;

            while ((input = Console.ReadLine()) != "stop")
            {
                BigInteger quantity = BigInteger.Parse(Console.ReadLine());

                if (resources.ContainsKey(input))
                {
                    resources[input] += quantity;
                    continue;
                }

                resources.Add(input, quantity);
            }

            foreach (var kvp in resources)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}