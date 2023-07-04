namespace P01.CountChairsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split();
            Dictionary<char, int> counts = new Dictionary<char, int>();

            foreach (string word in words)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (counts.ContainsKey(word[i]))
                    {
                        counts[word[i]]++;
                        continue;
                    }

                    counts.Add(word[i], 1);
                }
            }

            foreach (var kvp in counts)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}