namespace ExtractSpecialBytes
{
    public class ExtractSpecialBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }

        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            byte[] binaryLines = File.ReadAllBytes(binaryFilePath);
            byte[] bytesLines = File.ReadAllBytes(bytesFilePath);

            var result = binaryLines.Intersect(bytesLines);

            using (StreamWriter output = new StreamWriter(outputPath))
            {
                foreach (var line in result)
                {
                    output.WriteLine(line);
                }
            }
        }
    }
}
