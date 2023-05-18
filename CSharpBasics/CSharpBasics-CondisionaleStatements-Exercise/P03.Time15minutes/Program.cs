using System;

namespace P03.Time15minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            //изчислява колко ще е часът след 15 минути
            minutes += 15+ hours * 60;
            hours = minutes/60;
            minutes = minutes % 60;
            if (hours == 24)
            {
                hours= 0;
            }
            //Резултатът да се отпечата във формат часове:минути
                Console.WriteLine($"{hours}:{minutes:D2}");
           
            


        }
    }
}
