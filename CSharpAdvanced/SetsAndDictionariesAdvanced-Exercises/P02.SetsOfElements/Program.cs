namespace P02.SetsOfElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int firstLength = size[0];
            int secondLength = size[1];
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();


            for (int num = 0; num < firstLength; num++)
            {
                firstSet.Add(int.Parse(Console.ReadLine()));
            }

            for (int currNum = 0; currNum < secondLength; currNum++)
            {
                secondSet.Add(int.Parse(Console.ReadLine()));
            }
            

            foreach (int num in firstSet)
            {
                if (secondSet.Contains(num))
                {
                    Console.Write(num + " ");
                }
            }
        }
    }
}