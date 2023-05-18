namespace P07.EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firsArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isTrue = false;
            int sum = 0;
            int counter = 0;

            for (int i = 0; i < firsArray.Length; i++)
            {
                if (firsArray[i] == secondArray[i])
                {
                    sum += firsArray[i];
                }
                else if (firsArray[i] != secondArray[i] && isTrue == false)
                {
                    isTrue = true;
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }
            }

            if (isTrue == false)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}