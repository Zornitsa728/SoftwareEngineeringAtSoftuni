namespace P08.MagicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int specialNumber = int.Parse(Console.ReadLine());

            for (int currentNum = 0; currentNum < numbers.Length - 1; currentNum++)
            {
                for (int i = currentNum + 1; i < numbers.Length; i++)
                {
                    if (numbers[currentNum] + numbers[i] == specialNumber)
                    {
                        Console.Write(numbers[currentNum] + " " + numbers[i]);
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}