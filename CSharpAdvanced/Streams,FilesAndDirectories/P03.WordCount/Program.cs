namespace WordCount
{
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            Dictionary<string, int> wordCount = new Dictionary<string, int>();
            string line = "";

            using (StreamReader words = new StreamReader(wordsFilePath))
            {
                while ((line = words.ReadLine()) != null)
                {
                    string[] separatedWords = line.Split(' ');

                    for (int i = 0; i < separatedWords.Length; i++)
                    {
                        if (!wordCount.ContainsKey(separatedWords[i]))
                        {
                            wordCount.Add(separatedWords[i], 0);
                        }

                        wordCount[separatedWords[i]]++;
                    }
                }

            }

            using (StreamReader text = new StreamReader(textFilePath))
            {
                while ((line = text.ReadLine()) != null)
                {
                    string[] separatedWords = line
                        .Split(' ')
                        .Select(x => x.ToLower())
                        .ToArray();

                    for (int i = 0; i < separatedWords.Length; i++)
                    {
                        if (wordCount.ContainsKey(separatedWords[i]))
                        {
                            wordCount[separatedWords[i]]++;
                        }
                    }
                }
            }

            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                foreach (var word in wordCount.OrderByDescending(x => x.Value))
                {
                    writer.WriteLine($"{word.Key} - {word.Value}");
                }
            }
        }
    }
}
