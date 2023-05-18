using System;

namespace p03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int initial = int.Parse(Console.ReadLine());
            int numberSum = 0;

            while (initial != numberSum)
            {
               int number = int.Parse(Console.ReadLine());
                numberSum += number;
            }
            Console.WriteLine(numberSum);
        }
    }
}
