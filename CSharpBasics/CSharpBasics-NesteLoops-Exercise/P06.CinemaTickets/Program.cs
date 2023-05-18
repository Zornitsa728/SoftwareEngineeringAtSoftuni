using System;

namespace P06.CinemaTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieName; 
            int student = 0;             
            int standart = 0;            
            int kid = 0;                 

            while ((movieName = Console.ReadLine()) != "Finish")
            {
                int freeSeats = int.Parse(Console.ReadLine());
                double allSeats = freeSeats;
                string typeOfTicket;
                int count = 0;

                while ((typeOfTicket = Console.ReadLine()) != "End" )
                {
                    if (typeOfTicket == "student")
                    {
                        student++;
                        count++;
                    }
                    else if (typeOfTicket == "standard")
                    {
                        standart++;
                        count++;    
                    }
                    else
                    {
                        kid++;
                        count++;
                    }

                    freeSeats--;

                    if (freeSeats == 0)
                    {
                        break;
                    }
                }

                Console.WriteLine($"{movieName} - {count/allSeats*100:f2}% full.");
            }

            int allTickets = student + standart + kid;

            if (movieName == "Finish")
            {
                Console.WriteLine($"Total tickets: {allTickets}");
                Console.WriteLine($"{(double)student/allTickets*100:f2}% student tickets.");
                Console.WriteLine($"{(double)standart / allTickets * 100:f2}% standard tickets.");
                Console.WriteLine($"{(double)kid / allTickets * 100:f2}% kids tickets.");
            }
        }
    }
}
