using System;
using System.Collections.Generic;
using System.Linq;

Dictionary<string, Predicate<string>> filters = new Dictionary<string, Predicate<string>>();


List<string> guests = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

static Predicate<string> FilterOperations(string filterType, string filterValue)
{
    

    switch (filterType)
    {
        case "Starts with":
            return g => g.StartsWith(filterValue);
            break;
        case "Ends with":
            return g => g.EndsWith(filterValue);
            break;
        case "Length":
            return g => g.Length == int.Parse(filterValue);
            break;
        case "Contains":
            return g => g.Contains(filterValue);
            break;
    }

    return null;
}

string input = string.Empty;

while ((input = Console.ReadLine()) != "Print")
{
    string[] tokens = input.
        Split(";", StringSplitOptions.RemoveEmptyEntries);

    string cmd = tokens[0];
    string filterType = tokens[1];
    string filterValue = tokens[2];

    if (cmd == "Add filter")
    {
        filters.Add(filterType + filterValue, FilterOperations(filterType, filterValue));
    }
    else
    {
       filters.Remove(filterType + filterValue);
    }
}

foreach (var filter in filters)
{
    guests.RemoveAll(filter.Value);
}

Console.WriteLine(string.Join(" ", guests));