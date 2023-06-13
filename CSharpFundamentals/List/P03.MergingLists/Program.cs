namespace P03.MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            bool largList = false;
            int largerList = Math.Max(firstList.Count, secondList.Count);
            List<int> result = new List<int>();
            for (int i = 0; i < largerList; i++)
            {
                if (firstList.Count > i)
                {
                    result.Add(firstList[i]);
                }

                if (secondList.Count > i)
                {
                    result.Add(secondList[i]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}