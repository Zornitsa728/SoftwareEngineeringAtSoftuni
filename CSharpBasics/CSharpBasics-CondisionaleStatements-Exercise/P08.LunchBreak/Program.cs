using System;

namespace P08.LunchBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Име на сериал – текст
            string tvShow = Console.ReadLine();
            //2.Продължителност на епизод  – цяло число в диапазона[10… 90]
            int showDuration = int.Parse(Console.ReadLine());
            //3.Продължителност на почивката  – цяло число в диапазона[10… 120]
            double breakDuration = double.Parse(Console.ReadLine());
            //Времето за обяд ще бъде 1/8 от времето за почивка, а времето за отдих ще бъде 1/4 от времето за почивка. 
            double lunchTime = breakDuration / 8;
            double restTime = breakDuration / 4;
            breakDuration = breakDuration - (lunchTime + restTime);
            if (breakDuration>=showDuration)
            {
                Console.WriteLine($"You have enough time to watch {tvShow} and left with {Math.Ceiling(breakDuration - showDuration)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {tvShow}, you need {Math.Ceiling(showDuration - breakDuration)} more minutes.");
            }
        }
    }
}
