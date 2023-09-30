    using System;
using System.Text;

namespace DirectoryTraversal;

public class DirectoryTraversal
{
    static void Main()
    {
        string path = Console.ReadLine();
        string reportFileName = @"\report.txt";

        string reportContent = TraverseDirectory(path);
        Console.WriteLine(reportContent);

        WriteReportToDesktop(reportContent, reportFileName);
    }

    public static string TraverseDirectory(string inputFolderPath)
    {
        SortedDictionary<string, List<FileInfo>> extensionsfiles = new SortedDictionary<string, List<FileInfo>>();
        string[] fileNames = Directory.GetFiles(inputFolderPath);

        foreach (string fileName in fileNames)
        {
            FileInfo fileInfo = new FileInfo(fileName);

            if (!extensionsfiles.ContainsKey(fileInfo.Extension))
            {
                extensionsfiles.Add(fileInfo.Extension, new List<FileInfo>());
            }

            extensionsfiles[fileInfo.Extension].Add(fileInfo);
        }

        StringBuilder sb = new StringBuilder();

        foreach (var extension in extensionsfiles.OrderByDescending(ef => ef.Value.Count))
        {
            sb.AppendLine(extension.Key);

            foreach (var file in extension.Value)
            {
                sb.AppendLine($"--{file.Name} - {(double)file.Length / 1024:f3}kb");
            }
        }

        return sb.ToString();
    }

    public static void WriteReportToDesktop(string textContent, string reportFileName)
    {
        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + reportFileName;
        File.WriteAllText(path, textContent);   
    }
}
