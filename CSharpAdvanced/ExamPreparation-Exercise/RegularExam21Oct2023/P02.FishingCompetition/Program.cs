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

while ((cmd = Console.ReadLine()) != "collect the nets")
{
    IsShipLeavingTheArea(fishingArea, ref currRow, ref currCol, cmd);
}

static void IsShipLeavingTheArea(char[,] fishingArea, ref int currRow, ref int currCol, string cmd)
{
    switch (cmd)
    {
        case "up":
            if (currRow - 1 >= 0)
            {
                currRow = fishingArea.GetLength(0) - 1;
            }
            break;
        case "down":
            if (currRow + 1 < fishingArea.GetLength(0))
            {
                currRow = 0;
            }
            break;
        case "left":
            if (currCol + 1 < fishingArea.GetLength(1))
            {
                currCol = fishingArea.GetLength(1) - 1;
            }
            break;
        case "right":
            if (currCol - 1 >= 0)
            {
                currCol = 0;
            }
            break;
    }
}