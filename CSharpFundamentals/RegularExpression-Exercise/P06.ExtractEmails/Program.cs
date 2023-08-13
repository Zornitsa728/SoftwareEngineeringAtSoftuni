using System.Text.RegularExpressions;

namespace P06.ExtractEmails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split(" ");
            string patern = @"^[^\W_]+[_\.\-]*[^\W_]+\@(?:[a-zA-Z\-]+\.)+[a-zA-Z]+";
            Regex regex = new Regex(patern);

            foreach (string currText in text)
            {
                MatchCollection matches = regex.Matches(currText);

                if (matches.Count > 0)
                {
                    foreach (Match match in matches)
                    {
                        Console.WriteLine(match.Value);
                    }
                }
                
            }
            
        }
    }
}