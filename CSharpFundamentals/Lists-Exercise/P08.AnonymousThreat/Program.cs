using Microsoft.VisualBasic;
using System.Collections.Concurrent;
using System.ComponentModel.Design;
using System.Text;

namespace P08.AnonymousThreat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine()
                  .Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string input;
            while ((input = Console.ReadLine()) != "3:1")
            {
                string[] command = input.Split();

                if (command[0] == "merge")
                {
                    MergeIndexes(text, command);
                }
                else if (command[0] == "divide")
                {
                    DivideText(text, command);
                }
            }

            Console.WriteLine(string.Join(" ", text));
        }

        static List<string> MergeIndexes(List<string> text, string[] command)
        {
            int startRange = int.Parse(command[1]);
            int endRange = int.Parse(command[2]);
            string merge = "";
            int countEl = 0;

            if (startRange >= text.Count)
            {
                startRange = text.Count - 1;
            }

            if (endRange < 0)
            {
                endRange = 0;
            }

            if (startRange < 0)
            {
                startRange = 0;
            }

            if (endRange >= text.Count)
            {
                endRange = text.Count - 1;
            }

            for (int i = startRange; i <= endRange; i++)
            {
                merge += text[i];
                countEl++;
            }

            text.RemoveRange(startRange, countEl);
            text.Insert(startRange, merge);

            return text;
        }

        static List<string> DivideText(List<string> text, string[] command)
        {
            int indexToDivide = int.Parse(command[1]);
            int partitions = int.Parse(command[2]);
            if (partitions == 0)
            {
                return text;
            }

            int substringLength = text[indexToDivide].Length / partitions;
            int lastSubstringLength = substringLength + text[indexToDivide].Length % partitions;
            int lastElStartIndex = text[indexToDivide].Length - lastSubstringLength;
            List<string> result = new List<string>();

            for (int i = 0; i < lastElStartIndex; i += substringLength)
            {
                result.Add(text[indexToDivide].Substring(i, substringLength).ToString());
            }

            result.Add(text[indexToDivide].Substring(lastElStartIndex, lastSubstringLength));
            text.RemoveAt(indexToDivide);
            text.InsertRange(indexToDivide, result);

            return text;
        }
    }
}