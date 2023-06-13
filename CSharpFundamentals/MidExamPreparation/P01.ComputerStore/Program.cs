using System.Diagnostics;

namespace P01.ComputerStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            double sum = 0;

            while ((input = Console.ReadLine()) != "special" && input != "regular")
            {
                double price = double.Parse(input);
                if (price < 0)
                {
                    Console.WriteLine("Invalid price!");
                    continue;
                }
                sum += price;
            }

            if (sum == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                double taxes = sum * 0.2;
                

                

                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {sum:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");

                double totalSum = sum + taxes;
                if (input == "special")
                {
                    totalSum -= (totalSum * 0.1);
                }

                Console.WriteLine($"Total price: {totalSum:f2}$");
            }
        }
    }
}