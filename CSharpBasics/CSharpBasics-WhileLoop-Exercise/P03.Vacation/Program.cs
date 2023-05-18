using System;
using System.Reflection.Metadata.Ecma335;

namespace P03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyForVacation = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());
            int day = 0;
            int spendingCounter = 0;

            while (moneyForVacation > availableMoney && spendingCounter < 5)
            {
                string action = Console.ReadLine();
                double currentMoney = double.Parse(Console.ReadLine());
                day++;

                if (action == "save")
                {
                    availableMoney += currentMoney;
                    spendingCounter = 0;
                }
                else 
                {
                    availableMoney -= currentMoney;
                    spendingCounter++;

                    if (availableMoney <= 0)
                    {
                        availableMoney = 0;
                    }
                }
            }

            if (spendingCounter == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine($"{day}");
            }
            else
            {
                Console.WriteLine($"You saved the money for {day} days.");
            }

        }
    }
}
