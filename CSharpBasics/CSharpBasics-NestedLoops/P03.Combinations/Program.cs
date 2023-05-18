using System;

namespace P03.Combinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int magicNumber = int.Parse(Console.ReadLine());
            int result = 0;
            int combinations = 0;

            for (int x1 = 0; x1<=magicNumber; x1++)
            {
                for (int x2 = 0; x2 <= magicNumber; x2++)
                {
                    for (int x3 = 0; x3 <= magicNumber; x3++)
                    {
                        result = x1 + x2 + x3;

                        if (result == magicNumber)
                        {
                            combinations++;
                        }
                    }
                }
            }

            Console.WriteLine(combinations);
        }
    }
}
