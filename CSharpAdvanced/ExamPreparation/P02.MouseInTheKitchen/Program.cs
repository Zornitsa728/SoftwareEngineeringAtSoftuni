int[] size = Console.ReadLine()
				.Split(",",StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();

string[,] cupboard = new string[size[0], size[1]];
int mouseRow = 0;
int mouseCol = 0;
int cheeseCount = 0;

for (int row = 0; row < cupboard.GetLength(0); row++)
{
	string input = Console.ReadLine();

	for (int col = 0; col < cupboard.GetLength(1); col++)
	{
		cupboard[row, col] = input[col].ToString();

		if (cupboard[row, col] == "M")
		{
			mouseRow = row;
			mouseCol = col;
		}

        if (cupboard[row,col] == "C")
        {
            cheeseCount++;
        }
	}
}

bool end = false;
string cmd;

while ((cmd = Console.ReadLine()) != "danger")
{
	switch (cmd)
	{      //-1
		case "up":
            if (IsMouseStepOutside(cupboard, mouseRow, mouseCol, cmd))
            {
                end = true; 
            }
            else
            {
                if (cupboard[mouseRow - 1,mouseCol] == "C")
                {
                    cupboard[mouseRow, mouseCol] = "*";
                    mouseRow = mouseRow - 1;

                   cheeseCount--;

                    if (cheeseCount == 0)
                    {
                        Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                        end = true;
                    }

                }
                else if (cupboard[mouseRow - 1, mouseCol] == "@")
                {
                    continue;
                }
                else if (cupboard[mouseRow - 1, mouseCol] == "T")
                {
                    cupboard[mouseRow,mouseCol] = "*";
                    mouseRow = mouseRow - 1;
                    Console.WriteLine("Mouse is trapped!");
                    end = true;
                }
                else
                {
                    cupboard[mouseRow, mouseCol] = "*";
                    mouseRow = mouseRow - 1;
                }
            }
			break; // +1
        case "down":
            if (IsMouseStepOutside(cupboard, mouseRow, mouseCol, cmd))
            {
                end = true;
            }
            else
            {
                if (cupboard[mouseRow + 1, mouseCol] == "C")
                {
                    cupboard[mouseRow, mouseCol] = "*";
                    mouseRow = mouseRow + 1;

                    cheeseCount--;

                    if (cheeseCount == 0)
                    {
                        Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                        end = true;
                    }

                }
                else if (cupboard[mouseRow + 1, mouseCol] == "@")
                {
                    continue;
                }
                else if (cupboard[mouseRow + 1, mouseCol] == "T")
                {

                    cupboard[mouseRow, mouseCol] = "*";
                    mouseRow = mouseRow + 1;
                    Console.WriteLine("Mouse is trapped!");
                    end = true;
                }
                else
                {
                    cupboard[mouseRow, mouseCol] = "*";
                    mouseRow = mouseRow + 1;
                }
            }
            break;//+1
        case "right":
            if (IsMouseStepOutside(cupboard, mouseRow, mouseCol, cmd))
            {
                end = true;
            }
            else
            {
                if (cupboard[mouseRow , mouseCol + 1] == "C")
                {
                    cupboard[mouseRow, mouseCol] = "*";
                    mouseCol = mouseCol + 1;

                    cheeseCount--;

                    if (cheeseCount == 0)
                    {
                        Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                        end = true;
                    }

                }
                else if (cupboard[mouseRow, mouseCol + 1] == "@")
                {
                    continue;
                }
                else if (cupboard[mouseRow, mouseCol + 1] == "T")
                {

                    cupboard[mouseRow, mouseCol] = "*";
                    mouseCol = mouseCol + 1;
                    Console.WriteLine("Mouse is trapped!");
                    end = true;
                }
                else
                {
                    cupboard[mouseRow, mouseCol] = "*";
                    mouseCol = mouseCol + 1;
                }
            }
            break;//-1
        case "left":
            if (IsMouseStepOutside(cupboard, mouseRow, mouseCol, cmd))
            {
                end = true;
            }
            else
            {

                if (cupboard[mouseRow, mouseCol - 1] == "C")
                {
                    cupboard[mouseRow, mouseCol] = "*";
                    mouseCol = mouseCol - 1;

                    cheeseCount--;

                    if (cheeseCount == 0)
                    {
                        Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                        end = true;
                    }

                }
                else if (cupboard[mouseRow , mouseCol - 1] == "@")
                {
                    continue;
                }
                else if (cupboard[mouseRow , mouseCol - 1] == "T")
                {

                    cupboard[mouseRow, mouseCol] = "*";
                    mouseCol = mouseCol - 1;
                    Console.WriteLine("Mouse is trapped!");
                    end = true;
                }
                else
                {
                    cupboard[mouseRow, mouseCol] = "*";
                    mouseCol = mouseCol - 1;
                }
            }
            break;
    }

    if (end)
    {
        break;
    }
}

cupboard[mouseRow, mouseCol] = "M";

if (cmd == "danger" && cheeseCount > 0)
{
    Console.WriteLine("Mouse will come back later!");
}

for (int rows = 0; rows < cupboard.GetLength(0); rows++)
{
    for (int cols = 0; cols < cupboard.GetLength(1); cols++)
    {
        Console.Write(cupboard[rows,cols]);
    }

    Console.WriteLine();
}

static bool IsMouseStepOutside(string[,] cupboard, int mouseRow, int mouseCol, string cmd )
{
    switch (cmd)
    {
        case "up":
            if (mouseRow - 1 >= 0)
            {
                return false;
            }
            break;
        case "down":
            if (mouseRow + 1 < cupboard.GetLength(0))
            {
                return false;
            }
            break;
        case "right":
            if (mouseCol + 1 < cupboard.GetLength(1))
            {
                return false;
            }
            break;
        case "left":
            if (mouseCol - 1 >= 0)
            {
                return false;
            }
            break;
    }

    Console.WriteLine("No more cheese for tonight!");
    return true;
}
