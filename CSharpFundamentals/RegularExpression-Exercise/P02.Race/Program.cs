using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P02.Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> participants = Console.ReadLine()
                .Split(", ")
                .ToList();
            Dictionary<string, int> results = new Dictionary<string, int>();
            foreach (string participant in participants)
            {
                results.Add(participant, 0);
            }

            string input;
            string patern = @"[^\W_]";

            while ((input = Console.ReadLine()) != "end of race")
            {
                MatchCollection matches = Regex.Matches(input, patern);
                string name = "";
                int km = 0;

                if (matches != null)
                {
                    foreach (Match match in matches)
                    {
                        string symbol = match.Value;

                        if (char.IsLetter(char.Parse(symbol)))
                        {
                            name += symbol;
                        }
                        else
                        {
                            km += int.Parse(symbol);
                        }
                    }
                }

                if (participants.Contains(name))
                {
                    results[name] += km;
                }
            }

            int count = 0;
            List<string> bestResults = new List<string>();
            foreach (var kvp in results.OrderByDescending(x => x.Value))
            {
                count++;
                bestResults.Add(kvp.Key);

                if (count == 3)
                {
                    break;
                }
            }

            Console.WriteLine($"1st place: {bestResults[0]}");
            Console.WriteLine($"2nd place: {bestResults[1]}");
            Console.WriteLine($"3rd place: {bestResults[2]}");
        }
    }
}