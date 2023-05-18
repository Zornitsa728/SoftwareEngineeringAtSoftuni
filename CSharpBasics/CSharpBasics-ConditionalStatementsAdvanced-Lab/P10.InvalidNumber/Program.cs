using System;

namespace P10.InvalidNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Дадено число е валидно, ако е в диапазона [100…200] или е 0. 
            int number = int.Parse(Console.ReadLine());

            if ((number >= 100 && number <= 200) || number == 0)
            {
                
            }
            else
                Console.WriteLine("invalid");
        }
    }
}
