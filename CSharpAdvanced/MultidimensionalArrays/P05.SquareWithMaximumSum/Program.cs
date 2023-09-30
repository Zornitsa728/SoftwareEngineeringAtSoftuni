using System.Diagnostics.CodeAnalysis;

int[] size = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();
int rows = size[0];
int columns = size[1];
int[,] matrix = new int[rows, columns];

for (int row = 0; row < rows; row++)
{
    int[] numbers = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

    for (int col = 0; col < columns; col++)
    {
        matrix[row, col] = numbers[col];
    }
}

int maxValue = int.MinValue;
int firstNum = 0;
int secondNum = 0;
int thirdNum = 0;
int fourthNum = 0;
int sum = 0;

for (int row = 0; row < rows - 1; row++)
{
    for (int col = 0; col < columns - 1; col++)
    {
        sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];

        if (sum > maxValue)
        {
            maxValue = sum;
            firstNum = matrix[row, col];
            secondNum = matrix[row, col + 1];
            thirdNum = matrix[row + 1, col];
            fourthNum = matrix[row + 1, col + 1];
        }
    }
}

Console.WriteLine(firstNum + " " + secondNum);
Console.WriteLine(thirdNum + " " + fourthNum);
Console.WriteLine(maxValue);

