int size = int.Parse(Console.ReadLine());
int[,] matrix = new int[size, size];

for (int row = 0; row < size; row++)
{
    int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

    for (int column = 0; column < size; column++)
    {
        matrix[row,column] = numbers[column];
    }
}

int sumDiagonal = 0;
for (int currRow = 0; currRow < size; currRow++)
{
   sumDiagonal += matrix[currRow,currRow];
}

Console.WriteLine(sumDiagonal);