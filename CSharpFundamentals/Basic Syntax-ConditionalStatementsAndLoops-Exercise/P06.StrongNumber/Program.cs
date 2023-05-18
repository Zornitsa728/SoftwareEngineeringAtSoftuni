using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        string number = Console.ReadLine();
        long factorial;
        long resultNumber = 0;
        //int count = 0;

        for (int i = 0; i < number.Length; i++)
        {
            factorial = 1;
            for (int j = number[i] - '0'; j > 1; j--)
            {
                factorial *= j;

            }
            resultNumber += factorial;
        }

        if (resultNumber == int.Parse(number))
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }

        //------------ another version ---------------
        //for (int i = 0; i < number.Length; i++)
        //{
        //    factorial = 0;
        //    for (int j = number[i] - '0'; j > 1; j--)
        //    {
        //        if (count == 0)
        //        {
        //            factorial += j * (j - 1);
        //            count++;
        //        }
        //        else
        //        {
        //            factorial = factorial * (j - 1);
        //        }

        //    }

        //    if (number[i]-'0' == 0)
        //    {
        //        factorial += 1;
        //    }
        //    else if (number[i] - '0' == 1 && count == 0)
        //    {
        //        factorial += 1;
        //    }
        //    resultNumber += factorial;
        //    count = 0;
        //}

        //if (resultNumber == int.Parse(number))
        //{
        //    Console.WriteLine("yes");
        //}
        //else
        //{
        //    Console.WriteLine("no");
        //}

        //-------- another version -----------------

        //int number = int.Parse(Console.ReadLine());
        //int input = number;
        //int factorialSum = 0;


        //while (number > 0)
        //{
        //    int lastNumber = number % 10;
        //    int factorialNum = 1;
        //    for (int i = 1; i <= lastNumber; i++)
        //    {
        //        factorialNum *= i;
        //    }

        //    factorialSum += factorialNum;
        //    number /= 10;
        //}

        //if (input == factorialSum)
        //{
        //    Console.WriteLine("yes");
        //}
        //else
        //{
        //    Console.WriteLine("no");
        //}
    }
}