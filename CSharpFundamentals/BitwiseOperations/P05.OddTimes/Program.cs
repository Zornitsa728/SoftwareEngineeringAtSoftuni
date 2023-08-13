namespace P05.OddTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int result = 0;

            foreach (int number in numbers)
            {
                result ^= number;
            }

            Console.WriteLine(result);
        }
    }
}