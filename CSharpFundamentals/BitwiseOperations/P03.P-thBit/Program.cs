namespace P03.P_thBit
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
            int mask = 1;
            int lsb = (number >> position) & mask;
            Console.WriteLine(lsb);
        }
    }
}