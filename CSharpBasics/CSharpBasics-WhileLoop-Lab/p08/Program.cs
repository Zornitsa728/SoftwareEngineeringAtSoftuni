using System;

namespace p08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            double grades = 0;
            int schoolYear = 1;
            int failGrade = 0;
            double allGrades = 0;

            while (schoolYear <= 12)
            {
                grades = double.Parse(Console.ReadLine());

                if (grades < 4)
                {
                    failGrade++;
                    
                    if (failGrade > 1)
                    {
                        break;
                    }

                    continue;
                }

                allGrades += grades;
                schoolYear++;

            }

            if (failGrade >1)
            {
                Console.WriteLine($"{studentName} has been excluded at {schoolYear} grade");
            }
            else
            {
                Console.WriteLine($"{studentName} graduated. Average grade: {allGrades/(schoolYear-1):f2}");
            }
        }
    }
}
