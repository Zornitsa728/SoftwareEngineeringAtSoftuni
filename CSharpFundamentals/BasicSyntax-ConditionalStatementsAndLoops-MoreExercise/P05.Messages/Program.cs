namespace P05.MessagesAnotherSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string output = string.Empty;
            int digitLength = 0;
            int mainDigit = 0;
            int offsetOfTheNumber = 0;
            int letterIndex = 0;
            string text = string.Empty;

            for (int i = 0; i < input; i++)
            {
                output = Console.ReadLine();
                digitLength = output.Length;
                mainDigit = output[0] - '0';

                if (mainDigit == 0)
                {
                    text += ' ';
                    continue;
                }
                else if (mainDigit == 8 || mainDigit == 9)
                {
                    offsetOfTheNumber = ((mainDigit - 2) * 3) + 1;
                }
                else
                {
                    offsetOfTheNumber = (mainDigit - 2) * 3;
                }

                letterIndex = (offsetOfTheNumber + digitLength - 1);
                letterIndex = (letterIndex + 'a');
                text += (char)letterIndex;
            }

            Console.WriteLine(text);
        }
    }
}