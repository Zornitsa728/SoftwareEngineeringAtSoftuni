using System;

namespace P01.OldBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string favoriteBook = Console.ReadLine();
            string book;
            int count = 0;

            while ((book = Console.ReadLine()) != favoriteBook && book != "No More Books")
            {
                count ++;
            }

            if (book == "No More Books")
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {count} books.");
            }
            else
            {
                Console.WriteLine($"You checked {count} books and found it.");
            }
        }
    }
}
