namespace P07.ListManipulationAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> originalNumbers = new List<int>();

            foreach (int number in numbers)
            {
                originalNumbers.Add(number);
            }

            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                List<string> inputList = input.Split().ToList();
                string command = inputList[0];

                if (command == "Add")
                {
                    AddNumbers(numbers, inputList);
                }
                else if (command == "Remove")
                {
                    RemoveNumbers(numbers, inputList);
                }
                else if (command == "RemoveAt")
                {
                    RemoveNumbersAt(numbers, inputList);
                }
                else if (command == "Insert")
                {
                    InsertNumbers(numbers, inputList);
                }
                else if (command == "Contains")
                {
                    ContainsNumbers(numbers, inputList);
                }
                else if (command == "PrintEven")
                {
                    PrintEven(numbers, inputList);
                }
                else if (command == "PrintOdd")
                {
                    PrintOdd(numbers, inputList);
                }
                else if (command == "GetSum")
                {
                    PrintSum(numbers, inputList);
                }
                else if (command == "Filter")
                {
                    Filter(numbers, inputList);
                }
            }

            if (numbers.Count != originalNumbers.Count)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
            else if (numbers.Count == originalNumbers.Count)
            {
                int count = 0;
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] != originalNumbers[i])
                    {
                        Console.WriteLine(string.Join(" ", numbers));
                        break;
                    }
                }
            }
        }

        static void ContainsNumbers(List<int> numbers, List<string> inputList)
        {
            int numberToContain = int.Parse(inputList[1]);
            bool containsNum = numbers.Contains(numberToContain);
            if (containsNum == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
        }

        static void PrintOdd(List<int> numbers, List<string> inputList)
        {
            foreach (int number in numbers)
            {
                if (number % 2 != 0)
                {
                    Console.Write(number + " ");
                }
            }
            Console.WriteLine();
        }

        static void PrintEven(List<int> numbers, List<string> inputList)
        {
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    Console.Write(number + " ");
                }
            }

            Console.WriteLine();
        }

        static void PrintSum(List<int> numbers, List<string> inputList)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            Console.WriteLine(sum);
        }

        static void Filter(List<int> numbers, List<string> inputList)
        {
            string condition = inputList[1];
            int number = int.Parse(inputList[2]);

            if (condition == "<")
            {
                foreach (int currNum in numbers)
                {
                    if (currNum < number)
                    {
                        Console.Write(currNum + " ");
                    }
                }
            }
            else if (condition == ">")
            {
                foreach (int currNum in numbers)
                {
                    if (currNum > number)
                    {
                        Console.Write(currNum + " ");
                    }
                }
            }
            else if (condition == ">=")
            {
                foreach (int currNum in numbers)
                {
                    if (currNum >= number)
                    {
                        Console.Write(currNum + " ");
                    }
                }
            }
            else if (condition == "<=")
            {
                foreach (int currNum in numbers)
                {
                    if (currNum <= number)
                    {
                        Console.Write(currNum + " ");
                    }
                }
            }

            Console.WriteLine();
        }

        static List<int> AddNumbers(List<int> numbers, List<string> inputList)
        {
            int numberToAdd = int.Parse(inputList[1]);
            numbers.Add(numberToAdd);

            return numbers;
        }

        static List<int> RemoveNumbers(List<int> numbers, List<string> inputList)
        {
            int numberToRemove = int.Parse(inputList[1]);
            numbers.Remove(numberToRemove);

            return numbers;
        }

        static List<int> RemoveNumbersAt(List<int> numbers, List<string> inputList)
        {
            int numberToRemoveAtIndex = int.Parse(inputList[1]);
            numbers.RemoveAt(numberToRemoveAtIndex);

            return numbers;
        }

        static List<int> InsertNumbers(List<int> numbers, List<string> inputList)
        {
            int numberToInsert = int.Parse(inputList[1]);
            int atIndex = int.Parse(inputList[2]);
            numbers.Insert(atIndex, numberToInsert);

            return numbers;
        }
    }
}