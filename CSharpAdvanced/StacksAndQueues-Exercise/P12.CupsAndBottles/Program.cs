Queue<int> cups = new(Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray());

Stack<int> bottles = new(Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray());
int wastedWater = 0;

while (cups.Any() && bottles.Any())
{
    int currCup = cups.Dequeue();
    currCup -= bottles.Pop();

    if (currCup < 0)
    {
        wastedWater += currCup;
    }
    else if (currCup > 0)
    {
        while (currCup > 0)
        {
            currCup -= bottles.Pop();
        }

        wastedWater += currCup;
    }
}

if (bottles.Any())
{
    Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
}
else
{
    Console.WriteLine($"Cups: {string.Join(" ", cups)}");
}

Console.WriteLine($"Wasted litters of water: {Math.Abs(wastedWater)}");