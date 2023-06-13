namespace P07.RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int repeat = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatString(input, repeat));
        }

        static string RepeatString(string input, int repeat)
        {
            string result = string.Empty;

            for (int i = 0; i < repeat; i++)
            {
                result += input;
            }

            return result;
        }
    }
}