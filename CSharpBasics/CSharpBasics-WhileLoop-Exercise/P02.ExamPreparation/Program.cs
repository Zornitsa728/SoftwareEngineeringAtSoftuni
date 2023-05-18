using System;

namespace P02.ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int failGrades = int.Parse(Console.ReadLine());
            string task ;
            int count = 0;
            int allGrades = 0;
            int sumFromGrades = 0;
            int sumTasks = 0;
            string lastTask = string.Empty;

            while ((task = Console.ReadLine()) != "Enough")
            {
                int grade = int.Parse(Console.ReadLine());

                if (grade<=4)
                {
                    count++;

                    if (count == failGrades) 
                    {
                        break;
                    }
       
                }
                lastTask = task;
                sumTasks++;
                allGrades++;
                sumFromGrades += grade;
            }

            if (task == "Enough")
            {
                Console.WriteLine($"Average score: {(double)sumFromGrades/allGrades:f2}");
                Console.WriteLine($"Number of problems: {sumTasks}");
                Console.WriteLine($"Last problem: {lastTask}");
            }
            else
            {
                Console.WriteLine($"You need a break, {count} poor grades.");
            }
        }
    }
}
