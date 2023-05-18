using System;

namespace P05.MountainRun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Рекордът в секунди – реално число в интервала [0.00 … 100000.00]
            double record = double.Parse(Console.ReadLine());
            //Разстоянието в метри – реално число в интервала[0.00 … 100000.00]
            double distance = double.Parse(Console.ReadLine());
            //Времето в секунди, за което изкачва 1 м. – реално число в интервала[0.00 … 1000.00]
            double secondsPerMeter = double.Parse(Console.ReadLine());

            //наклона на терена го забавя на всеки 50 м. с 30 секунди 
            double delay = Math.Floor(distance / 50) * 30;  //резултатът трябва да се закръгли надолу до най-близкото цяло число.
            //Да се изчисли времето в секунди, за което Георги ще изкачи разстоянието до върха и разликата спрямо рекорда. 
            double totalTime = (distance * secondsPerMeter) + delay;
            if(record > totalTime)
            {
                Console.WriteLine($"Yes! The new record is {totalTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No! He was {totalTime-record:f2} seconds slower.");
            }

        }
    }
}
