using System;

namespace P03.DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            int term = int.Parse(Console.ReadLine());
            double rate = double.Parse(Console.ReadLine())/100;
            double sum = depositSum + term * ((depositSum * rate) / 12);
            Console.WriteLine(sum);


        }
    }
}
