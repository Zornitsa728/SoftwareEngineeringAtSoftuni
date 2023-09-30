using System;
using System.Collections.Generic;
using System.Linq;

int rangeEnd = int.Parse(Console.ReadLine());

HashSet<int> dividers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToHashSet();

List<int> numbers = Enumerable.Range(1, rangeEnd).ToList();

List<Predicate<int>> predicates = new();

foreach (var divider in dividers)
{
    predicates.Add(n => n % divider == 0);
}

//Predicate<int> match = n =>
//{
//    foreach (var divider in dividers)
//    {
//        if (n % divider != 0)
//        {
//            return false;
//        }
//    }

//    return true;
//};

Func<List<int>, List<Predicate<int>>, List<int>> findDivisibleNumbers = (numbers, predicates) =>
{
    List<int> result = new();

    foreach (var number in numbers)
    {
        bool isDivisible = true;

        foreach (var predicate in predicates)
        {
            if (!predicate(number))
            {
                isDivisible = false;
                break;
            }
        }

        if (isDivisible)
        {
            result.Add(number);
        }
    }

    return result;
};

Action<List<int>> printResult = n => Console.WriteLine(string.Join(" ", n));

numbers = findDivisibleNumbers(numbers, predicates);

printResult(numbers);