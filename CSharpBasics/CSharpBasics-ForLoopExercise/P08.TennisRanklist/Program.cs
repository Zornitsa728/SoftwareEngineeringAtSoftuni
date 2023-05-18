using System;

namespace P08.TennisRanklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Брой турнири, в които е участвал – цяло число в интервала [1…20] 
            int tournament = int.Parse(Console.ReadLine());
            //Начален брой точки в ранглистата - цяло число в интервала[1...4000]
            int startPoints = int.Parse(Console.ReadLine());
            //Достигнат етап от турнира – текст – "W", "F" или "SF"
            double allPoints = 0;
            int wins = 0;

            for (int i =1; i <= tournament; i++)
            {
                string stageOfTournament = Console.ReadLine();
                if (stageOfTournament == "W")
                {
                    wins++;
                    allPoints += 2000; 
                }
                else if (stageOfTournament == "F")
                {
                    allPoints += 1200; 
                }
                else
                {
                    allPoints += 720; 
                }
            }
            //колко ще са точките след изиграване на всички турнири
            Console.WriteLine($"Final points: {allPoints+startPoints}");
            //колко т. средно печели от всички изиграни турнири
            Console.WriteLine($"Average points: {Math.Floor(allPoints/tournament)}");
            //колко процента от турнирите е спечелил
            Console.WriteLine($"{(double)wins/tournament*100:f2}%"); 
        }
    }
}
