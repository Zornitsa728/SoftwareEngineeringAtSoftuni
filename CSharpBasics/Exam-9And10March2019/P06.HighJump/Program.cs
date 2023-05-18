using System;

namespace P06.HighJump
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int high = int.Parse(Console.ReadLine());
            int start = high - 30;
            int count = 0;
            int allJumps = 0;

            while (start <= high)
            {
                int highJump = int.Parse(Console.ReadLine());
                allJumps++;

                if (highJump > start)
                {
                    if (start >= high)
                    {
                        Console.WriteLine($"Tihomir succeeded, he jumped over {start}cm after {allJumps} jumps.");
                        break;
                    }
                    start += 5;
                    count = 0;
                }
                else if (highJump <= start)
                {
                    count++;
                    if (count == 3)
                    {
                        Console.WriteLine($"Tihomir failed at {start}cm after {allJumps} jumps.");
                        break;
                    }
                }
            }
        }    
    }
}
