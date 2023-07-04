namespace P04.Students
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
                int Age = int.Parse(studentInformation[2]);
                string homeTown = studentInformation[3];
                Student student = new Student(firstName, lastName, Age, homeTown);
                students.Add(student);
            }

            string cityName = Console.ReadLine();
            List<Student> filteredStudents = students.Where(s => s.HomeTown == cityName).ToList();
            foreach (Student student in filteredStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }

    public class Student
    {
        public Student(string firstName, string lastName, int age, string homeTown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string HomeTown { get; set; }
    }
}