namespace P07.VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            double coins;
            double money = 0;

            while ((input = Console.ReadLine()) != "Start")
            {
                coins = double.Parse(input);

                if (coins == 0.1)
                {
                    money += 0.1;
                }
                else if (coins == 0.2)
                {
                    money += 0.2;
                }
                else if (coins == 0.5)
                {
                    money += 0.5;
                }
                else if (coins == 1)
                {
                    money += 1;
                }
                else if (coins == 2)
                {
                    money += 2;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
            }

            string product;
            double price = 0;

            while ((product = Console.ReadLine()) != "End")
            {
                if (product == "Nuts")
                {
                    price = 2;
                }
                else if (product == "Water")
                {
                    price = 0.7;
                }
                else if (product == "Crisps")
                {
                    price = 1.5;
                }
                else if (product == "Soda")
                {
                    price = 0.8;
                }
                else if (product == "Coke")
                {
                    price = 1;
                }
                else
                {
                    Console.WriteLine("Invalid product");
                    continue;
                }

                if (money - price >= 0)
                {
                    Console.WriteLine($"Purchased {product.ToLower()}");
                    money -= price;
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
            }

            Console.WriteLine($"Change: {money:f2}");
        }
    }
}