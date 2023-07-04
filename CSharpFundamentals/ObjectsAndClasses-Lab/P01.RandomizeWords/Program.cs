namespace P01.RandomizeWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split();
            Random random = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                string currWord = words[i];
                int randomIndex = random.Next(0, words.Length);
                string randomWord = words[randomIndex];

                words[i] = randomWord;
                words[randomIndex] = currWord;
            }

            Console.WriteLine(string.Join("\n", words));
        }
    }
}