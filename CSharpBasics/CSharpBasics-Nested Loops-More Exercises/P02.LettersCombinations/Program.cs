using System;

namespace P02.LettersCombinations
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Малка буква от английската азбука за начало на интервала – от ‘a’ до ‚z’
            char start = char.Parse(Console.ReadLine());
            //Малка буква от английската азбука за край на интервала  – от първата буква до ‚z’
            char end = char.Parse(Console.ReadLine());
            //Малка буква от английската азбука – от ‘a’ до ‚z’ – като комбинациите съдържащи тази буквата се пропускат.
            char miss = char.Parse(Console.ReadLine());
            int count = 0;

            for (int a = start; a <= end; a++)
            {
                for (int b = start; b <= end; b++)
                {
                    for (int i = start; i <= end; i++)
                    {
                        if (a != miss && b != miss && i != miss)
                        {
                            count++;
                            char firstLetter = Convert.ToChar(a);
                            char secondLetter = Convert.ToChar(b);
                            char thirdLetter = Convert.ToChar(i);
                            Console.Write($"{firstLetter}{secondLetter}{thirdLetter} ");
                        }
                    }
                }
            }
            Console.Write(count);
        }
    }
}
