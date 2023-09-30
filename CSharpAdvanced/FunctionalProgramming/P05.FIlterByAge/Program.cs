int n = int.Parse(Console.ReadLine());
List<Person> people = new();

for (int i = 0; i < n; i++)
{
    string[] data = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
    string name = data[0];
    int age = int.Parse(data[1]);

    people.Add(new Person { Name = name, Age = age });
}

string ageCondition = Console.ReadLine();
int ageRange = int.Parse(Console.ReadLine());

Func<Person, int, bool> filter = AgeFilter(ageCondition);
people = people.Where(p => filter(p, ageRange)).ToList();

Action<Person> formatter = GetFormatter(Console.ReadLine());

foreach (Person person in people)
{
    formatter(person);
}
Action<Person> GetFormatter(string type)
{
    if (type == "name age")
    {
        return p => Console.WriteLine($"{p.Name} - {p.Age}");
    }
    else if (type == "name")
    {
        return p => Console.WriteLine($"{p.Name}");
    }
    else
    {
        return p => Console.WriteLine($"{p.Age}");
    }

    return null;
}

Func<Person, int, bool> AgeFilter(string ageCondition)
{
    if (ageCondition == "younger")
    {
        return (p, ageRange) => p.Age < ageRange;
    }
    else
    {
        return (p, ageRange) => p.Age >= ageRange;
    }

    return null;
}
class Person
{
    public string Name { get; set; }

    public int Age { get; set; }
}
