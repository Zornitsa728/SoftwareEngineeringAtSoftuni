namespace P04.ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());
            int[] result = numbers;
            int firstNum;
            int rotationsOptimize = rotations % numbers.Length;

            for (int i = 0; i < rotationsOptimize; i++)
            {
                firstNum = result[0];

                for (int currentNum = 0; currentNum < numbers.Length; currentNum++)
                {
                    if (currentNum < numbers.Length - 1)
                    {
                        result[currentNum] = numbers[currentNum + 1];
                    }
                    else
                    {
                        result[currentNum] = firstNum;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}