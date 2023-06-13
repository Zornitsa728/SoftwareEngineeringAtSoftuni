namespace P09.GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int firstInput = int.Parse(Console.ReadLine());
                int secondInput = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(firstInput, secondInput));
            }
            else if (type == "char")
            {
                char firstInput = char.Parse(Console.ReadLine());
                char secondInput = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(firstInput, secondInput));
            }
            else if (type == "string")
            {
                string firstInput = Console.ReadLine();
                string secondInput = Console.ReadLine();
                Console.WriteLine(GetMax(firstInput, secondInput));
            }
        }

        static int GetMax(int firstNum, int secondNum)
        {
            return Math.Max(firstNum, secondNum);
        }

        static char GetMax(char firstChar, char secondChar)
        {
            return (char)Math.Max(firstChar, secondChar);
        }
        static string GetMax(string firstText, string secondText)
        {
            string biggestValue = "";
            char[] firstChars = firstText.ToCharArray();
            char[] secondChars = secondText.ToCharArray();
            //int length = 0;
            //int countFirst = 0;
            //int countSecond = 0;

            if (firstChars[0] > secondChars[0])
            {
                biggestValue = firstText;
            }
            else
            {
                biggestValue = secondText;
            }

            //if (firstText.Length >= secondText.Length) // always gets the shorter length, because we dont want range exception
            //{
            //    length = secondText.Length;
            //}
            //else if (secondText.Length > firstText.Length)
            //{
            //    length = firstText.Length;
            //}

            //for (int i = 0; i < length; i++)
            //{
            //    if (firstChars[i] > secondChars[i])
            //    {
            //        countFirst++;
            //    }
            //    else if (firstChars[i] < secondChars[i])
            //    {
            //        countSecond++;
            //    }
            //}

            //if (countFirst > countSecond)
            //{
            //    biggestValue = firstText;
            //}
            //else
            //{
            //    biggestValue = secondText;
            //}

            return biggestValue;
        }
    }
}