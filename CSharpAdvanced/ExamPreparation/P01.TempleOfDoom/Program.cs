
using System;
Queue<int> tools = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

Stack<int> substances = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

List<int> challenges = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

while (tools.Any() && substances.Any() && challenges.Any())
{
    int value = tools.Peek() * substances.Peek();

    if (challenges.Any(x => x == value))
    {
        tools.Dequeue();
        substances.Pop();
        challenges.Remove(value);
    }
    else
    {
        int currTool = tools.Dequeue() + 1;
        tools.Enqueue(currTool);
        int currSubst = substances.Pop() - 1;

        if (currSubst > 0)
        {
            substances.Push(currSubst);
        }
    }
}

if (challenges.Any())
{
    Console.WriteLine("Harry is lost in the temple. Oblivion awaits him.");
}
else
{
    Console.WriteLine("Harry found an ostracon, which is dated to the 6th century BCE.");
}

if (tools.Any())
{
    Console.WriteLine($"Tools: {string.Join(", ",tools)}");
}

if (substances.Any())
{
    Console.WriteLine($"Substances: {string.Join(", ", substances)}");
}

if (challenges.Any())
{
    Console.WriteLine($"Challenges: {string.Join(", ", challenges)}");
}