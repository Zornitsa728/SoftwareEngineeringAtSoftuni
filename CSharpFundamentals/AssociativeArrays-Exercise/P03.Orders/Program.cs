namespace P03.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            AddProductInfo(products);

            Dictionary<string, double> productAndPrice = new Dictionary<string, double>();
            CalculateTotalPrice(products, productAndPrice);

            Printresult(productAndPrice);
        }
        private static void Printresult(Dictionary<string, double> productAndPrice)
        {
            foreach (var kvp in productAndPrice)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value:f2}");
            }
        }
        private static void CalculateTotalPrice(List<Product> products, Dictionary<string, double> productAndPrice)
        {
            foreach (Product product in products)
            {
                productAndPrice.Add(product.Name, (product.Price * product.Quantity));
            }
        }
        static void AddProductInfo(List<Product> products)
        {
            string input;

            while ((input = Console.ReadLine()) != "buy")
            {
                string[] cmdArgs = input.Split();
                string productName = cmdArgs[0];
                double price = double.Parse(cmdArgs[1]);
                int quantity = int.Parse(cmdArgs[2]);
                Product product = new Product(productName, price, quantity);

                if (ProductExist(productName, products))
                {
                    Product findProduct = products.Find(x => x.Name == productName);
                    findProduct.Quantity += quantity;

                    if (findProduct.Price != price)
                    {
                        findProduct.Price = price;
                    }
                }
                else
                {
                    products.Add(product);
                }
            }
        }
        static bool ProductExist(string productName, List<Product> products)
        {
            if (products.Any(x => x.Name == productName))
            {
                return true;
            }

            return false;
        }
    }
    public class Product
    {
        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }


    }
}