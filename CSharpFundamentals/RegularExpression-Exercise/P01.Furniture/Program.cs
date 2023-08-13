using System.Text.RegularExpressions;

namespace P01.Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regex = @"^>>(?<furnitureName>[A-Za-z]+)<<(?<price>\d+(?:\.\d+)?)!(?<quantity>\d+)(?:\.\d+)?$";
            string input;
            List<string> furnitures = new List<string>();
            double totalPrice = 0;

            while ((input = Console.ReadLine()) != "Purchase")
            {
                Match matchedFurniture = Regex.Match(input, regex);

                if (matchedFurniture.Success)
                {
                    string furnitureName = matchedFurniture.Groups["furnitureName"].Value;
                        double currPrice = double.Parse(matchedFurniture.Groups["price"].Value);
                        double quantity = double.Parse(matchedFurniture.Groups["quantity"].Value);

                    furnitures.Add(furnitureName);
                    totalPrice += currPrice * quantity;
                }
            }

            Console.WriteLine("Bought furniture:");

            foreach (string furnitureName in furnitures) 
            {
                Console.WriteLine(furnitureName);
            }
            
            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}