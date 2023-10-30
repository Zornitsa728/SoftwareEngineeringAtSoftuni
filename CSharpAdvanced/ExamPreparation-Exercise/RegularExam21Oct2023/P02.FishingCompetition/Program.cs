using System.Runtime.CompilerServices;

int size = int.Parse(Console.ReadLine());

char[,] fishingArea = new char[size, size];
int currRow = 0;
int currCol = 0;

for (int row = 0; row < fishingArea.GetLength(0); row++)
{
    string newRow = Console.ReadLine();

    for (int col = 0; col < fishingArea.GetLength(1); col++)
    {
        fishingArea[row, col] = newRow[col];

        if (fishingArea[row,col] == 'S')
        {
            currRow = row;
            currCol = col;
            fishingArea[row, col] = '-';
        }
    }
}

string cmd = string.Empty;
int caughtFish = 0;
bool sink = false;

while ((cmd = Console.ReadLine()) != "collect the nets")
{
    if(!IsShipLeavingTheArea(fishingArea, ref currRow, ref currCol, cmd))
    {
        ChangeDirection(fishingArea, ref currRow, ref currCol, cmd);
    }

    if (char.IsDigit(fishingArea[currRow,currCol]))
    {
        caughtFish += int.Parse(fishingArea[currRow, currCol].ToString());
        fishingArea[currRow, currCol] = '-';
    }
    else if (fishingArea[currRow, currCol] == 'W')
    {
        caughtFish = 0;
        Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{currRow},{currCol}]");
        sink = true;
        break;
    }
}

if (caughtFish >= 20)
{
    Console.WriteLine("Success! You managed to reach the quota!");
}
else if (caughtFish < 20 && sink == false)
{
    Console.WriteLine($"You didn't catch enough fish and didn't reach the quota! You need {20 - caughtFish} tons of fish more.");
}

if (caughtFish > 0)
{
    Console.WriteLine($"Amount of fish caught: {caughtFish} tons.");
}

if (!sink)
{
    fishingArea[currRow, currCol] = 'S';

    for (int row = 0; row < fishingArea.GetLength(0); row++)
    {
        for (int col = 0; col < fishingArea.GetLength(1); col++)
        {
            Console.Write(fishingArea[row, col]);
        }

        Console.WriteLine();
    }
}
static void ChangeDirection(char[,] fishingArea, ref int currRow, ref int currCol, string cmd)
{
    switch (cmd)
    {
        case "up":
            currRow--;
            break;
        case "down":
            currRow++;
            break;
        case "left":
            currCol--;
            break;
        case "right":
           currCol++;
            break;
    }
}

static bool IsShipLeavingTheArea(char[,] fishingArea, ref int currRow, ref int currCol, string cmd)
{
    switch (cmd)
    {
        case "up":
            if (currRow - 1 < 0)
            {
                currRow = fishingArea.GetLength(0) - 1;
                return true;
            }
            break;
        case "down":
            if (currRow + 1 >= fishingArea.GetLength(0))
            {
                currRow = 0;
                return true;
            }
            break;
        case "left":
            if (currCol - 1 < 0)
            {
                currCol = fishingArea.GetLength(1) - 1;
                return true;
            }
            break;
        case "right":
            if (currCol + 1 >= fishingArea.GetLength(1))
            {
                currCol = 0;
                return true;
            }
            break;
    }

    return false;
}