namespace P03.Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string keyWord = Console.ReadLine();
            string text = Console.ReadLine();

            while (text.Contains(keyWord))
            {
                int firstIndex = text.IndexOf(keyWord);
                text = text.Remove(firstIndex, keyWord.Length);
            }

            Console.WriteLine(text);
        }
    }
}