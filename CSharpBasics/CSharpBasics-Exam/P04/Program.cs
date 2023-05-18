using System;

namespace P04_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int countOne = 0;
            int countTwo =0;
            int countThree = 0;
            int countFour = 0;
            double allGrades = 0;

            for (int i = 1; i <= students; i++)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade <= 2.99)
                {
                    countOne++;
                }
                else if (grade <= 3.99)
                {
                    countTwo++;
                }
                else if (grade <= 4.99)
                {
                    countThree++;
                }
                else
                {
                    countFour++;
                }
                allGrades += grade;
            }

            Console.WriteLine($"Top students: {(double)countFour /students*100:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {(double)countThree / students * 100:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {(double)countTwo / students * 100:f2}%");
            Console.WriteLine($"Fail: {(double)countOne / students * 100:f2}%");
            Console.WriteLine($"Average: {allGrades/students:f2}");
        }
    }
}
