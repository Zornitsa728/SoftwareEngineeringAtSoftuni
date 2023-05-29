using System.Runtime.Serialization;

namespace P06.EqualSums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            int specialNum = 0;
            int leftSide = 0;
            bool isTrue = false;

            foreach (int number in numbers)
            {
                sum += number;
            }
            
            for (int currentNum = 0; currentNum < numbers.Length; currentNum++)
            {
                int rightSide = (sum - numbers[currentNum]) / 2;
                
                if (rightSide == leftSide)
                {
                    specialNum = currentNum;
                    isTrue = true;
                    break;
                }

                leftSide += numbers[currentNum];
            }
            
            if (isTrue == false)
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine(specialNum);
            }
        }
    }
}