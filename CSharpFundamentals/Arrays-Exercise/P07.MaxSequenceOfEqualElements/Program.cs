int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray(); // receiving numbers
int[] equalElements = new int [1]; // final result of equal elements
int maxCount = 0; //best counter
int count = 0; // counter for sequence

for (int currentNumber = 0; currentNumber < numbers.Length - 1; currentNumber++)
{
    if (numbers[currentNumber] == numbers[1 + currentNumber])
    {
        count++;
        if (count > maxCount)
        {
            maxCount = count;
            equalElements = new int [count+1]; // equal elements count (+ next el.) will be the length of the new array 

            for (int i = 0; i <= count; i++) // loop for filling the new array with the equal number
            {
                equalElements[i] = numbers[currentNumber];
            }
        }
    }
    else // if sequence is lost -> count starting from the beginning
    {
        count = 0;
    }
}

if (maxCount == 0) // if there aren't any sequence of equal elements -> the first one will allways be the result
{
    Console.WriteLine(numbers[0]);
}
else
{
    Console.WriteLine(string.Join(" ", equalElements));
}
