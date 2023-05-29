using System;

namespace P00.Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] field = new int[fieldSize];
            long[] ladybugsIndexes = Console.ReadLine().
                Split(" ", StringSplitOptions.RemoveEmptyEntries).
                Select(long.Parse).
                ToArray();
            
            for (long i = 0; i < ladybugsIndexes.Length; i++)
            {
                if (ladybugsIndexes[i] >= 0 && ladybugsIndexes[i] < field.Length)
                {
                    field[ladybugsIndexes[i]] = 1;
                }
            }

            string input;
            string direction = string.Empty;
            long index = 0;
            long flyLength = 0;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                index = long.Parse(command[0]);
                direction = command[1];
                flyLength = long.Parse(command[2]);

                if (index < 0 || index >= field.Length || field[index] == 0 || flyLength == 0)
                {
                    continue;
                }

                if (direction == "right")
                {
                    field[index] = 0;

                    for (long freePosition = index + flyLength; freePosition >= 0 && freePosition < field.Length;)
                    {
                        if (field[freePosition] == 0)
                        {
                            field[freePosition] = 1;
                            break;
                        }

                        if (flyLength < 0)
                        {
                            freePosition -=flyLength;
                        }
                        else
                        {
                            freePosition += flyLength;
                        }
                    }
                }
                else if (direction == "left")
                {
                    field[index] = 0;

                    for (long freePosition = index - flyLength; freePosition >= 0 && freePosition < field.Length;)
                    {

                        if (field[freePosition] == 0)
                        {
                            field[freePosition] = 1;
                            break;
                        }

                        if (flyLength < 0)
                        {
                            freePosition += flyLength;
                        }
                        else
                        {
                            freePosition -= flyLength;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}