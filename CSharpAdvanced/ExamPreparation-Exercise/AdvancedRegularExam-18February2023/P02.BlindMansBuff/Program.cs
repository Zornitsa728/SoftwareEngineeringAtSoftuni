int[] dimensions = Console.ReadLine()
   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
   .Select(int.Parse)
   .ToArray();

char[,] playground = new char[dimensions[0], dimensions[1]];
int currRow = 0;
int currCol = 0;

for (int row = 0; row < playground.GetLength(0); row++)
{
    char[] newRow = Console.ReadLine()
        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
        .Select(char.Parse)
        .ToArray();

    for (int col = 0; col < playground.GetLength(1); col++)
    {
        playground[row, col] = newRow[col];

        if (playground[row, col] == 'B')
        {
            currRow = row;
            currCol = col;
            playground[row, col] = '-';
        }
    }
}

string cmd;
int touchedOpponents = 0;
int movesMade = 0;

while ((cmd = Console.ReadLine()) != "Finish")
{
    if (!IsPlayerInTheField(playground, cmd, currRow, currCol))
    {
        continue;
    }

    if (IsThereAnObstacle(playground, cmd, currRow, currCol))
    {
        continue;
    }

    ChangePosition(ref currRow, ref currCol, cmd);

    if (playground[currRow, currCol] == 'P')
    {
        movesMade++;
        touchedOpponents++;
        playground[currRow, currCol] = '-';
    }
    else if (playground[currRow, currCol] == '-')
    {
        movesMade++;
    }

    if (touchedOpponents == 3)
    {
        break;
    }
}

playground[currRow, currCol] = 'B';

Console.WriteLine("Game over!");

Console.WriteLine($"Touched opponents: {touchedOpponents} Moves made: {movesMade}");
static bool IsPlayerInTheField(char[,] playground, string cmd, int currRow, int currCol)
{
    switch (cmd)
    {
        case "up":
            if (currRow - 1 >= 0)
            {
                return true;
            }
            break;
        case "down":
            if (currRow + 1 < playground.GetLength(0))
            {
                return true;
            }
            break;
        case "left":
            if (currCol - 1 >= 0)
            {
                return true;
            }
            break;
        case "right":
            if (currCol + 1 < playground.GetLength(1))
            {
                return true;
            }
            break;
    }

    return false;
}

static bool IsThereAnObstacle(char[,] playground, string cmd, int currRow, int currCol)
{
    switch (cmd)
    {
        case "up":
            if (playground[currRow - 1, currCol] == 'O')
            {
                return true;
            }
            break;
        case "down":
            if (playground[currRow + 1, currCol] == 'O')
            {
                return true;
            }
            break;
        case "left":
            if (playground[currRow, currCol - 1] == 'O')
            {
                return true;
            }
            break;
        case "right":
            if (playground[currRow, currCol + 1] == 'O')
            {
                return true;
            }
            break;
    }

    return false;
}

static void ChangePosition(ref int currRow, ref int currCol, string cmd)
{
    if (cmd == "up")
    {
        currRow--;
    }
    else if (cmd == "down")
    {
        currRow++;
    }
    else if (cmd == "left")
    {
        currCol--;
    }
    else if (cmd == "right")
    {
        currCol++;
    }
}
