using System;
using System.Collections.Generic;
using System.Linq;

List<string> guests = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToList();

string cmd = string.Empty;

Predicate<string> doubleOrRemove = operation => operation == "Double";

static Predicate<string> GetPredicate(string[] cmdArgs)
{
    if (cmdArgs[1] == "StartsWith")
    {
        return g => g.StartsWith(cmdArgs[2]);
    }
    else if (cmdArgs[1] == "EndsWith")
    {
        return g => g.EndsWith(cmdArgs[2]);
    }
    else
    {
        return g => g.Length == int.Parse(cmdArgs[2]);
    }

};

while ((cmd = Console.ReadLine()) != "Party!")
{
    string[] cmdArgs = cmd
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

    string operation = cmdArgs[0];

    Predicate<string> filterGuests = GetPredicate(cmdArgs);

    if (doubleOrRemove(operation))
    {
        List<string> newGuestList = guests.Where(g => filterGuests(g)).ToList();

        foreach (string newGuest in newGuestList)
        {
            int index = guests.IndexOf(newGuest);
            guests.Insert(index, newGuest);
        }
    }
    else
    {
        guests.RemoveAll(filterGuests);
    }

}

Action<List<string>> printResult = guests =>
{
    if (guests.Count > 0)
    {
        Console.WriteLine($"{string.Join(", ", guests)} are going to the party!");
    }
    else
    {
        Console.WriteLine("Nobody is going to the party!");
    }
};

printResult(guests);