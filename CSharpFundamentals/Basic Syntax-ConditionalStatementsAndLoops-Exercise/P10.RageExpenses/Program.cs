using System.Collections.Generic;
using System.Drawing;

namespace P10.RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            double expenses = 0;
            int counter = 0;

            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    expenses += headsetPrice;
                }
                else if (i % 3 == 0)
                {
                    expenses += mousePrice;
                }

                if (i % 2 == 0 && i % 3 == 0)
                {
                    expenses += mousePrice;
                    expenses += keyboardPrice;
                    counter++;
                    if (counter == 2)
                    {
                        expenses += displayPrice;
                        counter = 0;
                    }
                }
            }

            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");

        }
    }
}