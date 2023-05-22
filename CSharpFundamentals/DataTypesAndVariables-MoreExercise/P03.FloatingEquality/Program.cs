namespace P03.FloatingEquality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            bool isEqual = Math.Abs(firstNum - secondNum) < 0.000001;

            Console.WriteLine(isEqual);

        }
    }
}