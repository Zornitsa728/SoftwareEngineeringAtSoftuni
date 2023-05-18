using System;

namespace P02.Numbers_N_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //печата числата от n до 1 в обратен ред

            for (int a = n; a >= 1; a--)
            {
                Console.WriteLine(a);
            }
        }
    }
}
