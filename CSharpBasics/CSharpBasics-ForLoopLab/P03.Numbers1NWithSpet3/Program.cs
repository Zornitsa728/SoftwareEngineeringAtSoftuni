using System;

namespace P03.Numbers1NWithSpet3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //отпечатва числата от 1 до n през 3
            for (int i=1; n>=i; i+=3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
