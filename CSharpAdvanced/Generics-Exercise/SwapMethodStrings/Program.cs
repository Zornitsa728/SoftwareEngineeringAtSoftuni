namespace SwapMethodStrings
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> items = new List<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                items.Add(Console.ReadLine());
            }

            int[] indexes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            SwapElements(items, indexes[0], indexes[1]);

            foreach (var item in items)
            {
                Console.WriteLine($"{item.GetType()}: {item}");
            }
        }

        static void SwapElements<T>(List<T> items, int firstIndex, int secondIndex)
        {
            T temp = items[firstIndex];
            items[firstIndex] = items[secondIndex];
            items[secondIndex] = temp;
        }
    }
}