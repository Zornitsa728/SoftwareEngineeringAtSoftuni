using System;
using System.Collections.Generic;
using System.Linq;

Queue<string> songs = new(
    Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries));

while (songs.Any())
{
    string[] cmdArgs = Console.ReadLine().Split();

    switch (cmdArgs[0])
    {
        case "Play":
            songs.Dequeue();
            break;
        case "Show":
            Console.WriteLine(string.Join(", ", songs));
            break;
        default:
            string songName = string.Join(" ",cmdArgs.Skip(1));

            if (songs.Contains(songName))
            {
                Console.WriteLine($"{songName} is already contained!");
            }
            else
            {
                songs.Enqueue(songName);
            }
            break;
    }
}

Console.WriteLine("No more songs!");
    