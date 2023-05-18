using System;

namespace P05.PCGameShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sellOut = int.Parse(Console.ReadLine());
            string gameName;
            int countHearthstone = 0;
            int countFornite = 0;
            int countOverwatch = 0;
            int countOthers = 0;

            for (int i = 0; i < sellOut; i++)
            {
                gameName = Console.ReadLine();

                if (gameName == "Hearthstone")
                {
                    countHearthstone++;
                }
                else if (gameName == "Fornite")
                {
                    countFornite++;
                }
                else if (gameName == "Overwatch")
                {
                    countOverwatch++;
                }
                else
                {
                    countOthers++;
                }
            }

            Console.WriteLine($"Hearthstone - {(double)countHearthstone / sellOut * 100:f2}%");
            Console.WriteLine($"Fornite - {(double)countFornite / sellOut * 100:f2}%");
            Console.WriteLine($"Overwatch - {(double)countOverwatch / sellOut * 100:f2}%");
            Console.WriteLine($"Others - {(double)countOthers / sellOut * 100:f2}%");

        }

    }
}
