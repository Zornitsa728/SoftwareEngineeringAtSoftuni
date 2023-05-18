using System;

namespace P06.TheMostPowerfulWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word;
            int maxPowerWord = int.MinValue;
            string winWord = string.Empty;

            while ((word=Console.ReadLine()) != "End of words")
            {
                double sum = 0;

                for (int i = 0; i < word.Length; i++)
                {
                    for (int l = word[i]; l == word[i]; l++)
                    {
                        sum += l;
                    }
                }

                if (word[0] == 'A' || word[0] == 'E' || word[0] == 'I' || word[0] == 'O' || word[0] == 'U' || word[0] == 'Y')
                {
                    sum *= word.Length;
                }
                else if (word[0] == 'a' || word[0] == 'e' || word[0] == 'i' || word[0] == 'o' || word[0] == 'u' || word[0] == 'y')
                {
                    sum *= word.Length;
                }
                else
                {
                    sum = Math.Floor(sum/word.Length);
                }

                if (sum > maxPowerWord)
                {
                    winWord = word;
                    maxPowerWord = (int)sum;
                }
            }

            Console.WriteLine($"The most powerful word is {winWord} - {maxPowerWord}");
        }
    }
}
