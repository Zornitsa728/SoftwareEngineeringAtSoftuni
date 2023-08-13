using System.Text.RegularExpressions;

namespace P04.StarEnigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> text = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                int sum = 0;

                for (int currEl = 0; currEl < input.Length; currEl++)
                {
                    char currChar = char.Parse(input[currEl].ToString().ToLower());
                    if (currChar == 's' || currChar == 't' || currChar == 'a' || currChar == 'r')
                    {
                        sum++;
                    }
                }

                string newText = string.Empty;
                for (int currIndex = 0; currIndex < input.Length; currIndex++)
                {
                    newText += (char)(input[currIndex] - sum);
                }
                
                text.Add(newText);
            }

            string patern = @"^[^\@\-\!\:\>]*?\@(?<name>[A-za-z]+)[^\@\-\!\:\>]*?\:[^\@\-\!\:\>]*?(?<population>\d+)[^\@\-\!\:\>]*?\![^\@\-\!\:\>]*?(?<attack>[A|D])[^\@\-\!\:\>]*?\![^\@\-\!\:\>]*?\-\>[^\@\-\!\:\>]*?(?<soldierCount>\d+)[^\@\-\!\:\>]*?";
            Regex regex = new Regex(patern);
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            foreach (string currText in text)
            {
                Match match = regex.Match(currText);

                if (match.Success)
                {
                    if (match.Groups["attack"].Value == "A")
                    {
                        attackedPlanets.Add(match.Groups["name"].Value);
                    }
                    else if (match.Groups["attack"].Value == "D")
                    {
                        destroyedPlanets.Add(match.Groups["name"].Value);
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (string planetName in attackedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planetName}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (var planetName in destroyedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planetName}");
            }
        }
    }
}