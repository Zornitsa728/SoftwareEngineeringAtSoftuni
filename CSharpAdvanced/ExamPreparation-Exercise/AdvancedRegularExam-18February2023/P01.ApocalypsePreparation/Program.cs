Queue<int> textiles = new(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

Stack<int> medicaments = new(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

Dictionary<string, int> items = new();

while (textiles.Any() && medicaments.Any())
{
    int textileValue = textiles.Dequeue();
    int medValue = medicaments.Pop();
    int result = textileValue + medValue;

    if (result == 30)
    {
        if (!items.ContainsKey("Patch"))
        {
            items.Add("Patch", 0);
        }

        items["Patch"]++;
    }
    else if (result == 40)
    {
        if (!items.ContainsKey("Bandage"))
        {
            items.Add("Bandage", 0);
        }

        items["Bandage"]++;
    }
    else if (result >= 100)
    {
        if (!items.ContainsKey("MedKit"))
        {
            items.Add("MedKit", 0);
        }

        items["MedKit"]++;

        if (result > 100)
        {
            result -= 100;

            if (medicaments.Any())
            {
                int nextEl = medicaments.Pop();
                medicaments.Push(nextEl + result);
                continue;
            }

            medicaments.Push(result);
        }
    }
    else
    {
        medicaments.Push(medValue + 10);
    }
}

if (!textiles.Any() && !medicaments.Any())
{
    Console.WriteLine("Textiles and medicaments are both empty.");
}
else if (!textiles.Any())
{
    Console.WriteLine("Textiles are empty.");
}
else if (!medicaments.Any())
{
    Console.WriteLine("Medicaments are empty.");
}

foreach (var item in items.OrderByDescending(i => i.Value).ThenBy(i => i.Key))
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}

if (textiles.Any())
{
    Console.WriteLine($"Textiles left: {string.Join(", ", textiles)}");
}

if (medicaments.Any())
{
    Console.WriteLine($"Medicaments left: {string.Join(", ", medicaments)}");
}
