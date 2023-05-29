using System;

namespace P10.LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            long[] field = new long[fieldSize];
            long[] ladybugsIndexes = Console.ReadLine().
                Split(" ", StringSplitOptions.RemoveEmptyEntries).
                Select(long.Parse).
                ToArray();

            for (long i = 0; i < ladybugsIndexes.Length; i++)
            {
                field[ladybugsIndexes[i]] = 1;
            }

            string input;
            string direction = string.Empty;
            long index = 0;
            long flyLength = 0;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                index = long.Parse(command[0]);
                direction = command[1];
                flyLength = long.Parse(command[2]);

                if (index < 0 || index >= field.Length)
                {
                    continue;
                }
                else if (field[index] == 0)
                {
                    continue;
                }

                if (direction == "right")
                {
                    field[index] = 0;

                    for (long freePosition = index + flyLength; freePosition < field.Length; freePosition++)
                    {
                        if (field[freePosition] == 0)
                        {
                            field[index + freePosition] = 1;
                            break;
                        }
                    }
                }
                else if (direction == "left")
                {
                    field[index] = 0;

                    for (long freePosition = index - flyLength; 0 <= freePosition; )
                    {

                        if (field[freePosition] == 0)
                        {
                            field[freePosition] = 1;
                            break;
                        }

                        if (flyLength < 0)
                        {
                            freePosition++;
                        }
                        else
                        {
                            freePosition--;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}