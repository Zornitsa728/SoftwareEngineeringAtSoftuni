namespace P05.SumEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int sum = 0;

            foreach (int currentNum in numbers)
            {
                if (currentNum % 2 == 0)
                {
                    sum += currentNum;
                }
            }
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = int.Parse(input[i]);

            //    if (numbers[i] % 2 == 0)
            //    {
            //        sum += numbers[i];
            //    }
            //}
            Console.WriteLine(sum);
        }
    }
}