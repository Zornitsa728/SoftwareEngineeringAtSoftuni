namespace P03.Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            switch (input)
            {
                case "add":
                    addition(firstNumber, secondNumber); 
                    break;
                case "multiply":
                    multiply(firstNumber, secondNumber);
                    break;
                case "subtract":
                    subtract(firstNumber, secondNumber);
                    break;
                case "divide":
                    divide(firstNumber, secondNumber);
                    break;
            }
        }

        static void addition(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber + secondNumber);
        }

        static void multiply(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber * secondNumber);
        }

        static void subtract(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber - secondNumber);
        }

        static void divide(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber / secondNumber);
        }
    }
}