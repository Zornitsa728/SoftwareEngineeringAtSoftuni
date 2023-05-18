namespace P03.ExactSumOfRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countNumbers = int.Parse(Console.ReadLine());
            decimal sumNumbers = 0;
            for (int i = 0; i < countNumbers; i++)
            {
                decimal randomNumber = decimal.Parse(Console.ReadLine());
                sumNumbers += randomNumber;
            }
            Console.WriteLine(sumNumbers);
        }
    }
}