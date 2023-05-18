using System;

namespace P06_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int lastNum = int.Parse(Console.ReadLine());
            string startNum = firstNum.ToString();
            string endNum = lastNum.ToString();

            int firstStart = startNum[0] - '0';
            int firstEnd = endNum[0] - '0';
            int secondStart = startNum[1] - '0';
            int secondEnd = endNum[1] - '0';
            int thirdStart = startNum[2] - '0';
            int thirdEnd = endNum[2] - '0';
            int fourthStart = startNum[3] - '0';
            int fourthEnd = endNum[3] - '0';

            for (int a = firstStart; a <= firstEnd; a++)
            {
                for (int b = secondStart; b <= secondEnd; b++)
                {
                    for (int c = thirdStart; c <= thirdEnd; c++)
                    {
                        for (int d = fourthStart; d <= fourthEnd; d++)
                        {
                            int count = 0;

                            if (a % 2 != 0)
                            {
                                count++;
                            }
                            if (b % 2 != 0)
                            {
                                count++;
                            }
                            if (c % 2 != 0)
                            {
                                count++;
                            }
                            if (d % 2 != 0)
                            {
                                count++;
                            }
                            if (count == 4)
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
