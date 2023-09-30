namespace P08.Bombs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];

            for (int row = 0; row < size; row++)
            {
                int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }

            int[] indexes = Console.ReadLine()
                .Split(new char[] { ',', ' ' })
                .Select(int.Parse)
                .ToArray();

            for (int bomb = 0; bomb < indexes.Length - 1; bomb += 2)
            {
                int currRow = indexes[bomb];
                int currCol = indexes[bomb + 1];

                if (matrix[currRow, currCol] > 0) // if the bomb is above 0, otherwise it can't explode
                {
                    int damage = matrix[currRow, currCol];
                    matrix[currRow, currCol] = 0;
                    BombExplosion(currRow, currCol, size, matrix, damage);
                }
            }

            int aliveCells = 0;
            int sum = 0;
            foreach (int currNum in matrix)
            {
                if (currNum > 0)
                {
                    aliveCells++;
                    sum += currNum;
                }
            }

            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {sum}");

            PrintMatrix(size, matrix);

        }

        private static void PrintMatrix(int size, int[,] matrix)
        {
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }

        private static void BombExplosion(int currRow, int currCol, int size, int[,] matrix, int damage)
        {
            if (IsIndexValid(currRow - 1, currCol, size, matrix)) // up
            {
                matrix[currRow - 1, currCol] -= damage;
            }

            if (IsIndexValid(currRow + 1, currCol, size, matrix)) // down
            {
                matrix[currRow + 1, currCol] -= damage;
            }

            if (IsIndexValid(currRow - 1, currCol - 1, size, matrix)) // up, left
            {
                matrix[currRow - 1, currCol - 1] -= damage;
            }

            if (IsIndexValid(currRow - 1, currCol + 1, size, matrix)) // up, right
            {
                matrix[currRow - 1, currCol + 1] -= damage;
            }

            if (IsIndexValid(currRow + 1, currCol - 1, size, matrix)) // down, left
            {
                matrix[currRow + 1, currCol - 1] -= damage;
            }

            if (IsIndexValid(currRow + 1, currCol + 1, size, matrix)) // down, right
            {
                matrix[currRow + 1, currCol + 1] -= damage;
            }

            if (IsIndexValid(currRow, currCol - 1, size, matrix)) // middle, left
            {
                matrix[currRow, currCol - 1] -= damage;
            }

            if (IsIndexValid(currRow, currCol + 1, size, matrix)) // middle, right
            {
                matrix[currRow, currCol + 1] -= damage;
            }

        }

        private static bool IsIndexValid(int row, int col, int size, int[,] matrix)
        {
            if (row >= 0 && row < size && col >= 0 && col < size)
            {
                if (matrix[row, col] > 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}