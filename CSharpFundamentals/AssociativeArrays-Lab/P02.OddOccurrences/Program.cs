namespace P02.OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split()
                .Select(x => x.ToLower())
                .ToArray();

            Dictionary <string, int> counts = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (!counts.ContainsKey(word))
                {
                    counts.Add(word, 1);
                    continue;
                }
                counts[word]++;
            }

            foreach (var cvp in counts)
            {
                if (cvp.Value % 2 != 0)
                {
                    Console.Write($"{cvp.Key} ");
                }
            }
        }
    }
}