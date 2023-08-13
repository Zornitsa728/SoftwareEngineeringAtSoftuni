namespace P02.CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split();

            Console.WriteLine(SumOfTwoStrings(text[0], text[1]));
        }

        static int SumOfTwoStrings(string firstText, string secondText)
        {
            int sum = 0;
            int checkForLength = firstText.Length.CompareTo(secondText.Length);
            string shorterText = "";
            string longerText = "";

            if (checkForLength == -1 || checkForLength == 0)
            {
                shorterText = firstText;
                longerText = secondText;
            }
            else
            {
                shorterText = secondText;
                longerText = firstText;
            }

            for (int currChar = 0; currChar < longerText.Length; currChar++)
            {
                if (currChar >= shorterText.Length)
                {
                    sum += longerText[currChar];
                    continue;
                }

                sum += firstText[currChar] * secondText[currChar];
            }

            return sum;
        }
    }
}