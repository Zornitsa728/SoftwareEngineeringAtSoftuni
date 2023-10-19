namespace CustomThreeuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] nameTokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string[] beerTokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string[] bankTokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Threeuple<string, string, string> name = new($"{nameTokens[0]} {nameTokens[1]}", nameTokens[2], string.Join(" ", nameTokens[3..]));

            Threeuple<string, int, bool> beer = new(beerTokens[0], int.Parse(beerTokens[1]), beerTokens[2] == "drunk");

            Threeuple<string, double, string> bank = new(bankTokens[0], double.Parse(bankTokens[1]), bankTokens[2]);

            Console.WriteLine(name);
            Console.WriteLine(beer);
            Console.WriteLine(bank);

        }
    }
}