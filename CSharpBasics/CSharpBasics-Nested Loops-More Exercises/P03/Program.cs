using System;

namespace P03_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char miss = char.Parse(Console.ReadLine());
            int count = 0;

            for (char a = start; a <= end; a++)
            {
                for (char b = start; b <= end; b++)
                {
                    for (char i = start; i <= end; i++)
                    {
                        if (a != miss && b != miss && i != miss)
                        {
                            count++;
                            Console.Write($"{a}{b}{i} ");
                        }
                    }
                }
            }
            Console.Write(count);
        }
    }
}
