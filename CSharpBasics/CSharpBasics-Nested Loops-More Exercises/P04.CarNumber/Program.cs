using System;

namespace P04.CarNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            for (int a = startNum; a <= endNum; a++)
            {
                for (int b = startNum; b <= endNum; b++)
                {
                    for (int c = startNum; c <= endNum; c++)
                    {
                        for (int d = startNum; d <= endNum; d++)
                        {
                            if (a % 2 == 0 && d % 2 != 0)
                            {
                                if (a > d)
                                {
                                    if ((b + c) % 2 == 0)
                                    {
                                        Console.Write($"{a}{b}{c}{d} ");
                                    }
                                }
                            }
                            else if (a % 2 != 0 && d % 2 == 0)
                            {
                                if (a > d)
                                {
                                    if ((b + c) % 2 == 0)
                                    {
                                        Console.Write($"{a}{b}{c}{d} ");
                                    }
                                }
                            }
                        }
                    }
                }
            }

        }
    }
}
