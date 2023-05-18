using System;

namespace P03.TestAnotherVersion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            //изчислява колко ще е часът след 15 минути
            hours = hours + ((minutes+15)/ 60);
            minutes = (minutes+15) % 60;
            
            
            if (hours == 24)
            {
                hours = 0;
            }
            //Резултатът да се отпечата във формат часове:минути
            Console.WriteLine($"{hours}:{minutes:D2}");
        }
    }
}
