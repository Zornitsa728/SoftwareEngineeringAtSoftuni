int[] dimensions = Console.ReadLine()
				.Split(" ",StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();

int rows = dimensions[0];
int cols = dimensions[1];
string[,] matrix = new string[rows, cols];

SaveDataInToMatrix(rows, cols, matrix);

string cmd;
while ((cmd = Console.ReadLine()) != "END")
{
    string[] cmdArgs = cmd
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);
    bool areCoordinatesValid = false;

    if (cmdArgs.Length == 5 && cmdArgs[0] == "swap")
    {
        int row1 =  int.Parse(cmdArgs[1]);
        int row2 = int.Parse(cmdArgs[3]);
        int col1 = int.Parse(cmdArgs[2]);
        int col2 = int.Parse(cmdArgs[4]);

        if (row1 >= 0 && row1 < matrix.GetLength(0) && row2 >= 0 && row2 < matrix.GetLength(0))
        {
            if (col1 >= 0 && col1 < matrix.GetLength(1) && col2 >= 0 && col2 < matrix.GetLength(1))
            {
                areCoordinatesValid = true;
                string firstEl = matrix[row1, col1];
                string secondEl = matrix[row2, col2];
                
                matrix[row1, col1] = secondEl;
                matrix[row2, col2] = firstEl;

                PrintMatrix(rows, cols, matrix);
            }
        }
    }

    if (!areCoordinatesValid)
    {
        Console.WriteLine("Invalid input!");
    }
}

static void SaveDataInToMatrix(int rows, int cols, string[,] matrix)
{
    for (int row = 0; row < rows; row++)
    {
        string[] data = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries);

        for (int col = 0; col < cols; col++)
        {
            matrix[row, col] = data[col];
        }
    }
}

static void PrintMatrix(int rows, int cols, string[,] matrix)
{
    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < cols; col++)
        {
            Console.Write(matrix[row, col] + " ");
        }

        Console.WriteLine();
    }
}
