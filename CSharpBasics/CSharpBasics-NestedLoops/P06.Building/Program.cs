using System;

namespace P06.Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());
            int maxFloor = int.MinValue;
            
            for (int num = floors; num > 0; num --) 
            {
                for (int i = 0; i < rooms ; i++)
                {
                    if (num >= maxFloor)
                    {
                        maxFloor = num;
                        Console.Write($"L{num}{i} ");
                    }
                    else if (num % 2 == 0)
                    {
                        Console.Write($"O{num}{i} ");
                    }
                    else
                    {
                        Console.Write($"A{num}{i} ");
                    }
                }

                Console.WriteLine();
            }


        }
    }
}
