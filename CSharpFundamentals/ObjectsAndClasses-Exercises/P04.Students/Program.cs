namespace P04.Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 1; i <= studentsCount; i++)
            {
                string[] studentsInfo = Console.ReadLine().Split();
                string firstname = studentsInfo[0];
                string secondname = studentsInfo[1];
                double grade = double.Parse(studentsInfo[2]);
                Student student = new Student(firstname, secondname, grade);
                students.Add(student);
            }

            foreach (Student student in students.OrderByDescending(x => x.Grade))
            {
                Console.WriteLine($"{student.FirstName} {student.SecondName}: {student.Grade:f2}");
            }
        }
    }

    public class Student
    {
        public Student(string firstName, string secondName, double grade)
        {
            FirstName = firstName;
            SecondName = secondName;
            Grade = grade;
        }

        public string FirstName { get; set; }
        public string SecondName { get; set; }

        public double Grade { get; set; }
    }

}