using System;

namespace P06.WorldSwimmingRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Рекордът в секунди – реално число в интервала [0.00 … 100000.00]
            double record = double.Parse(Console.ReadLine());
            //2.Разстоянието в метри – реално число в интервала[0.00 … 100000.00]
            double distance = double.Parse(Console.ReadLine());
            //3.Времето в секунди, за което плува разстояние от 1 м. - реално число в интервала[0.00 … 1000.00]
            double time = double.Parse(Console.ReadLine());
            double delay = Math.Floor(distance/15)*12.5;
            double result = distance * time + delay;
            //Да се изчисли времето в секунди, за което Иванчо ще преплува разстоянието и разликата спрямо Световния рекорд.

            if (result < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {result:F2} seconds.");
            }
            else if (result >= record) 
            {
                Console.WriteLine($"No, he failed! He was {result-record:F2} seconds slower.");
            }
           

        }
    }
}
