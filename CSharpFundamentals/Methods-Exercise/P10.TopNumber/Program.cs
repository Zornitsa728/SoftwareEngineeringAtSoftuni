namespace P10.TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rangeNum = int.Parse(Console.ReadLine());
            TopNumbers(rangeNum);
        }

        static void TopNumbers(int rangeNum)
        {
            for (int i = 9; i <= rangeNum; i++)
            {
                int sumDigits = 0;
                int copyNum = i;
                int countDigits = 0;

                while (copyNum != 0)
                {
                    sumDigits += copyNum % 10;
                    copyNum /= 10;
                    countDigits++;

                }

                if (sumDigits % 8 == 0)
                {
                    copyNum = i;

                    for (int currDigit = 1; currDigit <= countDigits; currDigit++)
                    {
                        if ((copyNum % 10) % 2 != 0)
                        {
                            Console.WriteLine(i);
                            break;
                        }
                        else
                        {
                            copyNum /= 10;
                        }
                    }
                }

            }
        }
    }
}