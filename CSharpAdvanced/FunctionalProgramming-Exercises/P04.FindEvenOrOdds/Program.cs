int[] range = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
string cmd = Console.ReadLine();

int start = range[0];
int end = range[1];

Func<int, int, List<int>> rangeList = (star, end) =>
{
    List<int> result = new List<int>();

    for (int i = start; i <= end; i++)
    {
        result.Add(i);
    }

    return result;
};

List<int> numbersInRange = rangeList(start, end);

Predicate<int> filter = number =>
{
    if (cmd == "even")
    {
        return number % 2 == 0;
    }
    else
    {
        return number % 2 != 0;
    }
};

foreach (var number in numbersInRange.Where(x => filter(x)))
{
    Console.Write(number + " ");
}


//Predicate<int> match;

//if (cmd == "even")
//{
//    match = n => n % 2 == 0;
//}
//else
//{
//    match = n => n % 2 != 0;
//}

//foreach (int number in numbersInRange)
//{
//    if (match(number))
//    {
//        Console.Write(number + " ");
//    }
//}