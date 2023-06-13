namespace P09.PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                Console.WriteLine(IsNumberPalindrome(input));
            }
        }

        static string ReverseString(string text)
        {
            char[] arrayToReverse = text.ToCharArray();
            Array.Reverse(arrayToReverse);
            return new string(arrayToReverse);
        }

        static bool IsNumberPalindrome(string input)
        {
            if (input == (ReverseString(input)))
            {
                return true;
            }

            return false;
        }


        //static bool IsNumberPalindrome(string number)
        //{
        //    bool result = false;
        //    string reversedNum = string.Empty;

        //    for (int i = number.Length - 1; i >= 0 ; i--)
        //    {
        //        reversedNum += number[i].ToString();
        //    }

        //    if (number == reversedNum)
        //    {
        //        result = true;
        //    }

        //    return result;
        //}
    }
}