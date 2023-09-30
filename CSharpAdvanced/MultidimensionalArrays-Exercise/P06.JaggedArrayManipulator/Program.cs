int rows = int.Parse(Console.ReadLine());
int[][] jaggedArray = new int[rows][];

for (int row = 0; row < rows; row++) // Initializing with values
{
    int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
    jaggedArray[row] = numbers;
}

// If a row and the one below it have equal length, multiply each element by 2, otherwise - divide by 2.
for (int row = 0; row < rows - 1; row++) 
{
    if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
    {
        for (int col = 0; col < jaggedArray[row].Length; col++)
        {
            jaggedArray[row][col] *= 2;
            jaggedArray[row + 1][col] *= 2;
        }
    }
    else
    {
        int largerRow = Math.Max(jaggedArray[row].Length, jaggedArray[row + 1].Length);

        for (int col = 0; col < largerRow; col++)
        {
            if (jaggedArray[row].Length > col)
            {
                jaggedArray[row][col] /= 2;
            }

            if (jaggedArray[row + 1].Length > col)
            {
                jaggedArray[row + 1][col] /= 2;
            }
        }
    }
}

string cmd;
while ((cmd = Console.ReadLine()) != "End")
{
    string[] cmdArgs = cmd
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string operation = cmdArgs[0];
    int row = int.Parse(cmdArgs[1]);
    int col = int.Parse(cmdArgs[2]);
    int value = int.Parse(cmdArgs[3]);

    if (operation == "Add" && IsIndexValid(jaggedArray, row, col))
    {
        jaggedArray[row][col] += value;
    }
    else if (operation == "Subtract" && IsIndexValid(jaggedArray, row, col))
    {
        jaggedArray[row][col] -= value;
    }
}

for (int row = 0; row < rows; row++) // Print Jagged Array
{
    for (int col = 0; col < jaggedArray[row].Length; col++)
    {
        Console.Write(jaggedArray[row][col] + " ");
    }

    Console.WriteLine();
}
static bool IsIndexValid(int[][] jaggedArray, int row, int col)
{
    if (row >= 0 && row < jaggedArray.GetLength(0))
    {
        if (col >= 0 && col < jaggedArray[row].Length)
        {
            return true;
        }
    }

    return false;
}