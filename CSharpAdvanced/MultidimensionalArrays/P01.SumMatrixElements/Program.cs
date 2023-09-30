using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;

int[] size = Console.ReadLine()
				.Split(", ")
				.Select(int.Parse)
				.ToArray();
int rows = size[0];
int columns = size[1];
int[,] matrix = new int[rows, columns];
int sum = 0;

for (int i = 0; i < rows; i++)
{
	int[] numbers = Console.ReadLine()
				.Split(", ")
				.Select(int.Parse)
				.ToArray();

	for (int j = 0; j < columns; j++)
	{
		matrix[i, j] = numbers[j];
		sum += numbers[j];
    }
}

Console.WriteLine(rows);
Console.WriteLine(columns);
Console.WriteLine(sum);
