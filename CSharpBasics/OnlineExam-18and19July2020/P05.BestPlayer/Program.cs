using System;

namespace P05.BestPlayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string playerName;
            int goals = 0;
            int maxGoals = int.MinValue;
            string footballer = string.Empty;

            while ((playerName = Console.ReadLine()) != "END")
            {
                goals = int.Parse(Console.ReadLine());

                if (goals > maxGoals)
                {
                    footballer = playerName;
                    maxGoals = goals;
                }

                if (goals >= 10)
                {
                    break;
                }
            }

            Console.WriteLine($"{footballer} is the best player!");
            if (maxGoals >= 3)
            {
                Console.WriteLine($"He has scored {maxGoals} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {maxGoals} goals.");
            }
        }
    }
}
