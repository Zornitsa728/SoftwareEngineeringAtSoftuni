using System;

namespace P07.WorkingHours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string dayOfWeek = Console.ReadLine();

            //работното време на офисът е от 10-18 часа, от понеделник до събота включително
            if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" ||
                dayOfWeek == "Friday" || dayOfWeek == "Saturday")

            {
                if (hour >= 10 && hour <= 18)
                {
                    Console.WriteLine("open");
                }
                else
                    Console.WriteLine("closed");
            }
            else if (dayOfWeek == "Sunday")
                Console.WriteLine("closed");
            


        }
    }
}
