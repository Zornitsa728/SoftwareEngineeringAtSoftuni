using System.Numerics;
using System.Text.RegularExpressions;

namespace P09.EmojiDetector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            BigInteger coolThresholdSum = 1;
            string digitPattern = @"(?<number>\d)";
            MatchCollection digits = Regex.Matches(input, digitPattern);

            foreach (var digit in digits)
            {
                coolThresholdSum *= int.Parse(digit.ToString());
            }

            Console.WriteLine($"Cool threshold: {coolThresholdSum}");

            string patternEmoji = @"(\:{2}|\*{2})([A-Z][a-z]{2,})\1";
            Regex regex = new Regex(patternEmoji);
            MatchCollection matches = regex.Matches(input);

            Console.WriteLine($"{matches.Count} emojis found in the text. The cool ones are:");
            if (matches.Count > 0 )
            {
                foreach (Match match in matches)
                {
                    int asciiSum = 0;
                    for (int i = 0; i < match.Value.Length; i++)
                    {
                        if (char.IsLetter(match.Value[i]))
                        {
                            asciiSum += match.Value[i];
                        }
                    }

                    if (coolThresholdSum <= asciiSum)
                    {
                        Console.WriteLine(match.Value);
                    }
                }
            }


        }
    }
}