namespace P05.TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();


            for (int currentNumber = 0; currentNumber < numbers.Length; currentNumber++)
            {
                bool isTopInteger = false;

                for (int nextNumber = currentNumber + 1; nextNumber < numbers.Length; nextNumber++)
                {
                    if (numbers[currentNumber] <= numbers[nextNumber])
                    {
                        isTopInteger = true;
                        break;
                    }
                }

                if (!isTopInteger)
                {
                    Console.Write($"{numbers[currentNumber]} ");
                }
            }
        }
    }
}