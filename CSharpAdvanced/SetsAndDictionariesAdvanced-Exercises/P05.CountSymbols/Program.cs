namespace P05.CountSymbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Dictionary<char,int> chars = new Dictionary<char,int>();

            for (int currEl = 0; currEl < text.Length; currEl++)
            {
                if (!chars.ContainsKey(text[currEl]))
                {
                    chars.Add(text[currEl], 0);
                }

                chars[text[currEl]]++;
            }

            foreach (var currChar in chars.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{currChar.Key}: {currChar.Value} time/s");
            }
        }
    }
}