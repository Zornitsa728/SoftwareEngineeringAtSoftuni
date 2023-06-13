namespace P08.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            Console.WriteLine($"{DivideTwoFactorials(firstNum, secondNum):f2}");
        }

        static double CalculateFactorial(double number)
        {
            double result = 1;

            for (int i = 1; i < number; i++)
            {
                result *= (i + 1);
            }

            return result;
        }

        static double DivideTwoFactorials(double firstNum, double secondNum)
        {
            double result = CalculateFactorial(firstNum) / CalculateFactorial(secondNum);

            return result;
        }
    }
}