using System;
using System.Text.RegularExpressions;

namespace P02.MirrorWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"([\@|\#])(?<firstWord>[a-zA-Za-z]{3,})\1\1(?<secondWord>[a-zA-Za-z]{3,})\1";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);

            if (matches.Count != 0)
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
                Dictionary<string, string> mirrorWords = new Dictionary<string, string>();

                foreach (Match match in matches)
                {
                    string firstWord = match.Groups["firstWord"].Value;
                    string secondWord = match.Groups["secondWord"].Value;
                    string reversedSecondWord = string.Empty;

                    for (int i = secondWord.Length - 1; i >= 0; i--)
                    {
                        reversedSecondWord += secondWord[i];
                    }

                    if (firstWord == reversedSecondWord)
                    {
                        mirrorWords[firstWord] = secondWord;
                    }
                }

                if (mirrorWords.Count != 0)
                {
                    Console.WriteLine("The mirror words are:");
                    int counter = 0;

                    foreach (var words in mirrorWords)
                    {
                        if (counter + 1 == mirrorWords.Count)
                        {
                            Console.Write($"{words.Key} <=> {words.Value}");
                            break;
                        }

                        counter++;
                        Console.Write($"{words.Key} <=> {words.Value}, ");
                    }
                }
                else
                {
                    Console.WriteLine("No mirror words!");
                }
            }
            else
            {
                Console.WriteLine("No word pairs found!");
                Console.WriteLine("No mirror words!");
            }
        }
    }
}