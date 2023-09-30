namespace FolderSize
{
    public class FolderSize
    {
        static void Main()
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";

            GetFolderSize(folderPath, outputPath);
        }

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            double result = 0;

            DirectoryInfo mainFolder = new DirectoryInfo("TestFolder");
            FileInfo[] information = mainFolder.GetFiles("*", SearchOption.AllDirectories);

            foreach (FileInfo fileInfo in information)
            {
                result += fileInfo.Length;
            }

            result = result / 1024 / 1024;

            File.WriteAllText("оutput.txt", result.ToString());

        }
    }
}
