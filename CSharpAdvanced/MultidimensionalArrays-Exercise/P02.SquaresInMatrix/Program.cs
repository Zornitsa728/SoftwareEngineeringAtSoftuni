using System;
using System.Linq;

int[] size = Console.ReadLine()
				.Split(" ",StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();
int rows = size[0];
int cols = size[1];
char[,] matrix = new char[rows, cols];

for (int row = 0; row < rows; row++)
{
	char[] chars = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

	for (int col = 0; col < cols; col++)
	{
		matrix[row, col] = chars[col];
	}
}

int countSameSquares = 0;
for (int row = 0; row < rows - 1; row++)
{
	for (int col = 0; col < cols - 1; col++)
	{
		bool currRowChars = matrix[row, col] == matrix[row, col + 1];
		bool nextRowChars = matrix[row + 1, col] == matrix[row + 1, col + 1];
		bool areTheSameChars = matrix[row, col] == matrix[row + 1, col];
		
        if (currRowChars && nextRowChars && areTheSameChars)
		{
			countSameSquares++;
		}
	}
}

Console.WriteLine(countSameSquares);