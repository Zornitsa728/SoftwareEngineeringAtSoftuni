using System;

HashSet<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToHashSet();

Func<HashSet<int>, int> findSmallestNum = n =>
{
    int value = int.MaxValue;
    
    foreach (var number in numbers)
    {
        if (number < value)
        {
            value = number;
        }
    }

    return value;
};

Console.WriteLine(findSmallestNum(numbers));

