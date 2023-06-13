using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace P06.CardsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstDeck = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondDeck = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int smallerDeck = 1;
            int sum = 0;
            string winningPlayer = "Second";

            if (WhichIsTheWinningDeck(firstDeck, secondDeck, smallerDeck))
            {
                sum = CalculateSum(firstDeck);
                winningPlayer = "First";
            }
            else
            {
                sum = CalculateSum(secondDeck);
            }

            Console.WriteLine($"{winningPlayer} player wins! Sum: {sum}");
        }

        static List<int> FindWinningDeck(List<int> firstDeck, List<int> secondDeck, int smallerDeck)
        {
            while ((smallerDeck = Math.Min(firstDeck.Count, secondDeck.Count)) != 0)
            {
                for (int i = 0; i < smallerDeck; i++)
                {
                    if (firstDeck[i] > secondDeck[i])
                    {
                        firstDeck.Add(firstDeck[i]);
                        firstDeck.Add(secondDeck[i]);
                        firstDeck.RemoveAt(i);
                        secondDeck.RemoveAt(i);
                    }
                    else if (firstDeck[i] == secondDeck[i])
                    {
                        firstDeck.RemoveAt(i);
                        secondDeck.RemoveAt(i);
                    }
                    else if (firstDeck[i] < secondDeck[i])
                    {
                        secondDeck.Add(secondDeck[i]);
                        secondDeck.Add(firstDeck[i]);
                        secondDeck.RemoveAt(i);
                        firstDeck.RemoveAt(i);
                    }

                    i--;

                    if (secondDeck.Count == 0 || firstDeck.Count == 0)
                    {
                        break;
                    }
                }
            }

            List<int> winningDeck = new List<int>();

            if (firstDeck.Count > secondDeck.Count)
            {
                return firstDeck;
            }

            return secondDeck;
        }

        static bool WhichIsTheWinningDeck(List<int> firstDeck, List<int> secondDeck, int smallerDeck)
        {
            FindWinningDeck(firstDeck, secondDeck, smallerDeck);

            if (firstDeck.Count > secondDeck.Count)
            {
                return true;
            }

            return false;
        }

        static int CalculateSum(List<int> winningDeck)
        {
            int sum = 0;
            foreach (int card in winningDeck)
            {
                sum += card;
            }

            return sum;
        }
    }
}