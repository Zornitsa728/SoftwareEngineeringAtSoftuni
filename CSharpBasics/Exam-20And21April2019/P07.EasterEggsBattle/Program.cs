using System;

namespace P07.EasterEggsBattle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Брой яйца, които има първият играч - цяло число в интервала [1 … 99]
            int eggsPlayer1 = int.Parse(Console.ReadLine());
            //Брой яйца, които има вторият играч -цяло число в интервала[1 … 99]
            int eggsPlayer2 = int.Parse(Console.ReadLine());
            //След това до получаване на команда "End" се четe многократно един ред: 
            int totalEggs = eggsPlayer1+ eggsPlayer2;
            for (int i=1; i<= totalEggs; i++ )
            {
                string command = Console.ReadLine(); //Победител - текст - "one" или "two"
                if (command == "one")
                {
                    eggsPlayer2--; //първият играч печели => яйцата на втория намаляват с едно 
                }
                else if (command == "two") 
                {
                    eggsPlayer1--; //вторият играч печели => яйцата на първия намаляват с едно
                }
                else //Играта приключва, ако някой от играчите остане без яйца или до получаване на команда "End"
                {
                    Console.WriteLine($"Player one has {eggsPlayer1} eggs left.");
                    Console.WriteLine($"Player two has {eggsPlayer2} eggs left.");
                    break;
                }

                if (eggsPlayer1 == 0)
                {
                    Console.WriteLine($"Player one is out of eggs. Player two has {eggsPlayer2} eggs left.");
                    break;
                }
                else if(eggsPlayer2 == 0)
                {
                    Console.WriteLine($"Player two is out of eggs. Player one has {eggsPlayer1} eggs left.");
                    break;
                }
            }
        }
    }
}
