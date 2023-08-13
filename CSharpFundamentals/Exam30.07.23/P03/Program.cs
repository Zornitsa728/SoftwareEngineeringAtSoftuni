using System.Xml.Linq;

namespace P03_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Dictionary<string, List<string>> heroes = new Dictionary<string, List<string>>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] cmd = input
                    .Split(" ");
                string operation = cmd[0];
                string heroName = cmd[1];

                if (operation == "Enroll")
                {
                    if (!heroes.ContainsKey(heroName))
                    {
                        heroes[heroName] = new List<string>();
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} is already enrolled.");
                    }
                }
                else if (operation == "Learn")
                {
                    string spellName = cmd[2];
                    
                    if (!heroes.ContainsKey(heroName))
                    {
                        Console.WriteLine($"{heroName} doesn't exist.");
                    }
                    else 
                    {
                        if (heroes[heroName].Contains(spellName))
                        {
                            Console.WriteLine($"{heroName} has already learnt {spellName}.");
                        }
                        else
                        {
                            heroes[heroName].Add(spellName);
                        }
                    }
                }
                else if (operation == "Unlearn")
                {
                    string spellName = cmd[2];

                    if (!heroes.ContainsKey(heroName))
                    {
                        Console.WriteLine($"{heroName} doesn't exist.");
                    }
                    else
                    {
                        if (heroes[heroName].Contains(spellName))
                        {
                            heroes[heroName].Remove(spellName);
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} doesn't know {spellName}.");
                        }
                    }
                }

            }

            if (heroes.Count > 0)
            {
                Console.WriteLine("Heroes:");
            }

            foreach (var hero in heroes)
            {
                Console.Write($"== {hero.Key}: ");
                Console.WriteLine(string.Join(", ", hero.Value));
            }
        }
    }
}