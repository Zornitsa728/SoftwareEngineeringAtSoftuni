using System;
using System.Collections.Generic;
using System.Linq;

int number = int.Parse(Console.ReadLine());

List<string> names = Console.ReadLine()
    .Split(' ',StringSplitOptions.RemoveEmptyEntries)
    .ToList();

Func<string, int, bool> checkSum = (name, number) =>
{
    int sum = 0;

    for (int i = 0; i < name.Length; i++)
    {
        sum += name[i];
    }

    if (sum >= number)
    {
        return true;
    }

    return false;
};

Func<int, List<string>, Func<string,int,bool>, string> getFirstName = (number, names, checkSum) =>
{
    foreach (var name in names)
    {
        if (checkSum(name, number))
        {
            return name;
        }
    }

    return null;
};

Console.WriteLine(getFirstName(number,names,checkSum));