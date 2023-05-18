using System;

namespace P05.Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine()); 
            double leftCoins = 0;
            string v;

            while ((change) != 0)
            {
                if (change >= 2)
                {
                    leftCoins++;
                    v = $"{change - 2:f2}";
                    change = double.Parse(v);   
                }
                if (change >= 1)
                {
                    leftCoins++;
                    v = $"{change - 1:f2}";
                    change = double.Parse(v);
                }
               
                if (change >= 0.5 && change < 1)
                {
                    leftCoins++;
                    v = $"{change - 0.5:f2}";
                    change = double.Parse(v);
                }
               
                if (change >= 0.2 && change < 0.5)
                {
                    leftCoins++;
                    v = $"{change - 0.2:f2}";
                    change = double.Parse(v);
                }
               
                if (change >= 0.1 && change < 0.2)
                {
                    leftCoins++;
                    v = $"{change - 0.1:f2}";
                    change = double.Parse(v);
                }
               
                if (change >= 0.05 && change < 0.1)
                {
                    leftCoins++;
                    v = $"{change - 0.05:f2}";
                    change = double.Parse(v);
                }
                if (change >= 0.02 && change < 0.05)
                {
                    leftCoins++;
                    v = $"{change - 0.02:f2}";
                    change = double.Parse(v);
                }
                if (change >= 0.01 && change < 0.02)
                {
                    leftCoins++;
                    v = $"{change - 0.01:f2}";
                    change = double.Parse(v);
                }
                
                
            }

            Console.WriteLine(leftCoins);
        }
    }
}
