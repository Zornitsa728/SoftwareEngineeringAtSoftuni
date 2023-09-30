namespace P03.PeriodicTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            HashSet<string> chemicalElements = new HashSet<string>();

            for (int currEls = 0; currEls < count; currEls++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < tokens.Length; i++)
                {
                    chemicalElements.Add(tokens[i]);
                }
            }

            foreach (string element in chemicalElements.OrderBy(x => x))
            {
                Console.Write(element + " ");
            }
        }
    }
}