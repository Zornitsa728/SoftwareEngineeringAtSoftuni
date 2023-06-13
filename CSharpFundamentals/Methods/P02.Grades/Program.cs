namespace P02.Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            gradeDefinition(grade);
        }

        static void gradeDefinition(double grade)
        {
            string definition = string.Empty;

            if (grade >=2 && grade < 3)
            {
                definition = "Fail";
            }
            else if (grade < 3.5)
            {
                definition = "Poor";
            }
            else if (grade < 4.5)
            {
                definition = "Good";
            }
            else if (grade < 5.5)
            {
                definition = "Very good";
            }
            else if(grade <= 6)
            {
                definition = "Excellent";
            }

            Console.WriteLine(definition);
        }
    }
}