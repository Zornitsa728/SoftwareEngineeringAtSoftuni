namespace P01.SortNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine()); 
            int numThree = int.Parse(Console.ReadLine());
            int minValue = int.MaxValue;
            int maxValue = int.MinValue;
            int middleValue = 0;
            
            if (numOne >= numTwo && numOne >= numThree)
            {
                maxValue = numOne;
                if (numTwo < numThree)
                {
                    minValue = numTwo;
                    middleValue = numThree;
                }
                else
                {
                    minValue = numThree;
                    middleValue = numTwo;
                }
            }
            else if (numTwo >= numOne && numTwo >= numThree)
            {
                maxValue = numTwo;
                if (numOne < numThree)
                {
                    minValue = numOne;
                    middleValue = numThree;
                }
                else
                {
                    minValue = numThree;
                    middleValue = numOne;
                }
            }
            else if (numThree >= numOne && numThree >= numTwo)
            {
                maxValue = numThree;
                if (numTwo < numOne)
                {
                    minValue = numTwo;
                    middleValue = numOne;
                }
                else
                {
                    minValue = numOne;
                    middleValue = numTwo;
                }
            }

            Console.WriteLine(maxValue);
            Console.WriteLine(middleValue);
            Console.WriteLine(minValue);
        }
    }
}