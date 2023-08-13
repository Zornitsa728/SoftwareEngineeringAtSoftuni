namespace P04.BitDestroyer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());
            FindBitAtFirstPosition(number, position);
        }
        static void FindBitAtFirstPosition(int number, int position)
        {
            int mask = ~(1 << position);
            int result = number & mask;
            Console.WriteLine(result);
        }
    }
}