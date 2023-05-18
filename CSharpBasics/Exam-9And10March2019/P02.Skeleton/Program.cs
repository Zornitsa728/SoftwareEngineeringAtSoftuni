using System;

namespace P02.Skeleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Минути на контролата – цяло число в интервала [0…59]
            int minutes = int.Parse(Console.ReadLine())*60;
            //Секунди на контролата – цяло число в интервала [0…59]
            int seconds = int.Parse(Console.ReadLine());
            //Дължината на улея в метри – реално число в интервала [0.00…50000]
            double length = double.Parse(Console.ReadLine());
            //Секунди за изминаване на 100 метра – цяло число в интервала [0…1000]
            int secondsPerMeeters = int.Parse(Console.ReadLine());
            //на всеки 120 метра неговото време намаля с 2.5 секунди.

            seconds += minutes;
            double slow = length / 120 * 2.5;
            double totalTime= (length/100)*secondsPerMeeters - slow;

            if (seconds >= totalTime)
            {
                Console.WriteLine("Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {totalTime:f3}.");
            }
            else
            {
                Console.WriteLine($"No, Marin failed! He was {totalTime-seconds:f3} second slower.");
            }

        }
    }
}
