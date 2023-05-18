using System;

namespace P08.OnTimeForTheExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivedHour = int.Parse(Console.ReadLine());
            int arrivedMinutes = int.Parse(Console.ReadLine());

            int hours = 0;
            int minutes = 0;

            examMinutes += examHour * 60;
            arrivedMinutes += arrivedHour * 60;
             if (examMinutes>=arrivedMinutes && examMinutes-arrivedMinutes<=30)
            {
                Console.WriteLine("On time");
                if (examMinutes - arrivedMinutes > 0)
                {
                    Console.WriteLine($"{examMinutes - arrivedMinutes} minutes before the start");
                }
            }  
              else if (examMinutes > arrivedMinutes)
            {
                hours = (examMinutes - arrivedMinutes) / 60;
                minutes = (examMinutes - arrivedMinutes) % 60;
                if (hours == 0)
                {
                    if (minutes < 10)
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine($"0{minutes} minutes before the start");
                    }
                    else
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine($"{minutes} minutes before the start");
                    }
                }
                else
                {
                        Console.WriteLine("Early");
                        Console.WriteLine($"{hours}:{minutes:D2} hours before the start");
                }
               
            }  
              else if (examMinutes < arrivedMinutes)
            {
                Console.WriteLine("Late");
                if(examMinutes!= arrivedMinutes && arrivedMinutes-examMinutes<60)
                {
                    Console.WriteLine($"{arrivedMinutes-examMinutes} minutes after the start");
                }
                else if (arrivedMinutes-examMinutes >= 60)
                {
                    hours = (arrivedMinutes-examMinutes) / 60;
                    minutes = (arrivedMinutes-examMinutes) % 60;
                    Console.WriteLine($"{hours}:{minutes:D2} hours after the start");
                }
            }
        }
    }
}
