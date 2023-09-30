namespace P02.AverageStudentGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countStudents = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

            for (int currStudent = 0; currStudent < countStudents; currStudent++)
            {
                string[] studentInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string studentName = studentInfo[0];
                decimal studentGrade = decimal.Parse(studentInfo[1]);

                if (!students.ContainsKey(studentName))
                {
                    students.Add(studentName, new List<decimal>());
                }

                students[studentName].Add(studentGrade);
            }

            foreach (var kvp in students)
            {
                Console.Write($"{kvp.Key} -> ");

                foreach (var grade in kvp.Value)
                {
                    Console.Write($"{grade:f2} ");
                }

                Console.WriteLine($"(avg: {kvp.Value.Average():f2})");
            }
        }
    }
}