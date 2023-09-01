namespace P01.BasicStackOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int elToPush = input[0];
            int elToPop = input[1];
            int elToLookFor = input[2];

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < elToPush; i++)
            {
                stack.Push(numbers[i]);
            }

            for (int j = 0; j < elToPop; j++)
            {
                stack.Pop();
            }

            if (stack.Contains(elToLookFor))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (stack.Any())
                {
                    Console.WriteLine(stack.Min());
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}