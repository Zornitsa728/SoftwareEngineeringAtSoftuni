using System;

namespace p04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int count = 1;

            while (count<=n)
            {
                Console.WriteLine(count);
                count = count *2 + 1;
            }
            //като умножим предишното с 2 и добавим 1
        }
    }
}
