int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] equalElements = new int [1];
int maxCount = 0;
int count = 0;

for (int currentNumber = 0; currentNumber < numbers.Length - 1; currentNumber++)
{
    if (numbers[currentNumber] == numbers[1 + currentNumber])
    {
        count++;
        if (count > maxCount)
        {
            maxCount = count;
            equalElements = new int [count+1];
            for (int i = 0; i <= count; i++)
            {
                equalElements[i] = numbers[currentNumber];
            }
        }
    }
    else
    {
        count = 0;
    }
}

Console.WriteLine(string.Join(" ",equalElements));