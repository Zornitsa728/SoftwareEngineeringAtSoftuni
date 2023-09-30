Predicate<string> uppercase = t => char.IsUpper(t[0]);

string[] text = Console.ReadLine()
    .Split(' ',StringSplitOptions.RemoveEmptyEntries)
    .Where(x => uppercase(x)) 
    .ToArray();

Console.WriteLine(string.Join(Environment.NewLine,text));