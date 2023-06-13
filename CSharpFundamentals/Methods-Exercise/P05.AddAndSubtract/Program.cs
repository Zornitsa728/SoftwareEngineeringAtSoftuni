namespace P05.AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            SumOfTwoNumbers(firstNum, secondNum);
            Console.WriteLine(SubtractTwoNumbers(SumOfTwoNumbers(firstNum, secondNum), thirdNum));
        }

        static int SumOfTwoNumbers(int firstNum, int secondNum)
        {
            int addResult = firstNum + secondNum;
            return addResult;
        }

        static int SubtractTwoNumbers(int addResult, int thurdNum)
        {
            int subtractResult = addResult - thurdNum;
            return subtractResult;
        }

    }
}