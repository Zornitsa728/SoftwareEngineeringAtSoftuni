namespace P11.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOrders = int.Parse(Console.ReadLine());
            double pricePerCapsule;
            int days;
            int capsules;
            double coffeePrice = 0;
            double totalPrice = 0;
            for (int i = 0; i < countOrders; i++)
            {
                pricePerCapsule = double.Parse(Console.ReadLine());
                days = int.Parse(Console.ReadLine());
                capsules = int.Parse(Console.ReadLine());

                coffeePrice = ((days * capsules) * pricePerCapsule);
                Console.WriteLine($"The price for the coffee is: ${coffeePrice:f2}");
                totalPrice += coffeePrice;
            }
            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}