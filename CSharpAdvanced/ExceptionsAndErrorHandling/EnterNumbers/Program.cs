namespace EnterNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = 1;
            int end = 100;
            int currNum = 0;
            int[] result = new int[10];

            for (int i = 0; i < result.Length; i++)
            {
                try
                {
                    currNum = ReadNumber(start, end);
                    start = currNum;
                    result[i] = currNum;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.ParamName);
                    i--;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Number!");
                    i--;
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }

        public static int ReadNumber(int start, int end)
        {
            int number = int.Parse(Console.ReadLine());

            if (number <= start || number >= 99)
            {
                throw new ArgumentOutOfRangeException($"Your number is not in range {start} - 100!");
            }

            return number;
        }
    }
}