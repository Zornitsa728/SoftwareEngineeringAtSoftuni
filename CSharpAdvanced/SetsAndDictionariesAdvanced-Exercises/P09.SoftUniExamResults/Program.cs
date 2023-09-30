namespace P09.SoftUniExamResults
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> examResults = new Dictionary<string, int>(); // saving username and points 
            Dictionary<string, int> languages = new Dictionary<string, int>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "exam finished")
            {
                string[] tokens = input
                    .Split("-", StringSplitOptions.RemoveEmptyEntries);
                string username = tokens[0];

                if (tokens[1] == "banned" && examResults.ContainsKey(username))
                {
                    examResults.Remove(username);
                }
                else
                {
                    string language = tokens[1];
                    int points = int.Parse(tokens[2]);

                    if (!examResults.ContainsKey(username))
                    {
                        examResults.Add(username, points);
                    }
                    else
                    {
                        if (examResults[username] < points)
                        {
                            examResults[username] = points;
                        }
                    }

                    if (!languages.ContainsKey(language))
                    {
                        languages.Add(language, 0);
                    }

                    languages[language]++;
                }
            }

            examResults = examResults.OrderByDescending(x => x.Value).ThenBy(y => y.Key).ToDictionary(x => x.Key, x => x.Value);
            Console.WriteLine("Results:");

            foreach (var user in examResults)
            {
                Console.WriteLine($"{user.Key} | {user.Value}");
            }

            languages = languages.OrderByDescending(x => x.Value).ThenBy(y => y.Key).ToDictionary(x => x.Key, x => x.Value);
            Console.WriteLine("Submissions:");

            foreach (var language in languages)
            {
                Console.WriteLine($"{language.Key} - {language.Value}");
            }
        }
    }
}