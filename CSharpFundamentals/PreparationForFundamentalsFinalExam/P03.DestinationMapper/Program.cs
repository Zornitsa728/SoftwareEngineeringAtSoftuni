using System.Text.RegularExpressions;

namespace P03.DestinationMapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(\=|\/)(?<name>[A-Z][a-zA-Z]{2,})\1";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            int sumLength = 0;
            List<string> destinations = new List<string>();

            foreach (Match match in matches)
            {
                string currMatch = match.Groups["name"].Value;
                sumLength += currMatch.Length;
                destinations.Add(currMatch);
            }

            Console.WriteLine($"Destinations: {string.Join(", ", destinations)}");
            Console.WriteLine($"Travel Points: {sumLength}");
        }
    }
}