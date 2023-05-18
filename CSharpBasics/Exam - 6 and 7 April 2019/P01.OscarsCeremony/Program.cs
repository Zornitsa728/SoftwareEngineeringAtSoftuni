using System;

namespace P01.OscarsCeremony
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rent = int.Parse(Console.ReadLine());
            double statuette = rent * 0.7;
            double kettering = statuette * 0.85;
            double sound = kettering / 2;
            double totalPrice = rent + statuette + kettering + sound;
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
