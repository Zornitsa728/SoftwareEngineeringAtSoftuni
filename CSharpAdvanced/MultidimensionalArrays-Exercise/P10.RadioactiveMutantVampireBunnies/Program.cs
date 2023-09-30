using System.Data.Common;

namespace P10.RadioactiveMutantVampireBunnies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rows = dimensions[0];
            int columns = dimensions[1];
            char[,] matrix = new char[rows, columns];
            int playerRow = 0;
            int playerCol = 0;

            for (int row = 0; row < rows; row++)
            {
                string symbols = Console.ReadLine();

                for (int column = 0; column < columns; column++)
                {
                    matrix[row, column] = symbols[column];

                    if (matrix[row, column] == 'P')
                    {
                        playerRow = row;
                        playerCol = column;
                    }
                }
            }

            bool playerWin = false;
            bool playerLose = false;
            string cmds = Console.ReadLine();

            for (int currCmd = 0; currCmd < cmds.Length; currCmd++) // go through all of the commands (directions)
            {
                char operation = cmds[currCmd];

                if (operation == 'U') // up
                {
                    if (IsIndexValid(playerRow - 1, playerCol, matrix)) //checks if the new position is in matrix range and there is no 'B'(bunny) 
                    {
                        matrix[playerRow, playerCol] = '.';
                        playerRow = playerRow - 1;
                        matrix[playerRow, playerCol] = 'P';
                    }
                    else
                    {
                        if (playerRow - 1 < 0 || playerRow - 1 >= rows) // if the position is outside -> player wins
                        {
                            playerWin = true;
                            matrix[playerRow, playerCol] = '.';
                        }
                        else // or if the position is taken by bunny -> player lose
                        {
                            playerLose = true;
                            playerRow = playerRow - 1;
                        }
                    }

                    playerLose = MultiplyBunnies(playerRow, playerCol, matrix, playerLose); // update bunny multiplication on matrix and if bunny steps on player, playerLose becomes true
                }
                else if (operation == 'D') // down
                {
                    if (IsIndexValid(playerRow + 1, playerCol, matrix))
                    {
                        matrix[playerRow, playerCol] = '.';
                        playerRow = playerRow + 1;
                        matrix[playerRow, playerCol] = 'P';
                    }
                    else
                    {
                        if (playerRow + 1 < 0 || playerRow + 1 >= rows)
                        {
                            playerWin = true;
                            matrix[playerRow, playerCol] = '.';
                        }
                        else
                        {
                            playerLose = true;
                            playerRow = playerRow + 1;
                        }
                    }

                    playerLose = MultiplyBunnies(playerRow, playerCol, matrix, playerLose);
                }
                else if (operation == 'L') // left
                {
                    if (IsIndexValid(playerRow, playerCol - 1, matrix))
                    {
                        matrix[playerRow, playerCol] = '.';
                        playerCol = playerCol - 1;
                        matrix[playerRow, playerCol] = 'P';
                    }
                    else
                    {
                        if (playerCol - 1 < 0 || playerCol - 1 >= rows)
                        {
                            playerWin = true;
                            matrix[playerRow, playerCol] = '.';
                        }
                        else
                        {
                            playerLose = true;
                            playerCol = playerCol - 1;
                        }
                    }

                    playerLose = MultiplyBunnies(playerRow, playerCol, matrix, playerLose);
                }
                else if (operation == 'R') // right
                {
                    if (IsIndexValid(playerRow, playerCol + 1, matrix))
                    {
                        matrix[playerRow, playerCol] = '.';
                        playerCol = playerCol + 1;
                        matrix[playerRow, playerCol] = 'P';
                    }
                    else
                    {
                        if (playerCol + 1 < 0 || playerCol + 1 >= rows)
                        {
                            playerWin = true;
                            matrix[playerRow, playerCol] = '.';
                        }
                        else
                        {
                            playerLose = true;
                            playerCol = playerCol + 1;
                        }
                    }

                    playerLose = MultiplyBunnies(playerRow, playerCol, matrix, playerLose);
                }

                if (playerWin || playerLose)
                {
                    break;
                }

            }

            PrintResult(rows, columns, matrix, playerRow, playerCol, playerWin, playerLose);
        }

        private static void PrintResult(int rows, int columns, char[,] matrix, int playerRow, int playerCol, bool playerWin, bool playerLose)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }

            if (playerWin)
            {
                Console.WriteLine($"won: {playerRow} {playerCol}");
            }
            else if (playerLose)
            {
                Console.WriteLine($"dead: {playerRow} {playerCol}");
            }
        }

        private static bool MultiplyBunnies(int playerRow, int playerCol, char[,] matrix, bool playerLose)
        {
            Queue<int> bunniesPositions = SaveBunniesPosition(playerRow, playerCol, matrix);

            while (bunniesPositions.Any())
            {
                int row = bunniesPositions.Dequeue();
                int col = bunniesPositions.Dequeue();

                if (row - 1 >= 0 && row - 1 < matrix.GetLength(0)) //up
                {
                    if (matrix[row - 1, col] == 'P')
                    {
                        playerLose = true;
                    }

                    matrix[row - 1, col] = 'B';
                }

                if (row + 1 >= 0 && row + 1 < matrix.GetLength(0)) //down
                {
                    if (matrix[row + 1, col] == 'P')
                    {
                        playerLose = true;
                    }

                    matrix[row + 1, col] = 'B';
                }

                if (col - 1 >= 0 && col - 1 < matrix.GetLength(1)) //left
                {
                    if (matrix[row, col - 1] == 'P')
                    {
                        playerLose = true;
                    }

                    matrix[row, col - 1] = 'B';
                }

                if (col + 1 >= 0 && col + 1 < matrix.GetLength(1)) //right
                {
                    if (matrix[row, col + 1] == 'P')
                    {
                        playerLose = true;
                    }

                    matrix[row, col + 1] = 'B';
                }
            }

            return playerLose;
        }
        private static Queue<int> SaveBunniesPosition(int playerRow, int playerCol, char[,] matrix)
        {
            Queue<int> bunniesPositions = new Queue<int>();
            bool isElNearEmptySpot = false;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'B')
                    {
                        if (CheckEmptySpots(row, col, matrix))
                        {
                            bunniesPositions.Enqueue(row);
                            bunniesPositions.Enqueue(col);
                        }
                    }
                }
            }

            return bunniesPositions;
        }

        private static bool CheckEmptySpots(int row, int col, char[,] matrix)
        {
            if (row > 0 && row - 1 < matrix.GetLength(0)) //up
            {
                if (matrix[row - 1, col] == '.')
                {
                    return true;
                }
            }

            if (row + 1 >= 0 && row + 1 < matrix.GetLength(0)) //down
            {
                if (matrix[row + 1, col] == '.')
                {
                    return true;
                }
            }

            if (col - 1 >= 0 && col - 1 < matrix.GetLength(1)) //left
            {
                if (matrix[row, col - 1] == '.')
                {
                    return true;
                }
            }

            if (col + 1 >= 0 && col + 1 < matrix.GetLength(1)) //right
            {
                if (matrix[row, col + 1] == '.')
                {
                    return true;
                }
            }

            return false;
        }

        private static bool IsIndexValid(int playerRow, int playerCol, char[,] matrix)
        {
            if (playerRow >= 0 && playerRow < matrix.GetLength(0) && playerCol >= 0 && playerCol < matrix.GetLength(1))
            {
                if (matrix[playerRow, playerCol] == 'B')
                {
                    return false;
                }

                return true;
            }

            return false;
        }
    }
}