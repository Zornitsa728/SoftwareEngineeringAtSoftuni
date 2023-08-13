namespace P04.TextFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] banList = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string text = Console.ReadLine();
            

            for (int currBanWord = 0; currBanWord < banList.Length; currBanWord++)// check current ban word
            {
                text = text.Replace(banList[currBanWord], new string('*', banList[currBanWord].Length));
            }

            Console.WriteLine(text);
        }
    }
}