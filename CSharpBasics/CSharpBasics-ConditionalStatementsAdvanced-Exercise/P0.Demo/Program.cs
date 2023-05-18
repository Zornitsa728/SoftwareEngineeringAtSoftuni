using System;

namespace P0.Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine())*60;
            int examMinutes = int.Parse(Console.ReadLine());    
            int arrivedHour = int.Parse(Console.ReadLine())*60;
            int arrivedMinutes = int.Parse(Console.ReadLine());

            examHour += examMinutes;
            arrivedHour += arrivedMinutes;

            if (examHour - arrivedHour > 30)
            {
                Console.WriteLine("Early");
                if (examHour - arrivedHour < 60 && examHour - arrivedHour > 0)
                {
                    Console.WriteLine($"{examHour - arrivedHour} minutes before the start");
                }
                else
                {
                    arrivedHour = examHour - arrivedHour;
                    arrivedMinutes = arrivedHour % 60;
                    arrivedHour /= 60;
                    Console.WriteLine($"{arrivedHour}:{arrivedMinutes:d2} hours before the start");
                }
            }
            else if (examHour - arrivedHour <= 30 && examHour - arrivedHour >= 0)
            {
                Console.WriteLine("On time");
                if (examHour != arrivedHour)
                {
                    if (examHour - arrivedHour < 60 && examHour - arrivedHour > 0)
                    {
                    Console.WriteLine($"{examHour - arrivedHour} minutes before the start");
                    }
                    else
                    {
                    arrivedHour = examHour - arrivedHour;
                    arrivedMinutes = arrivedHour % 60;
                    arrivedHour /= 60;
                    Console.WriteLine($"{arrivedHour}:{arrivedMinutes:d2} hours before the start");
                    }
                }
            }
            else if (arrivedHour - examHour > 0)
            {
                Console.WriteLine("Late");

                if (arrivedHour - examHour < 60 && arrivedHour - examHour > 0)
                {
                    Console.WriteLine($"{arrivedHour - examHour} minutes after the start");
                }
                else
                {
                    arrivedHour = arrivedHour - examHour;
                    arrivedMinutes = arrivedHour % 60;
                    arrivedHour /= 60;
                    Console.WriteLine($"{arrivedHour}:{arrivedMinutes:d2} hours after the start");
                }
            }
            
        }
    }
}
