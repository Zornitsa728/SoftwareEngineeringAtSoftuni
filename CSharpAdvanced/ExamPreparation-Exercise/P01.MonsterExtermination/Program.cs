Queue<int> monstersArmories = new(Console.ReadLine()
    .Split(",", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

Stack<int> soldierStrikingImpact = new(Console.ReadLine()
    .Split(",", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

int killedMonsters = 0;

while (monstersArmories.Any() && soldierStrikingImpact.Any())
{
    int monstArmory = monstersArmories.Dequeue();
    int soldierStrike = soldierStrikingImpact.Pop();

    if (soldierStrike >= monstArmory)
    {
        soldierStrike -= monstArmory;
        killedMonsters++;

        if (soldierStrike > 0)
        {
            if (soldierStrikingImpact.Any())
            {
                int addingValue = soldierStrikingImpact.Pop() + soldierStrike;
                soldierStrikingImpact.Push(addingValue);
                continue;
            }

            soldierStrikingImpact.Push(soldierStrike);
        }
    }
    else
    {
        monstArmory -= soldierStrike;
        monstersArmories.Enqueue(monstArmory);
    }
}

if (!monstersArmories.Any())
{
    Console.WriteLine("All monsters have been killed!");
}

if (!soldierStrikingImpact.Any())
{
    Console.WriteLine("The soldier has been defeated.");
}

Console.WriteLine($"Total monsters killed: {killedMonsters}");
