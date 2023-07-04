namespace P03.Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            List<int> result = new List<int>();

            FindTopFiveNums(numbers, result);

            if (result.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine(string.Join(" ", result));
            }
        }

        static double CalculateAverage(int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            double average = (double)sum / numbers.Length;
            return average;
        }

        static List<int> FindGreaterThanAverageNums(int[] numbers, List<int> result)
        {
            double average = CalculateAverage(numbers);

            foreach (int number in numbers)
            {
                if (average < number)
                {
                    result.Add(number);
                }
            }

            return result;
        }

        static List<int> FindTopFiveNums(int[] numbers, List<int> result)
        {
            FindGreaterThanAverageNums(numbers, result);

            result.Sort();
            result.Reverse();

            if (result.Count > 5)
            {
                result.RemoveRange(5, (result.Count - 1) - 4);
            }

            return result;
        }
    }
}