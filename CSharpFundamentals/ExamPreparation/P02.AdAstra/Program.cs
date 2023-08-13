using System.Text.RegularExpressions;

namespace P02.AdAstra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"(\||\#)(?<name>[A-Za-z ]+)\1(?<expirationDate>([\d]{2}\/){2}[\d]{2})\1(?<calories>[0-9]{1,4}|10000)\1";
            Regex regex = new Regex(pattern);
            MatchCollection foods = regex.Matches(text);
            int totalCalories = 0;

            foreach (Match food in foods)
            {
                totalCalories += int.Parse(food.Groups["calories"].Value);
            }

            int caloriesPerDay = 2000;
            Console.WriteLine($"You have food to last you for: {totalCalories / caloriesPerDay} days!");

            foreach (Match food in foods)
            {
                Console.WriteLine($"Item: {food.Groups["name"].Value}, Best before: {food.Groups["expirationDate"].Value}, Nutrition: {food.Groups["calories"].Value}");
            }
        }
    }
}