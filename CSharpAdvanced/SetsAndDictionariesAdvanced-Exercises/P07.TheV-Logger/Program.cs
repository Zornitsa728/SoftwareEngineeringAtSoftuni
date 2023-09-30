using System.Collections.Generic;

namespace P07.TheV_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, HashSet<string>>> vloggers = new Dictionary<string, Dictionary<string, HashSet<string>>>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Statistics")
            {
                string[] tokens = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string vloggername = tokens[0];
                string cmd = tokens[1];

                if (cmd == "joined")
                {
                    if (!vloggers.ContainsKey(vloggername))
                    {
                        vloggers.Add(vloggername, new Dictionary<string, HashSet<string>>());
                        vloggers[vloggername].Add("followers", new HashSet<string>());
                        vloggers[vloggername].Add("following", new HashSet<string>());
                    }
                }
                else if (cmd == "followed")
                {
                    string secondVlogger = tokens[2];

                    if (vloggers.ContainsKey(vloggername) && vloggers.ContainsKey(secondVlogger) && vloggername != secondVlogger)
                    {  
                        vloggers[secondVlogger]["followers"].Add(vloggername);
                        vloggers[vloggername]["following"].Add(secondVlogger);
                    }
                }
            }

            vloggers = vloggers
                .OrderByDescending(v => v.Value["followers"].Count)
                .ThenBy(v => v.Value["following"].Count)
                .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");
            int count = 1;
            foreach (var vlogger in vloggers)
            {
                Console.WriteLine($"{count}. {vlogger.Key} : {vlogger.Value["followers"].Count} followers, {vlogger.Value["following"].Count} following");

                if (count == 1)
                {
                    foreach (var follower in vlogger.Value["followers"].OrderBy(x => x))
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }

                count++;
            }
        }
    }
}