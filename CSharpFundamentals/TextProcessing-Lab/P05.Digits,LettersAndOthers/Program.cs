namespace P05.Digits_LettersAndOthers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(string.Join("",input.Where(char.IsDigit)));
            Console.WriteLine(string.Join("",input.Where(char.IsLetter)));
            Console.WriteLine(string.Join("",input.Where(x => !char.IsLetterOrDigit(x))));


            //Dictionary<string,List<char>> result = new Dictionary<string,List<char>>();

            //result["digits"] = new List<char>();
            //result["letters"] = new List<char>();
            //result["otherChars"] = new List<char>();

            //for (int i = 0; i < input.Length; i++)
            //{
            //    if (char.IsLetter(input[i]))
            //    {
            //        result["letters"].Add(input[i]);
            //    }
            //    else if (char.IsDigit(input[i]))
            //    {
            //        result["digits"].Add(input[i]);
            //    }
            //    else 
            //    {
            //        result["otherChars"].Add(input[i]);
            //    }
            //}

            //foreach (var kvp in result)
            //{
            //    Console.WriteLine(string.Join("",kvp.Value));
            //}
        }
    }
}