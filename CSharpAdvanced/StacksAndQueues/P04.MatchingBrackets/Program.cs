namespace P04.MatchingBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> openBracketIndexes = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    openBracketIndexes.Push(i);
                }
                else if (input[i] == ')')
                {
                    int startInex = openBracketIndexes.Pop();
                    int length = i - startInex;
                    Console.WriteLine(input.Substring(startInex,length + 1));
                }
            }
        }
    }
}