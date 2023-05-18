namespace P12._12._RefactorSpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            bool isSpecialNum = false;

            for (int currentNum = 1; currentNum <= range; currentNum++)
            {
                int checkNum = currentNum;
                int sum = 0;
                while (checkNum > 0)
                {
                    sum += checkNum % 10;
                    checkNum = checkNum / 10;
                }

                isSpecialNum = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", currentNum, isSpecialNum);
            }
        }
    }
}