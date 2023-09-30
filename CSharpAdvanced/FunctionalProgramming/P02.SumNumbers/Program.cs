int[] numbers = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(Parse)
    .ToArray();

Console.WriteLine(numbers.Length);
Console.WriteLine(numbers.Sum());

int Parse(string number)
{
    return int.Parse(number);
}
