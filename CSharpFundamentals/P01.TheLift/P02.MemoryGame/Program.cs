using System.Xml.Linq;

namespace P02.MemoryGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> sequenceOfElements = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string input;
            int moves = 0;

            while ((input = Console.ReadLine()) != "end")
            {
                moves++;
                int[] indexes = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                if (AreIndexesValid(sequenceOfElements, indexes))
                {
                    if (AreIndexesMatching(sequenceOfElements, indexes))
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {sequenceOfElements[indexes[0]]}!");
                        string elToRemove = sequenceOfElements[indexes[0]];
                        sequenceOfElements.Remove(elToRemove);
                        sequenceOfElements.Remove(elToRemove);

                    }
                    else if (!AreIndexesMatching(sequenceOfElements, indexes))
                    {
                        Console.WriteLine("Try again!");
                    }
                }
                else
                {
                    AddTwoMatchingEl(sequenceOfElements, indexes, moves);
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
            
                if (sequenceOfElements.Count == 0)
                {
                    Console.WriteLine($"You have won in {moves} turns!");
                    break;
                }
            }

            if (sequenceOfElements.Count > 0 && input == "end")
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(' ', sequenceOfElements));
            }
        }

        static bool AreIndexesMatching(List<string> sequenceOfElements, int[] indexes)
        {
            return sequenceOfElements[indexes[0]] == sequenceOfElements[indexes[1]];
        }

        static bool AreIndexesValid(List<string> sequenceOfElements, int[] indexes)
        {
            for (int i = 0; i < 2; i++)
            {
                if (indexes[i] >= sequenceOfElements.Count || indexes[i] < 0)
                {
                    return false;
                }
            }

            if (indexes[0] == indexes[1])
            {
                return false;
            }

            return true;
        }

        static List<string> AddTwoMatchingEl(List<string> sequenceOfElements, int[] indexes, int moves)
        {
            int middleofTheList = sequenceOfElements.Count / 2;
            string[] additionalElements = new string[2];

            for (int i = 0; i < 2; i++)
            {
                additionalElements[i] = $"-{moves}a";
            }

            sequenceOfElements.InsertRange(middleofTheList, additionalElements);

            return sequenceOfElements;
        }
    }
}