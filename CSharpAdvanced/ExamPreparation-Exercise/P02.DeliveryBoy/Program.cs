int[] dimensions = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

char[,] neighborhood = new char[dimensions[0], dimensions[1]];
int startRow = 0;
int startCol = 0;

for (int row = 0; row < neighborhood.GetLength(0); row++)
{
    string input = Console.ReadLine();

    for (int col = 0; col < neighborhood.GetLength(1); col++)
    {
        neighborhood[row, col] = input[col];

        if (neighborhood[row, col] == 'B')
        {
            startRow = row;
            startCol = col;
        }
    }
}

int currRow = startRow;
int currCol = startCol;

while (true)
{
    string cmd = Console.ReadLine();

    if (!IsBoyInTheField(neighborhood, cmd, currRow, currCol))
    {
        Console.WriteLine("The delivery is late. Order is canceled.");
        neighborhood[startRow, startCol] = ' ';
        break;
    }

    if (cmd == "up")
    {
        currRow--;

        if (neighborhood[currRow,currCol] == 'A')
        {
            neighborhood[currRow, currCol] = 'P';
            Console.WriteLine("Pizza is delivered on time! Next order...");
            break;
        }
        else if (neighborhood[currRow, currCol] == '*')
        {
            currRow++;
            continue;
        }
        else if (neighborhood[currRow, currCol] == 'P')
        {
            neighborhood[currRow, currCol] = 'R';
            Console.WriteLine("Pizza is collected. 10 minutes for delivery.");
        }
        else if (neighborhood[currRow, currCol] == '-')
        {
            neighborhood[currRow, currCol] = '.';
        }
    }
    else if (cmd == "down")
    {
        currRow++;

        if (neighborhood[currRow, currCol] == 'A')
        {
            neighborhood[currRow, currCol] = 'P';
            Console.WriteLine("Pizza is delivered on time! Next order...");
            break;
        }
        else if (neighborhood[currRow, currCol] == '*')
        {
            currRow--;
            continue;
        }
        else if (neighborhood[currRow, currCol] == 'P')
        {
            neighborhood[currRow, currCol] = 'R';
            Console.WriteLine("Pizza is collected. 10 minutes for delivery.");
        }
        else if (neighborhood[currRow, currCol] == '-')
        {
            neighborhood[currRow, currCol] = '.';
        }
    }
    else if (cmd == "left")
    {
       currCol--;

        if (neighborhood[currRow, currCol] == 'A')
        {
            neighborhood[currRow, currCol] = 'P';
            Console.WriteLine("Pizza is delivered on time! Next order...");
            break;
        }
        else if (neighborhood[currRow, currCol] == '*')
        {
            currCol++;
            continue;
        }
        else if (neighborhood[currRow, currCol] == 'P')
        {
            neighborhood[currRow, currCol] = 'R';
            Console.WriteLine("Pizza is collected. 10 minutes for delivery.");
        }
        else if (neighborhood[currRow, currCol] == '-')
        {
            neighborhood[currRow, currCol] = '.';
        }
    }
    else if (cmd == "right")
    {
        currCol++;

        if (neighborhood[currRow, currCol] == 'A')
        {
            neighborhood[currRow, currCol] = 'P';
            Console.WriteLine("Pizza is delivered on time! Next order...");
            break;
        }
        else if (neighborhood[currRow, currCol] == '*')
        {
            currCol--;
            continue;
        }
        else if (neighborhood[currRow, currCol] == 'P')
        {
            neighborhood[currRow, currCol] = 'R';
            Console.WriteLine("Pizza is collected. 10 minutes for delivery.");
        }
        else if (neighborhood[currRow, currCol] == '-')
        {
            neighborhood[currRow, currCol] = '.';
        }
    }
}

for (int rows = 0; rows < neighborhood.GetLength(0); rows++)
{
    for (int cols = 0; cols < neighborhood.GetLength(1); cols++)
    {
        Console.Write(neighborhood[rows,cols]);
    }

    Console.WriteLine();
}
static bool IsBoyInTheField(char[,] neighborhood, string cmd, int currRow, int currCol)
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
            if (currRow + 1 < neighborhood.GetLength(0))
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
            if (currCol + 1 < neighborhood.GetLength(1))
            {
                return true;
            }
            break;
    }

    return false;
}