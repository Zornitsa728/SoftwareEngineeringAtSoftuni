int bulletPrice = int.Parse(Console.ReadLine());
int gunBarrelSize = int.Parse(Console.ReadLine());
Stack<int> bullets = new(Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray()
                );
Queue<int> locks = new(Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray()
                );
int intelligenceValue = int.Parse(Console.ReadLine());
int shotBullets = 0;
int countBarrel = 0;

while (bullets.Any() && locks.Any())
{
    int currBullet = bullets.Pop();
    int currLock = locks.Peek();
    shotBullets++;
    countBarrel++;

    if (currBullet <= currLock)
    {
        Console.WriteLine("Bang!");
        locks.Dequeue();
    }
    else
    {
        Console.WriteLine("Ping!");
    }

    if (gunBarrelSize == countBarrel && bullets.Any())
    {
        countBarrel = 0;
        Console.WriteLine("Reloading!");
    }
}

if (locks.Any())
{
    Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
}
else
{
    int moneyEarned = intelligenceValue - (shotBullets * bulletPrice);
    Console.WriteLine($"{bullets.Count} bullets left. Earned ${moneyEarned}");
}