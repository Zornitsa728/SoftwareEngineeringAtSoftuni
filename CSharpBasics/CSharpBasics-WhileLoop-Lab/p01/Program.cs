using System;

namespace p01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text;

            while ((text = Console.ReadLine()) != "Stop")
            {
                Console.WriteLine(text);
            }
        }
    }
}
