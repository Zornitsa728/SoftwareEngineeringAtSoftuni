namespace P03.Zig_ZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int[] numbers;
            int[] firstArray = new int[input];
            int[] secondArray = new int[input];

            for (int loops = 0; loops < input; loops++)
            {
                numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (loops % 2 == 0)
                {
                    firstArray[loops] = numbers[0];
                    secondArray[loops] = numbers[1];
                }
                else
                {
                    firstArray[loops] = numbers[1];
                    secondArray[loops] = numbers[0];
                }
            }
            Console.WriteLine(string.Join(" ", firstArray));
            Console.WriteLine(string.Join(" ", secondArray));
        }
    }
}