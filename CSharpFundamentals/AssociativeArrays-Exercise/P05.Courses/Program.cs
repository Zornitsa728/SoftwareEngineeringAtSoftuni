namespace P05.Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            CoursesValidation(courses);
            Printresult(courses);
        }

        static void Printresult(Dictionary<string, List<string>> courses)
        {
            foreach (var kvp in courses)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");
                
                for (int i = 0; i < kvp.Value.Count; i++)
                {
                    Console.WriteLine($"-- {kvp.Value[i]}");
                }
            }
        }
        private static void CoursesValidation(Dictionary<string, List<string>> courses)
        {
            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] cmd = input.Split(" : ");
                string courseName = cmd[0];
                string student = cmd[1];

                if (DoCourseExist(courses, courseName))
                {
                    courses[courseName].Add(student);
                    continue;
                }

                courses.Add(courseName, new List<string>());
                courses[courseName].Add(student);
            }
        }

        static bool DoCourseExist(Dictionary<string, List<string>> courses, string courseName)
        {
            if (courses.ContainsKey(courseName))
            {
                return true;
            }

            return false;
        }
    }
}