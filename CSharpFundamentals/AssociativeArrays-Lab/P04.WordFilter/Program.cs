namespace P04.WordFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split()
                .ToArray();

            foreach (string word in words.Where(w => w.Length % 2 == 0))
            {
                Console.WriteLine(word);
            }
        }
    }
}