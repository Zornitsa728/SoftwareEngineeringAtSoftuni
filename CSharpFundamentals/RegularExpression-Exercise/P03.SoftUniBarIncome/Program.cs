using System.Text.RegularExpressions;

namespace P03.SoftUniBarIncome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string patern = @"^[^\|\$\%\.]*?\%(?<name>[A-Z][a-z]+)\%[^\|\$\%\.]*?\<(?<product>[\w]+)\>[^\|\$\%\.]*?\|(?<count>\d+)\|[^\|\$\%\.]*?(?<price>\d+(\.\d+)?)\$[^\|\$\%\.]*?$";
            string input;
            double totalPrice = 0;

            while ((input = Console.ReadLine()) != "end of shift")
            {
                MatchCollection matches = Regex.Matches(input, patern);
                string name = string.Empty;
                string product = string.Empty;
                int count = 0;
                double price = 0;

                if (matches.Count > 0)
                {
                    foreach (Match match in matches)
                    {
                        name = match.Groups["name"].Value;
                        product = match.Groups["product"].Value;
                        count = int.Parse(match.Groups["count"].Value);
                        price = double.Parse(match.Groups["price"].Value);
                    }
                       
                    price = price * count;
                    totalPrice += price;

                    Console.WriteLine($"{name}: {product} - {price:f2}");
                }
            }

            Console.WriteLine($"Total income: {totalPrice:f2}");
        }
    }
}