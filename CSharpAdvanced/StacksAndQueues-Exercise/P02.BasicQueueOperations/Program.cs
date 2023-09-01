using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.BasicQueueOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tokens = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>();
            int numToAdd = tokens[0];
            int numToRemove = tokens[1];
            int numToFind = tokens[2];

            for (int i = 0; i < numToAdd; i++)
            {
                queue.Enqueue(numbers[i]);
            }

            for (int i = 0; i < numToRemove; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(numToFind))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (queue.Any())
                {
                    Console.WriteLine(queue.Min());
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}