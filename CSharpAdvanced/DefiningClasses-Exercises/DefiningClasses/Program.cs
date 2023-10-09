using DefiningClasses;
using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main(string[] args)
    {
        int peopleCount = int.Parse(Console.ReadLine());
        Family family = new();

        for (int currPerson = 0; currPerson < peopleCount; currPerson++)
        {
            string[] personProps = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Person person = new Person(personProps[0], int.Parse(personProps[1]));

            family.AddMembers(person);
        }

        List<Person> people = family.GetOldestMembers();

        foreach (var person in people.OrderBy(x => x.Name))
        {
            Console.WriteLine($"{person.Name} - {person.Age}");
        }
        
    }
}
