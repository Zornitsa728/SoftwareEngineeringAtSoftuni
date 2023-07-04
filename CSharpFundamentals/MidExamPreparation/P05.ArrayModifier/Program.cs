namespace P05.ArrayModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArray = command.Split();

                if (cmdArray[0] == "swap")
                {
                    SwapTwoNums(input, cmdArray);
                }
                else if (cmdArray[0] == "multiply")
                {
                    MultiplyTwoNums(input, cmdArray);
                }
                else if (cmdArray[0] == "decrease")
                {
                    DecreaseAllElements(input, cmdArray);
                }
            }

            Console.WriteLine(string.Join(", ", input));
        }

        static void SwapTwoNums(int[] input, string[] cmdArray) 
        {
            int firstIndex = int.Parse(cmdArray[1]);
            int secondIndex = int.Parse(cmdArray[2]);
            int numberAtFirstIndex = input[firstIndex];

            input[firstIndex] = input[secondIndex];
            input[secondIndex] = numberAtFirstIndex;
        }

        static void MultiplyTwoNums(int[] input, string[] cmdArray)
        {
            int firstIndex = int.Parse(cmdArray[1]);
            int secondIndex = int.Parse(cmdArray[2]);
            int multypliedNums = input[firstIndex] * input[secondIndex];
            input[firstIndex] = multypliedNums;
        }

        static void DecreaseAllElements(int[] input, string[] cmdArray)
        {
            for (int i = 0; i < input.Length; i++)
            {
                input[i]--;
            }
        }
    }
}