using System.Runtime.CompilerServices;

int size = int.Parse(Console.ReadLine());
int[,] matrix = ReadMatrix(size);
int sumDifference = Math.Abs(PrimaryDiagonalSum(matrix) - SecondaryDiagonalSum(matrix));
Console.WriteLine(sumDifference);

static int[,] ReadMatrix(int size)
{
    int[,] matrix = new int[size, size];

    for (int row = 0; row < size; row++)
    {
        int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

        for (int col = 0; col < size; col++)
        {
            matrix[row, col] = numbers[col];
        }
    }

    return matrix;
}

static int PrimaryDiagonalSum(int[,] matrix)
{
    int primaryDiagonalSum = 0;

    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        primaryDiagonalSum += matrix[row, row];
    }

    return primaryDiagonalSum;
}

static int SecondaryDiagonalSum(int[,] matrix)
{
    int secondaryDiagonalSum = 0;

    for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
    {
        int col = matrix.GetLength(0) - 1 - row;
        secondaryDiagonalSum += matrix[row, col];
    }

    return secondaryDiagonalSum;
}