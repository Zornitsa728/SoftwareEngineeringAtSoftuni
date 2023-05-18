namespace P02.PrintNumbersInReverseOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int[] numbersArray = new int[numbers];

            for (int i = 0; i < numbers; i++)
            {
                numbersArray[i] = int.Parse(Console.ReadLine());

            }

            for (int reversedOrder = numbers - 1; reversedOrder >= 0; reversedOrder--)
            {
                Console.Write($"{numbersArray[reversedOrder]} ");
            }
        }
    }
}