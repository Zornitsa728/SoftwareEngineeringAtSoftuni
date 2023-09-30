using System;

int nameLength = int.Parse(Console.ReadLine());

string[] names = Console.ReadLine()
    .Split(" ",StringSplitOptions.RemoveEmptyEntries);

Action<string[], Predicate<string>> printValidNames = (names, match) =>
{
    foreach (string name in names)
    {
        if (match(name))
        {
            Console.WriteLine(name);
        }
    }
};

printValidNames(names, n => n.Length <= nameLength);