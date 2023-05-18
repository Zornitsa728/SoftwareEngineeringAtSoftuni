using System;

namespace P05.SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int num = 1111; num <= 9999; num++)
            {
                string currentNumber = num.ToString();
                int count = 0;

                for (int i = 0; i < 4; i++)
                {
                    int symbol = currentNumber[i] - '0';  //int symbol = int.Parse(currentNumber[i].ToString());

                    if (symbol > 0)
                    {
                        if (number % symbol == 0)
                        {
                            count++;
                        }
                    }

                }

                if (count == 4)
                {
                    Console.Write($"{currentNumber} ");
                }
            }
            }
    }
}
