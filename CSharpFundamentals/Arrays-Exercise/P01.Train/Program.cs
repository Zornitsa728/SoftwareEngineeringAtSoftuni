namespace P01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int[] peoplePerWagon = new int[wagons];
            int sum = 0;

            for (int i = 0; i < wagons; i++)
            {
                peoplePerWagon[i] = int.Parse(Console.ReadLine());
                Console.Write($"{peoplePerWagon[i]} ");
                sum += peoplePerWagon[i];
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}