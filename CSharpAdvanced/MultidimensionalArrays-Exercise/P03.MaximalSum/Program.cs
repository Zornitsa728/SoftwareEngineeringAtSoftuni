int[,] matrix = CreatingMainMatrix();
int maxSum = int.MinValue;
int[,] resultMatrix = new int[3,3];

maxSum = FindSquare3x3MaxSum(matrix, maxSum, resultMatrix);

Console.WriteLine($"Sum = {maxSum}");
PrintResults(resultMatrix);
static int[,] CreatingMainMatrix()
{
    int[] size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

    int rows = size[0];
    int cols = size[1];
    int[,] matrix = new int[rows, cols];

    for (int row = 0; row < rows; row++)
    {
        int[] numbers = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

        for (int col = 0; col < cols; col++)
        {
            matrix[row, col] = numbers[col];
        }
    }

    return matrix;
}
static int FindSquare3x3MaxSum(int[,] matrix, int maxSum, int[,] resultMatrix)
{
    for (int row = 0; row < matrix.GetLength(0) - 2; row++)
    {
        for (int col = 0; col < matrix.GetLength(1) - 2; col++)
        {
            int currRowSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2];
            int secondRowSum = matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2];
            int thirdRowSum = matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
            int totalSum = currRowSum + secondRowSum + thirdRowSum;

            if (totalSum > maxSum)
            {
                maxSum = totalSum;
                CreatingResultMatrix(matrix, resultMatrix, row, col);
            }
        }
    }

    return maxSum;
}
static void CreatingResultMatrix(int[,] matrix, int[,] resultMatrix, int row, int col)
{
    for (int currRow = 0; currRow < 3; currRow++)
    {
        for (int currCol = 0; currCol < 3; currCol++)
        {
            resultMatrix[currRow, currCol] = matrix[row + currRow, col + currCol];
        }
    }
}
static void PrintResults(int[,] resultMatrix)
{
    for (int row = 0; row < resultMatrix.GetLength(0); row++)
    {
        for (int col = 0; col < resultMatrix.GetLength(1); col++)
        {
            Console.Write(resultMatrix[row, col] + " ");
        }

        Console.WriteLine();
    }
}

