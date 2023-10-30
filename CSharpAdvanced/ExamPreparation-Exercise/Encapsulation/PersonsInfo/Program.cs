namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();

            for (int i = 0; i < lines; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries);

                string firstName = tokens[0];
                string lastName = tokens[1];
                int age = int.Parse(tokens[2]);
                decimal salary = decimal.Parse(tokens[3]);

                people.Add(new Person(firstName, lastName, age, salary));
            }

            decimal percentage = decimal.Parse(Console.ReadLine());

            foreach (var person in people) 
            {
                person.IncreaseSalary(percentage);
                Console.WriteLine(person);
            }
        }
    }
}