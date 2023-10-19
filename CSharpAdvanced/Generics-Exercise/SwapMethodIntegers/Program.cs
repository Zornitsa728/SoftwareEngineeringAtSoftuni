namespace SwapMethodIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int[] numbers = new int[count];

            for (int i = 0; i < count; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbers[i] = number;
            }

            int[] indexes = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Swap(numbers, indexes[0], indexes[1]);

            foreach (var num in numbers)
            {
                Console.WriteLine($"{num.GetType()}: {num}");
            }
        }

        static void Swap<T>(T[] items, int firstIndex, int SecondIndex)
        {
            T temp = items[firstIndex];
            items[firstIndex]= items[SecondIndex]; 
            items[SecondIndex]= temp;
        }
    }
}