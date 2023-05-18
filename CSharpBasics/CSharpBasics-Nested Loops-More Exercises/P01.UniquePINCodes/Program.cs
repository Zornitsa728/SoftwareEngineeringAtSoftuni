using System;
using System.Threading;

namespace P01.UniquePINCodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	Горната граница на първото число - цяло число в диапазона [1...9]
            int end1 = int.Parse(Console.ReadLine());
            //•	Горната граница на второто число - цяло число в диапазона [1...9]
            int end2 = int.Parse(Console.ReadLine());
            //•	Горната граница на третото число - цяло число в диапазона [1...9]
            int end3 = int.Parse(Console.ReadLine());
            //•	Първата и третата цифра трябва да бъдат четни.
            //•	Втората цифра трябва да бъде просто число в диапазона[2...7].

            for (int startOne = 2; startOne <= end1; startOne+=2)
            {
                for (int startTwo = 2; startTwo <= end2; startTwo++)
                {
                    for (int startThree = 2; startThree <= end3; startThree+=2)
                    {
                        if (startOne % 2 == 0 && startThree % 2 == 0)
                        {
                            if (startTwo != 4 && startTwo != 6 && startTwo <=7)
                            {
                                Console.WriteLine($"{startOne} {startTwo} {startThree}");
                            }
                        }  
                    }
                }
            }


        }
    }
}
