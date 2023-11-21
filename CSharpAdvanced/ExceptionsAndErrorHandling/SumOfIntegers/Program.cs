namespace SumOfIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ");

            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                try
                {
                    sum += IsNumValid(input[i]);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (OverflowException e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    Console.WriteLine($"Element '{input[i]}' processed - current sum: {sum}");
                }
            }

            Console.WriteLine($"The total sum of all integers is: {sum}");
        }

        static int IsNumValid(string num)
        {
            if (!int.TryParse(num, out int result))
            {
                if (long.TryParse(num, out long resultNum))
                {
                    throw new OverflowException($"The element '{num}' is out of range!");
                }

                throw new FormatException($"The element '{num}' is in wrong format!");
            }

            return int.Parse(num);
        }
    }
}