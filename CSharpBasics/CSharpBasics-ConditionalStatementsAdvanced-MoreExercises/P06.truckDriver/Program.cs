using System;

namespace P06.truckDriver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Сезон – текст "Spring", "Summer", "Autumn" или "Winter"
            string seasson = Console.ReadLine();
            //Километри на месец – реално число в интервала[10.00...20000.00]
            double kilometrePerMonth = double.Parse(Console.ReadLine());
            double kilometrePerSeasson = kilometrePerMonth *4;
            double salary = 0;
            double taxes = 0;
            if (kilometrePerMonth <= 5000)
            {
                if(seasson == "Spring" || seasson == "Autumn")
                {
                    salary = kilometrePerSeasson * 0.75;
                }
                else if (seasson == "Summer")
                {
                    salary = kilometrePerSeasson * 0.90;
                }
                else
                {
                    salary = kilometrePerSeasson * 1.05;
                }
            }
            else if (kilometrePerMonth>5000 && kilometrePerMonth<=10000)
            {
                if (seasson == "Spring" || seasson == "Autumn")
                {
                    salary = kilometrePerSeasson * 0.95;
                }
                else if (seasson == "Summer")
                {
                    salary = kilometrePerSeasson * 1.1;
                }
                else
                {
                    salary = kilometrePerSeasson * 1.25;
                }
            }
            else if (kilometrePerMonth > 10000 && kilometrePerMonth <= 20000)
            {
                salary = kilometrePerSeasson * 1.45;
            }

            taxes = salary * 0.1;
            salary -= taxes;
            Console.WriteLine($"{salary:f2}");
        }
    }
}
