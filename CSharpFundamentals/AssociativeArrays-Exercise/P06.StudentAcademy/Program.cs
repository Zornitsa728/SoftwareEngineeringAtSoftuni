namespace P06.StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> studentGrades = new Dictionary<string, List<double>>();

            TrackAllGrades(studentGrades);

            Dictionary<string, double> bestStudents = new Dictionary<string, double>();
            SaveStudentsWithVerryGoodGrades(studentGrades, bestStudents);

            PrintResult(bestStudents);
        }

        static void PrintResult(Dictionary<string, double> bestStudents)
        {
            foreach (var kvp in bestStudents)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value:f2}");
            }
        }

        static void SaveStudentsWithVerryGoodGrades(Dictionary<string, List<double>> studentGrades, Dictionary<string, double> bestStudents)
        {
            foreach (var kvp in studentGrades)
            {
                double sum = 0;

                for (int i = 0; i < kvp.Value.Count; i++)
                {
                    sum += kvp.Value[i]; // calculating average grade
                }

                sum /= kvp.Value.Count;

                if (sum >= 4.50) // saving students with grades above 4.5 (including)
                {
                    bestStudents.Add(kvp.Key, sum);
                }
            }
        }
        private static void TrackAllGrades(Dictionary<string, List<double>> studentGrades)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (IsStudentExist(studentGrades, studentName))
                {
                    studentGrades[studentName].Add(grade);
                    continue;
                }

                studentGrades.Add(studentName, new List<double>());
                studentGrades[studentName].Add(grade);
            }
        }

        static bool IsStudentExist(Dictionary<string, List<double>> studentGrades, string studentName)
        {
            if (studentGrades.ContainsKey(studentName))
            {
                return true;
            }

            return false;
        }
    }
}