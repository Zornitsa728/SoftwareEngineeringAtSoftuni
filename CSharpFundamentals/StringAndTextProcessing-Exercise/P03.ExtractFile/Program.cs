namespace P03.ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = Console.ReadLine();

            int firstIndex = filePath.LastIndexOf('\\') + 1;
            int lastIndex = filePath.LastIndexOf(".");
            int fileNameLength = lastIndex - firstIndex;
            string fileName = filePath.Substring(firstIndex, fileNameLength);

            string extension = Path.GetExtension(filePath);
            extension = extension.Remove(extension.IndexOf("."), 1);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}