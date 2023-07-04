namespace P06.BlackFlag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysOfThePlunder = int.Parse(Console.ReadLine());
            int dailyPlunder = int.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());
            double sum = 0;


            for (int i = 1; i <= daysOfThePlunder; i++)
            {
                sum += dailyPlunder;

                if (i % 3 == 0)
                {
                    sum += (dailyPlunder * 0.5);
                }

                if (i % 5 == 0)
                {
                    sum -= (sum * 0.3);
                }
            }

            if (sum >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {sum:f2} plunder gained.");
            }
            else
            {
                Console.WriteLine($"Collected only {(sum / expectedPlunder) * 100:f2}% of the plunder.");
            }
        }
    }
}