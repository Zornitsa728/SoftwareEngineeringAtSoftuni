namespace P01.CountSameValuesInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] values = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            Dictionary<double,int> countSameValues = new Dictionary<double,int>();

            foreach (double value in values)
            {
                if (countSameValues.ContainsKey(value))
                {
                    countSameValues[value]++;
                }
                else
                {
                    countSameValues.Add(value, 1);
                }
            }

            foreach (var count in countSameValues)
            {
                Console.WriteLine($"{count.Key} - {count.Value} times");
            }
        }
    }
}