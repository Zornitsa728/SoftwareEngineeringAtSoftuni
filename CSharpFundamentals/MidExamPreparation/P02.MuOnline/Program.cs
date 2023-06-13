using System.Threading;

namespace P02.MuOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries);
            int health = 100;
            int bestRoom = 0;
            int bitcoins = 0;

            for (int currRoom = 0; currRoom < input.Length; currRoom++)
            {
                string[] currCmd = input[currRoom].Split();
                string cmd = currCmd[0];
                int number = int.Parse(currCmd[1]);
                bestRoom++;

                if (cmd == "potion")
                {
                    if (health + number > 100)
                    {
                        number = 100 - health;
                        health = 100;
                    }
                    else
                    {
                        health += number;
                    }

                    Console.WriteLine($"You healed for {number} hp.");
                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if (cmd == "chest")
                {
                    Console.WriteLine($"You found {number} bitcoins.");
                    bitcoins += number;
                }
                else
                {
                    health -= number;
                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {cmd}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {cmd}.");
                        Console.WriteLine($"Best room: {bestRoom}");
                        break;
                    }
                } 
            }

            if (health > 0)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
            }
        }
    }
}