using System.Text;
using System.Text.RegularExpressions;

namespace P02_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"^(\$|\%)(?<tag>[A-Z][a-z]{2,})\1\: \[(?<firstNum>\d+)\]\|\[(?<secondNum>\d+)\]\|\[(?<thirdNum>\d+)\]\|$";
            Regex regex = new Regex(pattern);

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = regex.Match(input);
                if (match.Success)
                {
                    string decryptedMessage = string.Empty;
                    decryptedMessage += (char)(int.Parse(match.Groups["firstNum"].Value));
                    decryptedMessage += (char)(int.Parse(match.Groups["secondNum"].Value));
                    decryptedMessage += (char)(int.Parse(match.Groups["thirdNum"].Value));
                    Console.WriteLine($"{match.Groups["tag"].Value}: {decryptedMessage}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}