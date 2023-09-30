int[] dimensions = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
int rows = dimensions[0];
int cols = dimensions[1];
string stringSnake = Console.ReadLine();
char[,] matrix = new char[rows,cols];

Queue<char> queue = new Queue<char>();
for (int i = 0; i < stringSnake.Length; i++)
{
    queue.Enqueue(stringSnake[i]);
}

for (int row = 0; row < rows; row++)
{
    if (row % 2 == 0)
    {
        for (int col = 0; col < cols; col++)
        {
            matrix[row, col] = queue.Dequeue();
            queue.Enqueue(matrix[row, col]);
        }
    }
    else
    {
        for (int col = cols - 1; col >= 0; col--)
        {
            matrix[row, col] = queue.Dequeue();
            queue.Enqueue(matrix[row, col]);
        }
    }
}

for (int row = 0; row < rows; row++)
{
    for (int col = 0; col< cols; col++)
    {
        Console.Write(matrix[row,col]);
    }

    Console.WriteLine();
}