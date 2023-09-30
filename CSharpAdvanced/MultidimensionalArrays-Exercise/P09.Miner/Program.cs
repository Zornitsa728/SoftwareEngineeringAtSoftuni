namespace P09.Miner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            string[] cmds = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            char[,] matrix = new char[fieldSize, fieldSize];
            int coalCount = 0;
            int currRow = 0;
            int currCol = 0;

            for (int row = 0; row < fieldSize; row++)
            {
                char[] elements = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();

                for (int col = 0; col < fieldSize; col++)
                {
                    matrix[row, col] = elements[col];

                    if (matrix[row, col] == 'c')
                    {
                        coalCount++;
                    }

                    if (matrix[row, col] == 's')
                    {
                        currRow = row;
                        currCol = col;
                    }
                }
            }

            bool gameOver = false;
            for (int i = 0; i < cmds.Length; i++)
            {
                if (cmds[i] == "left")
                {
                    if (currCol - 1 >= 0 && currCol - 1 < fieldSize)
                    {
                        if (matrix[currRow, currCol - 1] == 'e')
                        {
                            gameOver = true;
                        }
                        else if (matrix[currRow, currCol - 1] == 'c')
                        {
                            coalCount--;
                        }

                        matrix[currRow, currCol] = '*';
                        matrix[currRow, currCol - 1] = 's';
                        currCol = currCol - 1;
                    }
                }
                else if (cmds[i] == "right")
                {
                    if (currCol + 1 >= 0 && currCol + 1 < fieldSize)
                    {
                        if (matrix[currRow, currCol + 1] == 'e')
                        {
                            gameOver = true;
                        }
                        else if (matrix[currRow, currCol + 1] == 'c')
                        {
                            coalCount--;
                        }

                        matrix[currRow, currCol] = '*';
                        matrix[currRow, currCol + 1] = 's';
                        currCol = currCol + 1;
                    }
                }
                else if (cmds[i] == "up")
                {
                    if (currRow - 1 >= 0 && currRow - 1 < fieldSize)
                    {
                        if (matrix[currRow - 1, currCol] == 'e')
                        {
                            gameOver = true;
                        }
                        else if (matrix[currRow - 1, currCol] == 'c')
                        {
                            coalCount--;
                        }

                        matrix[currRow, currCol] = '*';
                        matrix[currRow - 1, currCol] = 's';
                        currRow = currRow - 1;
                    }
                }
                else if (cmds[i] == "down")
                {
                    if (currRow + 1 >= 0 && currRow + 1 < fieldSize)
                    {
                        if (matrix[currRow + 1, currCol] == 'e')
                        {
                            gameOver = true;
                        }
                        else if (matrix[currRow + 1, currCol] == 'c')
                        {
                            coalCount--;
                        }

                        matrix[currRow, currCol] = '*';
                        matrix[currRow +1, currCol] = 's';
                        currRow = currRow + 1;
                    }
                }

                if (gameOver)
                {
                    break;
                }

                if (coalCount == 0)
                {
                    Console.WriteLine($"You collected all coals! ({currRow}, {currCol})");
                    break;
                }
            }

            if (coalCount > 0 && !gameOver)
            {
                Console.WriteLine($"{coalCount} coals left. ({currRow}, {currCol})");
            }
            else if (gameOver)
            {
                Console.WriteLine($"Game over! ({currRow}, {currCol})");
            }
        }
    }
}