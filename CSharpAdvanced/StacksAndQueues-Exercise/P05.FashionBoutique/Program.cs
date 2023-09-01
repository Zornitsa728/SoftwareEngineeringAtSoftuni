using System;
using System.Collections.Generic;
using System.Linq;

Stack<int> clothes = new
    (Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));
int clothesCount = clothes.Count();
int rackValue = int.Parse(Console.ReadLine());
int rackStartCapacity = rackValue;
int usedRacks = 1;

while (clothes.Any())
{
    if (rackValue >= clothes.Peek())
    {
        rackValue -= clothes.Pop();
    }
    else
    {
        usedRacks++;
        rackValue = rackStartCapacity;
    }
}

if (clothesCount != 0)
{
    Console.WriteLine(usedRacks);
}
else
{
    Console.WriteLine(0);
}

