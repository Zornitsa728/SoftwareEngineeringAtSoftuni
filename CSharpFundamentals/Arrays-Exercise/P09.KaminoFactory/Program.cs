using System.Diagnostics;
using System.Linq;

namespace P09.KaminoFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dnaLength = int.Parse(Console.ReadLine());
            string input;
            int[] dnaSequence = new int[dnaLength];
            int[] bestSequence = new int[dnaLength];
            int sum = 1;
            int longestSubsequent = 0;
            int leftMostStarting = 0;
            int graterSum = 0;
            int sample = 0;
            int bestSample = 1;
            int biggestSum = 0;

            while ((input = Console.ReadLine()) != "Clone them!")
            {
                string[] inputArray = input.Split('!');
                int count = 0;
                int startingPosition = 0;
                int maxOnes = 0;
                int wholeSum = 0;
                sample++;

                for (int currentNum = 0; currentNum < dnaLength; currentNum++)
                {
                    dnaSequence[currentNum] = int.Parse(inputArray[currentNum]);

                    if (dnaSequence[currentNum] == 1)
                    {
                        wholeSum++;
                        count++;

                        if (count > 1)
                        {
                            sum++;
                            maxOnes = count;

                            if (count < 3 && currentNum != 0)
                            {
                                startingPosition = currentNum - 1;
                            }

                        }
                    }
                    else
                    {
                        count = 0;
                    }
                }

                if (maxOnes > longestSubsequent)
                {
                    longestSubsequent = maxOnes;
                    graterSum = sum;
                    bestSample = sample;
                    bestSequence = dnaSequence;
                    leftMostStarting = startingPosition;
                    biggestSum = wholeSum;
                }
                else if (maxOnes == longestSubsequent)
                {
                    if (startingPosition > leftMostStarting)
                    {
                        leftMostStarting = startingPosition;
                        graterSum = sum;
                        bestSample = sample;
                        bestSequence = dnaSequence;
                    }
                    else
                    {
                        if (wholeSum > biggestSum)
                        {
                            graterSum = wholeSum;
                            bestSample = sample;
                            bestSequence = dnaSequence;
                            leftMostStarting = startingPosition;
                        }
                        else
                        {
                            graterSum = wholeSum;
                            bestSample = sample;
                            bestSequence = dnaSequence;
                        }
                    }
                }

            }

            Console.WriteLine($"Best DNA sample {bestSample} with sum: {graterSum}.");
            Console.WriteLine($"{string.Join(" ", bestSequence)}");

        }
    }
}