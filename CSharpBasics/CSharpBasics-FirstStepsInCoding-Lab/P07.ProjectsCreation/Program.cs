using System;

namespace P07.ProjectsCreation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string architectName = Console.ReadLine();
            int projects = int.Parse(Console.ReadLine());
            int hours = projects * 3;
            Console.WriteLine($"The architect {architectName} will need {hours} hours to complete {projects} project/s."); 

        }
    }
}
