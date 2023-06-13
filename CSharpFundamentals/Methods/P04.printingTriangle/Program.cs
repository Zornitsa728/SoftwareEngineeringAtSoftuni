using System.Runtime.InteropServices;

namespace P04.printingTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            printTriangle(number);
        }

        static void printTriangle(int number)
        {
            for (int print = 1; print <= number; print++)
            {
                for(int currNum = 1; currNum <= print; currNum++)
                {
                    Console.Write(currNum + " ");
                }

                Console.WriteLine();
            }

            for (int print = number; print > 1; print--)
            {
                for (int currNum = 1; currNum < print ; currNum++)
                {
                    Console.Write(currNum + " ");
                }

                Console.WriteLine();
            }
        }
    }
}