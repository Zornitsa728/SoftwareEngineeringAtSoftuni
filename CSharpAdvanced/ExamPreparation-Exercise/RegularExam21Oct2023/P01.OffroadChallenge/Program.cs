Stack<int> fuel = new(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

Queue<int> consumption = new(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

Queue<int> neededFuel = new(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

int counter = 0;

while (fuel.Any() && consumption.Any() && neededFuel.Any())
{
    int currFuel = fuel.Pop();
    int currConsumption = consumption.Dequeue();

    if (neededFuel.Dequeue() <= currFuel - currConsumption)
    {
        Console.WriteLine($"John has reached: Altitude {counter++}");
    }
    else
    {
        Console.WriteLine($"John did not reach: Altitude {counter}");
        break;
    }
}

if (counter > 1 && neededFuel.Any())
{
    Console.WriteLine("John failed to reach the top.");

    string[] altitudes = new string[counter - 1];

    for (int i = 0; i < counter - 1; i++)
    {
        altitudes[i] = ($"Altitude {i + 1}");
    }

    Console.WriteLine($"Reached altitudes: {string.Join(", ",altitudes)}");
}

if (counter == 1)
{
    Console.WriteLine("John failed to reach the top.");
    Console.WriteLine("John didn't reach any altitude.");
}

if (!fuel.Any() && !consumption.Any() && !neededFuel.Any())
{
    Console.WriteLine("John has reached all the altitudes and managed to reach the top!");
}