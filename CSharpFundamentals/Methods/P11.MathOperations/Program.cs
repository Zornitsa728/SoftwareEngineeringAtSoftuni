namespace P11.MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            char mathOperator = char.Parse(Console.ReadLine());
            int secondNUmber = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Abs(resultFromCalculation(firstNumber, secondNUmber, mathOperator)));
        }

        static int resultFromCalculation(int firstNumber, int secondNumber, char mathOperator)
        {
            int result = 0;

            if (mathOperator == '*')
            {
                result = firstNumber * secondNumber;
            }
            else if (mathOperator == '+')
            {
                result = firstNumber + secondNumber;
            }
            else if (mathOperator == '-')
            {
                result = secondNumber - firstNumber;
            }
            else
            {
                result = firstNumber / secondNumber;
            }

            return result;
        }
    }
}