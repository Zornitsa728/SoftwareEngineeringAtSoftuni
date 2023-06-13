namespace P04.PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            if (IsDigitsTwoOrMore(password) && IsSyntaxCorrect(password) && IsLengthValid(password))
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (!IsLengthValid(password))
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }

                if (!IsSyntaxCorrect(password))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }

                if (!IsDigitsTwoOrMore(password))
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
        }

        static bool IsLengthValid(string password)
        {
            bool isValid = password.Length >= 6 && password.Length <= 10;
            return isValid;
        }

        static bool IsSyntaxCorrect (string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (!char.IsLetterOrDigit(password[i]))
                {
                    return false;
                }
            }

            return true;
        }

        static bool IsDigitsTwoOrMore(string password)
        {
            int countDigit = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                {
                    countDigit++; 
                }
            }

            if (countDigit < 2)
            {
                return false;
            }

            return true;
        }

    }
}