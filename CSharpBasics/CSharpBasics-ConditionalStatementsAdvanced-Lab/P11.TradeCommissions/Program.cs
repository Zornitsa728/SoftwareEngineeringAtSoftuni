using System;

namespace P11.TradeCommissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double commission = 0;

            if (city == "Sofia")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commission = sales * 5 / 100;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commission = sales * 7 / 100;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commission = sales * 8 / 100;
                }
                else if (sales > 10000)
                {
                    commission = sales * 12 / 100;
                }
                else
                    Console.WriteLine("error");
            }
            else if (city == "Varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commission = sales * 4.5 / 100;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commission = sales * 7.5 / 100;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commission = sales * 10 / 100;
                }
                else if (sales > 10000)
                {
                    commission = sales * 13 / 100;
                }
                else
                    Console.WriteLine("error");
            }
            else if (city == "Plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commission = sales * 5.5 / 100;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commission = sales * 8 / 100;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commission = sales * 12 / 100;
                }
                else if (sales > 10000)
                {
                    commission = sales * 14.5 / 100;
                }
                else
                    Console.WriteLine("error");
            }
            else
            { 
                Console.WriteLine("error"); 
            }

            if (commission > 0)
            {
                Console.WriteLine($"{commission:f2}");
            } 
        }
    }
}
