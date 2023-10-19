namespace ComparingObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] tokens = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Person person = new Person(tokens[0], int.Parse(tokens[1]), tokens[2]);

                people.Add(person);
            }

            Person personToCompare = people[int.Parse(Console.ReadLine())-1];
            int countMatches = 0;

            foreach (var person in people)
            {
                if (person.CompareTo(personToCompare) == 0)
                {
                    countMatches++;
                }
            }

            if (countMatches == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{countMatches} {people.Count - countMatches} {people.Count}");
            }
        }
    }
}