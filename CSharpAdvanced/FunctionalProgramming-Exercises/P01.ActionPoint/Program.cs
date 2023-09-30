string[] names = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

Action<string> action = x => Console.WriteLine(x);

foreach (string name in names)
{
    action(name);
}
