namespace P07.WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int tankCapacity = 255;

            for (int i = 0; i < lines; i++)
            {
                int quantitiesOfWater = int.Parse(Console.ReadLine());

                if (tankCapacity - quantitiesOfWater >= 0)
                {
                    tankCapacity -= quantitiesOfWater;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
            }
            Console.WriteLine(255 - tankCapacity);
        }
    }
}