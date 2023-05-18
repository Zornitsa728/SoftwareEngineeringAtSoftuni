using System;

namespace P07.MinNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numbers;
            int minNum = int.MaxValue;

            while ((numbers= Console.ReadLine()) != "Stop")
            {
                int currentNumber = int.Parse(numbers);

                if (currentNumber < minNum)
                {
                    minNum = currentNumber;
                }
            }

            Console.WriteLine(minNum);
        }
    }
}
