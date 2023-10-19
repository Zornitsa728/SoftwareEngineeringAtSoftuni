namespace CustomTuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] personTokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string[] drinkTokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string[] numberTokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Tuple<string, string> nameAddress = new($"{personTokens[0]} {personTokens[1]}", personTokens[2]);

            Tuple<string, int> beer = new(drinkTokens[0], int.Parse(drinkTokens[1]));

            Tuple<int, double> numbers = new(int.Parse(numberTokens[0]), double.Parse(numberTokens[1]));

            Console.WriteLine(nameAddress);
            Console.WriteLine(beer);
            Console.WriteLine(numbers);
        }
    }
}