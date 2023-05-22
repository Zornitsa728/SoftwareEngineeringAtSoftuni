namespace P06.BalancedBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int linesNumber = int.Parse(Console.ReadLine());
            int countOpenBrackets = 0;
            int countClosedBrackets = 0;
            string result = "UNBALANCED";
            bool check = false;

            for (int i = 1; i <= linesNumber; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "(")
                {
                    countOpenBrackets++;
                }
                else if (input[0] == ")")
                {
                    countClosedBrackets++;

                    if (countOpenBrackets - countClosedBrackets != 0)
                    {
                        check = true;
                    }
                }
            }

            if (countOpenBrackets - countClosedBrackets == 0 && check == false)
            {
                result = "BALANCED";
            }

            Console.WriteLine(result);
        }
    }
}