namespace P04.Refactoring_PrimeChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            

            for (int currentNumber = 2; currentNumber <= range; currentNumber++)
            {
                int counter = 0;

                for (int divider = 1; divider <= currentNumber; divider++)
                {
                    if (currentNumber % divider == 0)
                    {
                       counter++;
                    }
                }

                if (counter == 2)
                {
                    Console.WriteLine($"{currentNumber} -> true");
                }
                else
                {
                    Console.WriteLine($"{currentNumber} -> false");

                }

            }
        }
    }
}