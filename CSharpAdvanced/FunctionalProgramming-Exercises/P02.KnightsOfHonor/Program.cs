string[] names = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

Action<string[]> appendSir = n =>
{
    foreach (string name in names)
    {
        Console.WriteLine("Sir " + name);
    }
    
};

appendSir(names);
