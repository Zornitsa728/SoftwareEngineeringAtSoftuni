namespace P04.ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = string.Empty;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                output += input[i];
            }

            Console.WriteLine(output);

            //for (int i = input.Length-1; i >=0; i--)
            //{
            //    Console.Write(input[i]);
            //}
        }
    }
}