namespace P01.ReverseStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cmd;
            while ((cmd = Console.ReadLine()) != "end")
            {
                string word = cmd;
                List<char> reverse = word.Reverse().ToList();
                string reversedWord = string.Join("", reverse);

                Console.WriteLine($"{word} = {reversedWord}");
            }
        }
    }
}