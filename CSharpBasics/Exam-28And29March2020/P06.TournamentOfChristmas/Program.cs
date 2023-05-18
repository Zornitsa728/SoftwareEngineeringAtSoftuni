using System;

namespace P06.TournamentOfChristmas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string sport;
            double moneyForADay = 0;
            int winDays = 0;

            for (int i = 1; i <= days; i++)
            {
                int countWin = 0;
                int countLose = 0;
                double money = 0;

                while ((sport=Console.ReadLine()) != "Finish")
            {
                string result = Console.ReadLine();
                
                if (result == "win")
                {
                    money += 20;
                    countWin++;
                }
                else
                {
                    countLose++;
                }
            }

                if (countWin > countLose)
                {
                    moneyForADay += money + money * 0.10;
                    winDays++;
                }
                else
                {
                    moneyForADay += money;
                }
            }

            if (winDays>days-winDays)
            {
                Console.WriteLine($"You won the tournament! Total raised money: {moneyForADay+moneyForADay*0.2:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {moneyForADay:f2}");
            }
        }
    }
}
