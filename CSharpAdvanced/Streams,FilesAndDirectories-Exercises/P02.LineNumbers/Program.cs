namespace LineNumbers
{
    using System;
    using System.Diagnostics.Metrics;

    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            string[] text = File.ReadLines(inputFilePath).ToArray();
            
            for (int line = 0; line < text.Length; line++)
            {
                int countLetters = text[line].Count(char.IsLetter);
                int countPunctMarks = text[line].Count(char.IsPunctuation); ;

                text[line] = ($"Line {line+1}: {text[line]} ({countLetters}) ({countPunctMarks})");
            }
            
            File.WriteAllLines(outputFilePath, text);
        }
    }
}
