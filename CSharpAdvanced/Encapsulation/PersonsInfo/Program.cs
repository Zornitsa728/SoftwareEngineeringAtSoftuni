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

                try
                {
                    Person person = new Person(firstName, lastName, age, salary);
                    people.Add(person);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //decimal percentage = decimal.Parse(Console.ReadLine());
            Team team = new Team("SoftUni");

            foreach (var person in people) 
            {
                team.AddPlayer(person);
                //person.IncreaseSalary(percentage);
                //Console.WriteLine(person);
            }

            Console.WriteLine($"First team has {team.FirstTeam.Count} players.");
            Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players.");
        }
    }
}