using System;
using System.Reflection;

namespace P10.LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] field = new int[fieldSize];
            int[] ladybugsIndexes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < ladybugsIndexes.Length; i++)
            {
                if (ladybugsIndexes[i] >= 0 && ladybugsIndexes[i] < field.Length)
                {
                    field[ladybugsIndexes[i]] = 1;
                }
            }

            string input;
            string direction = string.Empty;
            int index = 0;
            int flyLength = 0;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                index = int.Parse(command[0]);
                direction = command[1];
                flyLength = int.Parse(command[2]);

                if (index < 0 || index >= field.Length || field[index] == 0 || flyLength == 0)
                {
                    continue;
                }

                if (direction == "left")
                {
                    flyLength *= -1;
                }

                int nextPosition = index + flyLength;
                field[index] = 0;

                while (nextPosition >= 0 && nextPosition < field.Length)
                {
                    if (field[nextPosition] == 0)
                    {
                        field[nextPosition] = 1;
                        break;
                    }

                    nextPosition += flyLength;
                }
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
