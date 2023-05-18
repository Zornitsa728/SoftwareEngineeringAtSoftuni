using System;

namespace P06.OperationsBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	N1 – цяло число в интервала [0...40 000]
            int n1 = int.Parse(Console.ReadLine());
            //N2 – цяло число в интервала[0...40 000]
            int n2 = int.Parse(Console.ReadLine());
            //Оператор – един символ измежду: „+“, „-“, „*“, „/“, „%“
            char operation = char.Parse(Console.ReadLine());
            double result = 0;
            //Събиране(+), Изваждане(-), Умножение(*), Деление(/) и Модулно деление(%).
            if (operation == '+')  
            {
                result = n1 + n2;
            }
            else if (operation == '-')
            {
                result= n1 - n2;
            }
            else if (operation == '*')
            {
                result= n1 * n2;
            }
            else if (operation == '/')
            {
                if (n1 == 0)
                {
                    Console.WriteLine($"Cannot divide {n2} by zero");
                }
                else if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    result = (double)n1 / n2;
                }
                
            }
            else if (operation == '%')
            {
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");

                }
                else
                {
                    result = n1 % n2;
                }
                
            }

            if (operation == '+' || operation == '-' || operation == '*')
            {
                //При събиране, изваждане и умножение да се отпечатат резултата и дали той е четен или нечетен.
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{n1} {operation} {n2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} {operation} {n2} = {result} - odd");

                }
            }
            else if (operation == '/' && n2 != 0)
            {
            
                Console.WriteLine($"{n1} {operation} {n2} = {result:f2}");
            }
            else if (operation == '%' && n2 != 0)
            {
                Console.WriteLine($"{n1} {operation} {n2} = {result}");
            }


        }
    }
}
