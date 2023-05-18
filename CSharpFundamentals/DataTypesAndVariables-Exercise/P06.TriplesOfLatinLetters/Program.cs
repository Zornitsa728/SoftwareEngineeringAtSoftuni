using System.ComponentModel;

namespace P06.TriplesOfLatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine()); // 97 - 122;

            for (char first = 'a'; first < 'a' + input; first++)
            {
                //char firstLetter = (char)first; 
                for (char second = 'a'; second < 'a' + input; second++)
                {
                    //char secondLetter = (char)second;
                    for (char third = 'a'; third < 'a' + input; third++)
                    {
                        //char thirdLetter = (char)third;
                        Console.Write($"{first}{second}{third}");
                        Console.WriteLine();
                    }

                }

            }
        }
    }
}