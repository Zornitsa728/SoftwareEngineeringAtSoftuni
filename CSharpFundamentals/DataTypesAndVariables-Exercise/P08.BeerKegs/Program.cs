namespace P08.BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            string model = string.Empty;
            double maxValue = double.MinValue;
            string biggestKeg = string.Empty;

            for (int currentLine = 1; currentLine <= lines; currentLine++)
            {
                model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radius, 2) * height;
                if (volume > maxValue)
                {
                    maxValue = volume;
                    biggestKeg = model;
                }

            }
            Console.WriteLine(biggestKeg);
        }
    }
}