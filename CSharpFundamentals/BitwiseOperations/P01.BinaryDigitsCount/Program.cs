using System.Threading.Channels;

namespace P01.BinaryDigitsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine()); 
            int binaryDigit = int.Parse(Console.ReadLine()); 
            int counter = 0;

            while (number > 0)
            {
                int currDigit = number % 2;

                if (currDigit == binaryDigit)
                {
                    counter++;
                }

                number /= 2;
            }

            Console.WriteLine(counter);
        }
    }
}