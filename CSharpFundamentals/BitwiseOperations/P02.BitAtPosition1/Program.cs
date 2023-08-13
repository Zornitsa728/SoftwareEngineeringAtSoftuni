namespace P02.BitAtPosition1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            FindBitAtFirstPosition(number);
        }

        static void FindBitAtFirstPosition(int number)
        {
            int mask = 1;
            int lsb = (number >> 1) & mask;
            Console.WriteLine(lsb);

        }
    }
}