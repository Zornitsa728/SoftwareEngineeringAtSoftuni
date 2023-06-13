namespace P05.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string product =  Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            Console.WriteLine($"{CalculateOrderPrice(product, quantity):f2}");
        }

        static double CalculateOrderPrice(string product, double quantity)
        {
            double price = 0;

            switch (product)
            {
                case "coffee":
                    price = 1.5 * quantity;
                    break;
                case "water":
                    price = 1 * quantity;
                    break;
                case "coke":
                    price = 1.4 * quantity;
                    break;
                case "snacks":
                    price = 2 * quantity;
                    break;
            }
            
            return price;
        }
    }
}