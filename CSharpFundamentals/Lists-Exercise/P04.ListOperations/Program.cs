using System;
using System.Linq;

namespace P04.ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                if (input.Contains("Add"))
                {
                    AddNumber(input, numbers);
                }
                else if (input.Contains("Insert"))
                {
                    InsertNumberToIndex(input, numbers);
                }
                else if (input.Contains("Remove"))
                {
                    RemoveIndex(input, numbers);
                }
                else
                {
                    if (input.Contains("left"))
                    {
                        ShifLeftNumbers(input, numbers);
                    }
                    else
                    {
                        ShifRightNumbers(input, numbers);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        static List<int> AddNumber(string input, List<int> numbers)
        {
            string[] command = input.Split();
            int numberToAdd = int.Parse(command[1]);
            numbers.Add(numberToAdd);
            return numbers;
        }

        static List<int> InsertNumberToIndex(string input, List<int> numbers)
        {
            string[] command = input.Split();
            int numberToInsert = int.Parse(command[1]);
            int index = int.Parse(command[2]);
            if (IsIndexValid(index, numbers))
            {
                numbers.Insert(index, numberToInsert);
            }

            return numbers;
        }

        static bool IsIndexValid(int index, List<int> numbers)
        {
            if (index >= 0 && index < numbers.Count)
            {
                return true;
            }

            Console.WriteLine("Invalid index");
            return false;
        }

        static List<int> RemoveIndex(string input, List<int> numbers)
        {
            string[] command = input.Split();
            int indexToRemove = int.Parse(command[1]);
            if (IsIndexValid(indexToRemove, numbers))
            {
                numbers.RemoveAt(indexToRemove);
            }
            return numbers;
        }
        
        static List<int> ShifLeftNumbers(string input, List<int> numbers)
        {
            string[] command = input.Split();
            int shiftCount = int.Parse(command[2]);
            for (int shift = 0; shift < shiftCount; shift++)
            {
                int firstNum = numbers[0];
                numbers.Add(firstNum);
                numbers.RemoveAt(0);
            }
            return numbers;
        }

        static List<int> ShifRightNumbers(string input, List<int> numbers)
        {
            string[] command = input.Split();
            int shiftCount = int.Parse(command[2]);
            for (int shift = 0; shift < shiftCount; shift++)
            {
                int lastNum = numbers[numbers.Count - 1];
                numbers.Insert(0, lastNum);
                numbers.RemoveAt(numbers.Count - 1);
            }

            return numbers;
        }
    }
}