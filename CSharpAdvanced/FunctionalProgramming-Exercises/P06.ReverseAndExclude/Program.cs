List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
int divider = int.Parse(Console.ReadLine());

Func<List<int>, Predicate<int>, List<int>> removeDivisibleNumbers = (numbers, match) =>
{
    List<int> result = new List<int>();

    foreach (var number in numbers)
    {
        if (match(number))
        {
            result.Add(number);
        }
    }

    return result;
};

Func<List<int>, List<int>> reverse = numbers =>
{
    List<int> result = new List<int>();

    for (int currNum = numbers.Count - 1; currNum >= 0; currNum--)
    {
        result.Add(numbers[currNum]);
    }

    return result;
};


numbers = removeDivisibleNumbers(numbers, n => n % divider != 0);
numbers = reverse(numbers);

Console.WriteLine(string.Join(" ", numbers));
