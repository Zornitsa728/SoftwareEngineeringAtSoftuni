namespace EvenLines
{
    using System;
    using System.Text;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            List<string> evenLines = new List<string>();

            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                string line = "";
                int counter = 0;

                while ((line = reader.ReadLine()) != null)
                {
                    if (counter % 2 == 0)
                    {
                        evenLines.Add(line);
                    }

                    counter++;
                }
            }

            for (int line = 0; line < evenLines.Count; line++)
            {
                if (evenLines[line].Contains('?'))
                {
                    evenLines[line] = evenLines[line].Replace('?', '@');
                }

                if (evenLines[line].Contains('!'))
                {
                    evenLines[line] = evenLines[line].Replace('!', '@');
                }

                if (evenLines[line].Contains('.'))
                {
                    evenLines[line] =evenLines[line].Replace('.', '@');
                }

                if (evenLines[line].Contains(','))
                {
                    evenLines[line] = evenLines[line].Replace(',', '@');
                }

                if (evenLines[line].Contains('-'))
                {
                    evenLines[line] = evenLines[line].Replace('-', '@');
                }

            }

            evenLines.Reverse();

            StringBuilder result = new StringBuilder();

            result.AppendJoin(Environment.NewLine, evenLines);

            return result.ToString();
        }
    }
}
