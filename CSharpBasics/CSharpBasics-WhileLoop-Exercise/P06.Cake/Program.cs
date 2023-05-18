using System;

namespace P06.Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int wholeCake = width * length;
            string input;

            while ((input = Console.ReadLine()) != "STOP")
            {
                int piece = int.Parse(input);

                wholeCake -= piece;

                if (wholeCake <= 0)
                {
                    break;
                }
            }

            if (input == "STOP")
            {
                Console.WriteLine($"{wholeCake} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(wholeCake)} pieces more.");
            }
        }
    }
}
