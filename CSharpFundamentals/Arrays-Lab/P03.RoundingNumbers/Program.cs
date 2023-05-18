namespace P03.RoundingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            double[] realNumbers = new double[input.Length];
            int[] roundedNums = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                realNumbers[i] = double.Parse(input[i]);
                roundedNums[i] = (int)Math.Round(realNumbers[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{realNumbers[i]} => {roundedNums[i]}");
            }
        }
    }
}