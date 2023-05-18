namespace P01.IntegerOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int fourthNum = int.Parse(Console.ReadLine());

            int addition = firstNum + secondNum;
            int division = addition / thirdNum;
            long multiplication = (long)division * fourthNum;
            Console.WriteLine(multiplication);
        }
    }
}