namespace P05.BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> bombNums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while (IsThereBomb(numbers, bombNums))
            {
                RemoveBombNums(numbers, bombNums);
            }

            Console.WriteLine(SumOfRemainingElements(numbers));
        }

        static bool IsThereBomb(List<int> numbers, List<int> bombNums)
        {
            if (FindBombIndex(numbers, bombNums) != -1)
            {
                return true;
            }

            return false;
        }
        static int FindBombIndex(List<int> numbers, List<int> bombNums)
        {
            int bombIndex = -1;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (bombNums[0] == numbers[i])
                {
                    bombIndex = i;
                    break;
                }
            }

            return bombIndex;
        }
        static bool IsIndexValid(List<int> numbers, List<int> bombNums)
        {
            int indexRange = bombNums[1];
            int bombIndex = FindBombIndex(numbers, bombNums);
            if (indexRange + bombIndex < numbers.Count - 1 && bombIndex - indexRange >= 0)
            {
                return true;
            }

            return false;
        }

        static List<int> RemoveBombNums(List<int> numbers, List<int> bombNums)
        {
            int indexRange = bombNums[1];
            int bombIndex = FindBombIndex(numbers, bombNums);

            if (IsIndexValid(numbers, bombNums))
            {
                numbers.RemoveRange(bombIndex, indexRange + 1);
                numbers.RemoveRange(bombIndex - indexRange, indexRange);
            }
            else
            {
                RemoveBombNumsWhenIndexIsNotValid(numbers, bombNums, indexRange, bombIndex);
            }

            return numbers;
        }

        static List<int> RemoveBombNumsWhenIndexIsNotValid(List<int> numbers, List<int> bombNums, int indexRange, int bombIndex)
        {
            int startIndex = bombIndex - indexRange;
            int endIndex = numbers.Count - startIndex;
            if (startIndex < 0)
            {
                startIndex = 0;
                endIndex = bombIndex + (indexRange + 1);
                if (endIndex > numbers.Count)
                {
                    endIndex = numbers.Count;
                }
                numbers.RemoveRange(startIndex, endIndex);
                return numbers;
            }

            numbers.RemoveRange(startIndex, endIndex);
            return numbers;
        }
        static int SumOfRemainingElements(List<int> numbers)
        {
            int result = 0;
            foreach (int number in numbers)
            {
                result += number;
            }

            return result;
        }
    }
}