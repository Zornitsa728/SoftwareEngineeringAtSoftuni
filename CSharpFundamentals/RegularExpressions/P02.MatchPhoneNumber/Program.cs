using System.Text.RegularExpressions;

namespace P02.MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phones = Console.ReadLine();

            string patern = @"\+359( |-)2\1\d{3}\1\d{4}\b";

            MatchCollection numberMatches = Regex.Matches(phones, patern);

            var machedPhones = numberMatches
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToList();

            Console.WriteLine(string.Join(", ", machedPhones));

            //foreach (Match currNumber in numberMatches)
            //{
            //    Console.WriteLine(currNumber.Value + ", ");
            //}
            

        }
    }
}