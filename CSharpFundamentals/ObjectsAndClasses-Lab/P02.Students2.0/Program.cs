namespace P05.Students2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<Student> students = new List<Student>();

            while ((input = Console.ReadLine()) != "end")
            {
                string[] studentInformation = input.Split();
                string firstName = studentInformation[0];
                string lastName = studentInformation[1];
                int age = int.Parse(studentInformation[2]);
                string homeTown = studentInformation[3];
                Student student = students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);
                if (student == null)
                {
                    students.Add(new Student(firstName, lastName, age, homeTown));
                }
                else
                {
                    student.Age = age;
                    student.HomeTown = homeTown;
                }
            }

            string cityName = Console.ReadLine();
            List<Student> filteredStudents = students.Where(s => s.HomeTown == cityName).ToList();
            foreach (Student student in filteredStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }
}
