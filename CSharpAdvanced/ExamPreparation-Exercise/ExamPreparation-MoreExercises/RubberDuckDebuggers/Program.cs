Queue<int> programersTime = new(Console.ReadLine()
				.Split(" ",StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse));

Stack<int> numberOfTasks = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

Dictionary<string, int> ducks = new ();
ducks.Add("Darth Vader Ducky", 0);
ducks.Add("Thor Ducky", 0);
ducks.Add("Big Blue Rubber Ducky", 0);
ducks.Add("Small Yellow Rubber Ducky", 0);

while (programersTime.Any() && numberOfTasks.Any())
{
    int timeValue = programersTime.Dequeue();
    int tasks = numberOfTasks.Pop();
    int result = timeValue * tasks;

    if (result <= 60)
    {
        ducks["Darth Vader Ducky"]++;
    }
    else if (result <= 120)
    {
        ducks["Thor Ducky"]++;
    }
    else if(result <= 180)
    {
        ducks["Big Blue Rubber Ducky"]++;
    }
    else if (result <= 240)
    {
        ducks["Small Yellow Rubber Ducky"]++;
    }
    else
    {
        numberOfTasks.Push(tasks - 2);
        programersTime.Enqueue(timeValue);
    }
}

Console.WriteLine("Congratulations, all tasks have been completed! Rubber ducks rewarded:");

foreach (var duck in ducks)
{
    Console.WriteLine($"{duck.Key}: {duck.Value}");
}