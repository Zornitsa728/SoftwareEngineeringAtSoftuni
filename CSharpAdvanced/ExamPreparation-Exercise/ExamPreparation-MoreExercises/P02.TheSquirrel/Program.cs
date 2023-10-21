int size = int.Parse(Console.ReadLine());

char[,] field = new char[size, size];
int squirrelRow = 0;
int squirrelCol = 0;

string[] cmds = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

for (int row = 0; row < field.GetLength(0); row++)
{
    string input = Console.ReadLine();

    for (int col = 0; col < field.GetLength(1); col++)
    {
        field[row, col] = input[col];

        if (field[row, col] == 's')
        {
            squirrelRow = row;
            squirrelCol = col;
            field[row, col] = '*';
        }
    }
}

int hazelnutsCount = 0;

for (int i = 0; i < cmds.Length; i++)
{
    if (!IsSquirrelInTheField(field, cmds[i],squirrelRow, squirrelCol))
    {
        Console.WriteLine("The squirrel is out of the field.");
        break;
    }

    if (cmds[i] == "up")
    {
        squirrelRow--;

        if (field[squirrelRow, squirrelCol] == 'h')
        {
            hazelnutsCount++;

            if (hazelnutsCount == 3)
            {
                field[squirrelRow, squirrelCol] = 's';
                Console.WriteLine("Good job! You have collected all hazelnuts!");
                break;
            }

            field[squirrelRow, squirrelCol] = '*';
        }
        else if (field[squirrelRow, squirrelCol] == 't')
        {
            Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
            break;
        }
    }
    else if (cmds[i] == "down")
    {
        squirrelRow++;

        if (field[squirrelRow, squirrelCol] == 'h')
        {
            hazelnutsCount++;

            if (hazelnutsCount == 3)
            {
                field[squirrelRow, squirrelCol] = 's';
                Console.WriteLine("Good job! You have collected all hazelnuts!");
                break;
            }

            field[squirrelRow, squirrelCol] = '*';
        }
        else if (field[squirrelRow, squirrelCol] == 't')
        {
            Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
            break;
        }
    }
    else if (cmds[i] == "left")
    {
        squirrelCol--;

        if (field[squirrelRow, squirrelCol] == 'h')
        {
            hazelnutsCount++;

            if (hazelnutsCount == 3)
            {
                field[squirrelRow, squirrelCol] = 's';
                Console.WriteLine("Good job! You have collected all hazelnuts!");
                break;
            }

            field[squirrelRow, squirrelCol] = '*';
        }
        else if (field[squirrelRow, squirrelCol] == 't')
        {
            Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
            break;
        }
    }
    else if (cmds[i] == "right")
    {
        squirrelCol++;

        if (field[squirrelRow, squirrelCol] == 'h')
        {
            hazelnutsCount++;

            if (hazelnutsCount == 3)
            {
                field[squirrelRow, squirrelCol] = 's';
                Console.WriteLine("Good job! You have collected all hazelnuts!");
                break;
            }

            field[squirrelRow, squirrelCol] = '*';
        }
        else if (field[squirrelRow, squirrelCol] == 't')
        {
            Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
            break;
        }
    }

    if (i == cmds.Length - 1 && hazelnutsCount < 3)
    {
        Console.WriteLine("There are more hazelnuts to collect.");
        break;
    }
}

Console.WriteLine($"Hazelnuts collected: {hazelnutsCount}");

static bool IsSquirrelInTheField(char[,] field, string cmd, int squirrelRow, int squirrelCol)
{
    switch (cmd)
    {
        case "up":
            if (squirrelRow - 1 >= 0)
            {
                return true;
            }
            break;
        case "down":
            if (squirrelRow + 1 < field.GetLength(0))
            {
                return true;
            }
            break;
        case "left":
            if (squirrelCol - 1 >= 0)
            {
                return true;
            }
            break;
        case "right":
            if (squirrelCol + 1 < field.GetLength(1))
            {
                return true;
            }
            break;
    }

    return false;
}