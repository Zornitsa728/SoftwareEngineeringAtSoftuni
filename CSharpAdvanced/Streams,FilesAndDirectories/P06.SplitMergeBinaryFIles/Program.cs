namespace SplitMergeBinaryFile
{
    public class SplitMergeBinaryFile
    {
        static void Main()
        {
            string sourceFilePath = @"..\..\..\Files\example.png";
            string joinedFilePath = @"..\..\..\Files\example-joined.png";
            string partOnePath = @"..\..\..\Files\part-1.bin";
            string partTwoPath = @"..\..\..\Files\part-2.bin";

            SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
            MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
        }

        public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
        {
            using (FileStream stream = new FileStream(sourceFilePath, FileMode.Open))
            {
                long sizeOfFirstPart = 0;
                long sizeOfSecondPart = 0;

                if (stream.Length % 2 == 0)
                {
                    sizeOfFirstPart = stream.Length / 2;
                    sizeOfSecondPart = stream.Length / 2;
                }
                else
                {
                    sizeOfFirstPart += (stream.Length / 2) + 1;
                    sizeOfSecondPart += (stream.Length / 2) - 1;
                }

                using (var firstPart = new FileStream(partOneFilePath, FileMode.Create))
                {
                    byte[] buffer = new byte[sizeOfFirstPart];

                    firstPart.Write(buffer, 0, (int)sizeOfFirstPart);
                }

                using (var secondPart = new FileStream(partTwoFilePath, FileMode.Create))
                {
                    byte[] buffer = new byte[sizeOfSecondPart];

                    secondPart.Write(buffer, 0, (int)sizeOfSecondPart);
                }

            }
        }

        public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
        {

            using (FileStream joinedFile = new FileStream(joinedFilePath, FileMode.OpenOrCreate))
            {
                using (FileStream firstFile = new FileStream(partOneFilePath, FileMode.Open))
                {
                    byte[] buffer = new byte[firstFile.Length];

                    joinedFile.Write(buffer, 0, (int)firstFile.Length);
                }

                using (FileStream secondFile = new FileStream(partTwoFilePath, FileMode.Open))
                {
                    byte[] buffer = new byte[secondFile.Length];

                    joinedFile.Write(buffer, 0, (int)secondFile.Length);
                }
            }
        }
    }
}
