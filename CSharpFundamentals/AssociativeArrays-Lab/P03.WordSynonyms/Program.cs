namespace P03.WordSynonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary< string, List<string>> words = new Dictionary< string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonim = Console.ReadLine();

                if (words.ContainsKey(word))
                {
                    words[word].Add(synonim);
                }
                else
                {
                    words.Add(word, new List<string>());
                    words[word].Add(synonim);
                }
            }

            foreach (var kvp in words)
            {
                Console.WriteLine($"{kvp.Key} - {string.Join(", ", kvp.Value)}");
            }
        }
    }
}