namespace P04.ListOfProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> ListOfProducts = new List<string>();
            for (int i = 0; i < n; i++)
            {
                ListOfProducts.Add(Console.ReadLine());
            }

            ListOfProducts.Sort();
            for (int i = 0; i < ListOfProducts.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{ListOfProducts[i]}");
            }
        }
    }
}