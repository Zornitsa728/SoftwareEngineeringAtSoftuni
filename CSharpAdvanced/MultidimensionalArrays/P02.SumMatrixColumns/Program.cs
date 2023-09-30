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
				.Split()
				.Select(int.Parse)
				.ToArray();

	for (int column = 0; column < columns; column++)
	{
		matrix[row, column] = numbers[column];
	}
}

for (int currColumn = 0; currColumn < columns; currColumn++)
{
	int columnSum = 0;

	for (int currRow = 0; currRow < rows; currRow++)
	{
		columnSum += matrix[currRow, currColumn];
	}

    Console.WriteLine(columnSum);
}