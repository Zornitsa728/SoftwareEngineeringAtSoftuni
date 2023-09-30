namespace LineNumbers
{
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                string line = "";
                int row = 1;

                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        writer.WriteLine($"{row}. {line}");

                        row++;
                    }
                }
            }
        }
    }
}
