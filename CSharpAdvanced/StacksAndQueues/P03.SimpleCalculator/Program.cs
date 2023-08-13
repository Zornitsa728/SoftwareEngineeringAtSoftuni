namespace P03.SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').Reverse().ToArray();
            Stack<string> stack = new Stack<string>(input);
            int sum = 0;
            int firstNum = 0;
            int secondNum = 0;

            while (stack.Count > 0)
            {
                if (stack.Peek() == "-")
                {
                    stack.Pop();
                    secondNum = int.Parse(stack.Pop());
                    sum -= secondNum;
                }
                else if (stack.Peek() == "+")
                {
                    stack.Pop();
                    secondNum = int.Parse(stack.Pop());
                    sum += secondNum;
                }
                else
                {
                    firstNum = int.Parse(stack.Pop());
                    sum += firstNum;
                }
            }

            Console.WriteLine(sum);
        }
    }
}