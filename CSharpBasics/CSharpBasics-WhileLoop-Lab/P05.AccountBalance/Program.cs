using System;

namespace P05.AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            double accountBalance = 0;

            while ((input = Console.ReadLine()) != "NoMoreMoney")
            {
                double depositAmount = double.Parse(input);
                if (depositAmount < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                accountBalance += depositAmount;
                Console.WriteLine($"Increase: {depositAmount:f2}");
            }
            Console.WriteLine($"Total: {accountBalance:f2}");
        }
    }
}
