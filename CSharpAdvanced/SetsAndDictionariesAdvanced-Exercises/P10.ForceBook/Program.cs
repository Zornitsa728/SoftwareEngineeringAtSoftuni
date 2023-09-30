namespace P10.ForceBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, SortedSet<string>> forceSide = new Dictionary<string, SortedSet<string>>();
            List<string> sides = new List<string>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Lumpawaroo")
            {
                string[] tokens = input
                    .Split(new string[] { " | ", " -> " }, StringSplitOptions.RemoveEmptyEntries);


                if (input.Contains("|"))
                {
                    string side = tokens[0];
                    string user = tokens[1];

                    if (!forceSide.Values.Any(x => x.Contains(user)))
                    {
                        if (!forceSide.ContainsKey(side))
                        {
                            sides.Add(side);
                            forceSide.Add(side, new SortedSet<string>());
                        }

                        forceSide[side].Add(user);
                    }
                }
                else if (input.Contains("->"))
                {
                    string user = tokens[0];
                    string side = tokens[1];

                    if (!forceSide.ContainsKey(side))
                    {
                        sides.Add(side);
                        forceSide.Add(side, new SortedSet<string>());
                    }

                    if (forceSide.Values.Any(x => x.Contains(user)))
                    {
                        forceSide.Values.First(x => x.Contains(user)).Remove(user);
                        forceSide[side].Add(user);
                    }
                    else
                    {
                        forceSide[side].Add(user);
                    }

                    Console.WriteLine($"{user} joins the {side} side!");
                }
            }

            forceSide = forceSide.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var side in forceSide)
            {
                if (side.Value.Count == 0)
                {
                    continue;
                }

                Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");

                foreach (var users in side.Value)
                {
                    Console.WriteLine($"! {users}");
                }
            }
        }
    }
}