using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace P05.NetherRealms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split(",",StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .OrderBy(x => x)
                .ToArray();

            string paternForNums = @"(?<numbers>[\+\-]?(?:\d+(?:\.?\d+)?))";
            string paternForCharacters = @"(?<characters>[^0-9\+\-\*\/\.])";

            foreach (string name in names)
            {
                int health = 0;
                double damage = 0;
                List<char> symbols = new List<char>();

                MatchCollection characters = Regex.Matches(name, paternForCharacters);
                foreach (Match currChar in characters)
                {
                    health += char.Parse(currChar.Value);
                }

                for (int i = 0; i < name.Length; i++)
                {
                   if (name[i] == '*' || name[i] == '/') 
                    {
                        symbols.Add(name[i]);
                    }
                }

                MatchCollection numbers = Regex.Matches(name,paternForNums);
                if (numbers.Count != 0)
                {
                    foreach (Match number in numbers)
                    {
                        damage += double.Parse(number.Value);
                    }

                    foreach (char currEl in symbols)
                    {
                        if (currEl == '*')
                        {
                            damage *= 2;
                        }
                        else
                        {
                            damage /= 2;
                        }
                    }
                }

                Console.WriteLine($"{name} - {health} health, {damage:f2} damage");
            }

        }
    }
}