namespace P07.AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split('|', ' ', StringSplitOptions.RemoveEmptyEntries).Reverse().ToArray();

            List<string> result = new List<string>();

            foreach (string currEl in input)
            {
                result.AddRange(currEl.Split(" ", StringSplitOptions.RemoveEmptyEntries));
            }

            //second option is to reverse with for loop and add all elements one by one to the list
            //for (int lastIndex = input.Length - 1; lastIndex >= 0; lastIndex--)
            //{
            //    string[] removeWhiteSpaces = input[lastIndex].Split(" ", StringSplitOptions.RemoveEmptyEntries);
            //    for (int i = 0; i < removeWhiteSpaces.Length; i++)
            //    {
            //        result.Add(removeWhiteSpaces[i]);
            //    }
            //}

            Console.WriteLine(string.Join(" ", result));
        }
    }
}