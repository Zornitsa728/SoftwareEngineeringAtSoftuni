namespace P02.CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] secondArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);


            for (int secondElements = 0; secondElements < secondArray.Length; secondElements++)
            {
                for (int firstElements = 0; firstElements < firstArray.Length; firstElements++)
                {
                    if (firstArray[firstElements] == secondArray[secondElements])
                    {
                        Console.Write($"{secondArray[secondElements]} ");
                    }
                }
            }

        }
    }
}