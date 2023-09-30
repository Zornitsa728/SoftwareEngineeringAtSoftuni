namespace P08.Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contestAndPassword = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> internsResult = new Dictionary<string, Dictionary<string, int>>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end of contests")
            {
                string[] tokens = input
                    .Split(":", StringSplitOptions.RemoveEmptyEntries);
                string contest = tokens[0];
                string password = tokens[1];

                if (!contestAndPassword.ContainsKey(contest))
                {
                    contestAndPassword.Add(contest, password);
                }
            }

            while ((input = Console.ReadLine()) != "end of submissions")
            {
                string[] tokens = input
                    .Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string contest = tokens[0];
                string password = tokens[1];
                string username = tokens[2];
                int points = int.Parse(tokens[3]);

                if (contestAndPassword.ContainsKey(contest))
                {
                    if (contestAndPassword[contest].Contains(password))
                    {
                        if (!internsResult.ContainsKey(username))
                        {
                            internsResult.Add(username, new Dictionary<string, int>());
                            internsResult[username].Add(contest, points);
                        }
                        else
                        {
                            if (internsResult[username].ContainsKey(contest))
                            {
                                if (internsResult[username][contest] < points)
                                {
                                    internsResult[username][contest] = points;
                                }
                            }
                            else
                            {
                                internsResult[username].Add(contest, points);
                            }
                            
                        }
                    }
                }

            }

            

            string bestUser = string.Empty;
            int maxValue = int.MinValue;
            int counter = 0;

            foreach (var user in internsResult)
            {
                int sum = 0;
                
                foreach (var result in user.Value)
                {
                   sum += result.Value;
                }

                if (sum > maxValue)
                {
                    bestUser = user.Key;
                    maxValue = sum;
                }
            }

            Console.WriteLine($"Best candidate is {bestUser} with total {maxValue} points.");
            Console.WriteLine("Ranking:");

            foreach (var user in internsResult.OrderBy(x => x.Key))
            {
                Console.WriteLine(user.Key);

                foreach (var result in user.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {result.Key} -> {result.Value}");
                }
            }
        }
    }
}