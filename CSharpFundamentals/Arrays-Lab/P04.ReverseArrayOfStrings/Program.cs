namespace P04.ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Console.Write(string.Join(" ", input.Reverse()));

        }
    }
}