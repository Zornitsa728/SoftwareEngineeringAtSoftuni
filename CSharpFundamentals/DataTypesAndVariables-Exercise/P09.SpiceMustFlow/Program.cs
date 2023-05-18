namespace P09.SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int workersConsumation = 26;
            int leftYield;
            int dailyReduce = startingYield;
            int days = 0;
            int totalAmount = 0;

            while (dailyReduce >= 100)
            {
                days++;
                if (days == 1)
                {
                    dailyReduce = startingYield - 10;
                    leftYield = startingYield - workersConsumation;
                }
                else
                {
                    leftYield = dailyReduce - workersConsumation;
                    dailyReduce -= 10;
                }

                totalAmount += leftYield;
                if (dailyReduce < 100)
                {
                    totalAmount -= workersConsumation;
                }
            }

            Console.WriteLine(days);
            Console.WriteLine(totalAmount);
        }
    }
}