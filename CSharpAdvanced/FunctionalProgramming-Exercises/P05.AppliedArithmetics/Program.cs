using System.Runtime.InteropServices;

List<int> numbers = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();

string cmd = string.Empty;
Action<List<int>> print = numbers => Console.WriteLine(string.Join(" ", numbers));

Func<int, string, int> operation = (num, cmd) =>
{
    if (cmd == "add")
    {
        return num + 1;
    }
    else if (cmd == "multiply")
    {
        return num * 2;
    }
    else if (cmd == "subtract")
    {
        return num - 1;
    }

    return 0;
};

while ((cmd = Console.ReadLine()) != "end")
{
    if (cmd == "print")
    {
        print(numbers);
    }
    else
    {
        numbers = numbers.Select(x => operation(x, cmd)).ToList();
    }
}

