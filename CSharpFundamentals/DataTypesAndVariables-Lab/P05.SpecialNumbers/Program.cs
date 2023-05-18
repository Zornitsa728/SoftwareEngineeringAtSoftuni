namespace P05.SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int range = int.Parse(Console.ReadLine());


            for (int number = 1; number <= range; number++)
            {
                int currentNumber = number;
                int sum = 0;

                while (currentNumber > 0)
                {
                    sum += currentNumber % 10;
                    currentNumber /= 10;
                }

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{number} -> True");
                }
                else
                {
                    Console.WriteLine($"{number} -> False");
                }
            }
        }
    }
}