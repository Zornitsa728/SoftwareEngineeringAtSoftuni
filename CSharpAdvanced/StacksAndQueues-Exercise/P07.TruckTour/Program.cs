using System;
using System.Collections.Generic;
using System.Linq;

int countPumps = int.Parse(Console.ReadLine());
Queue<int> tokens = new();

for (int i = 0; i < countPumps; i++)
{
    int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
    tokens.Enqueue(input[0]);
    tokens.Enqueue(input[1]);
}

int petrol = 0;
int distance = 0;
int result = 0;
int pumpNum = 0;
int count = -1;
int currPump = -1;

for (int i = 0; i < countPumps; i++)
{
    currPump++;
    petrol = tokens.Dequeue();
    distance = tokens.Dequeue();
    result += petrol - distance;

    if (result >= 0)
    {
        count++;
    }
    else if (result < 0)
    {
        count = -1;
        result = 0;
        i = -1;
    }

    if (result >= 0 && count == 0)
    {
        pumpNum = currPump;
    }

    tokens.Enqueue(petrol);
    tokens.Enqueue(distance);
}

Console.WriteLine(pumpNum);
