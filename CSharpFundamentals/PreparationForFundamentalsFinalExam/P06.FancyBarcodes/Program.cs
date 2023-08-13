using System.Text.RegularExpressions;

namespace P06.FancyBarcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countBarcodes = int.Parse(Console.ReadLine());
            string pattern = @"^\@\#+(?<text>[A-Z][^\W_]{4,}[A-Z])\@\#+$";
            Regex regex = new Regex(pattern);
            

            for (int currBarcode = 0; currBarcode < countBarcodes; currBarcode++)
            {
                string input = Console.ReadLine();
                Match match = regex.Match(input);

                if (match.Success)
                {
                    string numbers = string.Empty;
                    string currMatch = match.Groups["text"].Value;
                    for (int currEl = 0; currEl < currMatch.Length; currEl++)
                    {
                        if (char.IsDigit(currMatch[currEl]))
                        {
                            numbers += currMatch[currEl];
                        }
                    }

                    if (numbers == string.Empty)
                    {
                        numbers = "00";
                    }

                    Console.WriteLine($"Product group: {numbers}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}