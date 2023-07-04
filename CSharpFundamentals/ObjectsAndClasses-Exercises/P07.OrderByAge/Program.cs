namespace P07.OrderByAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            GetPersonData(people);
            PrintResult(people);
        }

        static void PrintResult(List<Person> people)
        {
            foreach (Person person in people.OrderBy(p => p.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
        static void GetPersonData(List<Person> people)
        {
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = cmdArgs[0];
                string id = cmdArgs[1];
                int age = int.Parse(cmdArgs[2]);
                Person person = new Person(name, id, age);
                if (people.Any(p => p.ID == id))
                {
                    person.ChangePerson(people, id);
                    continue;
                }

                people.Add(person);
            }
        }
    }

    public class Person
    {
        public Person(string name, string id, int age)
        {
            Name = name;
            Age = age;
            ID = id;
        }
        public string Name { get; set; }

        public string ID { get; set; }

        public int Age { get; set; }

        public void ChangePerson(List<Person> people, string id)
        {
            foreach (Person currPerson in people)
            {
                if (currPerson.ID == id)
                {
                    currPerson.Age = Age;
                    currPerson.Name = Name;
                }
            }
        }
    }
}