namespace P06.Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> customersNames = new Queue<string>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                if (input != "Paid")
                {
                    customersNames.Enqueue(input);
                }
                else
                {
                    while (customersNames.Count > 0)
                    {
                        Console.WriteLine(customersNames.Dequeue());
                    }
                }
            }

            Console.WriteLine($"{customersNames.Count} people remaining.");
        }
    }
}