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

            for (int i = 0; i < rotations; i++)
            {
                firstNum = result[0];

                for (int j = 0; j < numbers.Length; j++)
                {
                    if (j < numbers.Length - 1)
                    {
                        result[j] = numbers[j + 1];
                    }
                    else
                    {
                        result[j] = firstNum;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}