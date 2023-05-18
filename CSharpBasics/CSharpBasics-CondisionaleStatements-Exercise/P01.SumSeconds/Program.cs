using System;

namespace P01.SumSeconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int racer1 = int.Parse(Console.ReadLine());
            int racer2 = int.Parse(Console.ReadLine());
            int racer3 = int.Parse(Console.ReadLine());

            int time = racer1 + racer2 + racer3;
            int min = time / 60;
            int sec = time % 60;

            if (sec < 10)
            {
                Console.WriteLine($"{min}:0{sec}");
            }
            else
            {
                Console.WriteLine($"{min}:{sec}");
            }
        }
    }
}
