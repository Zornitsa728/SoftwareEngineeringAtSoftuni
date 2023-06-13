using System.Diagnostics.Metrics;

namespace P11.ArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();

                if (command[0] == "exchange")
                {
                    ExchangeArray(command, numbers);
                }
                else if (command[0] == "max")
                {
                    MaxOddOrEven(command, numbers);
                }
                else if (command[0] == "min")
                {
                    MinOddOrEven(command, numbers);
                }
                else if (command[0] == "first")
                {
                    if (command[2] == "odd")
                    {
                        FirstOdd(command, numbers);
                    }
                    else
                    {
                        FirstEven(command, numbers);
                    }
                }
                else if (command[0] == "last")
                {
                    if (command[2] == "odd")
                    {
                        LastOdd(command, numbers);
                    }
                    else
                    {
                        LastEven(command, numbers);
                    }
                }
            }

            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }

        static int[] ExchangeArray(string[] command, int[] numbers)
        {
            int exchangeIndex = int.Parse(command[1]);

            if (exchangeIndex < 0 || exchangeIndex >= numbers.Length)
            {
                Console.WriteLine("Invalid index");
                return numbers;
            }

            for (int rotations = 0; rotations <= exchangeIndex; rotations++)
            {
                int firstNum = numbers[0];

                for (int currIndex = 0; currIndex < numbers.Length - 1; currIndex++)
                {
                    numbers[currIndex] = numbers[currIndex + 1];
                }

                numbers[numbers.Length - 1] = firstNum;
            }

            return numbers;
        }

        static void MaxOddOrEven(string[] command, int[] numbers)
        {
            int result = -1;
            int maxValue = int.MinValue;
            if (command[1] == "odd")
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 != 0 && numbers[i] >= maxValue)
                    {
                        maxValue = numbers[i];
                        result = i;
                    }
                }
            }
            else
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0 && numbers[i] >= maxValue)
                    {
                        maxValue = numbers[i];
                        result = i;
                    }
                }
            }

            if (result == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(result);
            }
        }

        static void MinOddOrEven(string[] command, int[] numbers)
        {
            int result = -1;
            int minValue = int.MaxValue;
            if (command[1] == "odd")
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 != 0 && numbers[i] <= minValue)
                    {
                        minValue = numbers[i];
                        result = i;
                    }
                }
            }
            else
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0 && numbers[i] <= minValue)
                    {
                        minValue = numbers[i];
                        result = i;
                    }
                }
            }

            if (result == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(result);
            }
        }

        static void FirstOdd(string[] command, int[] numbers)
        {
            int countNum = int.Parse(command[1]);
            int[] result = new int[countNum]; //first 2 odd

            if (countNum > numbers.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            int counter = 0;
            int saveIndex = 0;
            for (int currCount = 0; currCount < countNum; currCount++)
            {
                for (int currIndex = saveIndex; currIndex < numbers.Length; currIndex++)
                {
                    if (numbers[currIndex] % 2 != 0 && counter < countNum)
                    {
                        saveIndex = currIndex + 1;
                        result[currCount] = numbers[currIndex];
                        counter++;
                        break;
                    }
                }

                if (counter == 0)
                {
                    Console.WriteLine("[]");
                    return;
                }
            }

            if (countNum == counter)
            {
                Console.WriteLine($"[{string.Join(", ", result)}]");
            }
            else
            {
                int[] newResult = new int[counter];
                for (int i = 0; i < newResult.Length; i++)
                {
                    newResult[i] = result[i];
                }

                Console.WriteLine($"[{string.Join(", ", newResult)}]");
            }
        }

        static void FirstEven(string[] command, int[] numbers)
        {
            int countNum = int.Parse(command[1]);
            int[] result = new int[countNum]; //first 2 odd

            if (countNum > numbers.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            int counter = 0;
            int saveIndex = 0;
            for (int currCount = 0; currCount < countNum; currCount++)
            {
                for (int currIndex = saveIndex; currIndex < numbers.Length; currIndex++)
                {
                    if (numbers[currIndex] % 2 == 0 && counter < countNum)
                    {
                        saveIndex = currIndex + 1;
                        result[currCount] = numbers[currIndex];
                        counter++;
                        break;
                    }
                }

                if (counter == 0)
                {
                    Console.WriteLine("[]");
                    return;
                }
            }


            if (countNum == counter)
            {
                Console.WriteLine($"[{string.Join(", ", result)}]");
            }
            else
            {
                int[] newResult = new int[counter];
                for (int i = 0; i < newResult.Length; i++)
                {
                    newResult[i] = result[i];
                }

                Console.WriteLine($"[{string.Join(", ", newResult)}]");
            }
        }
        static void LastOdd(string[] command, int[] numbers)
        {
            int countNum = int.Parse(command[1]);
            int[] result = new int[countNum]; //last 2 odd
            if (countNum > numbers.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            int counter = 0;
            int saveIndex = numbers.Length - 1;
            for (int lastCount = countNum - 1; lastCount >= 0; lastCount--)
            {
                for (int lastIndex = saveIndex; lastIndex >= 0; lastIndex--)
                {
                    if (numbers[lastIndex] % 2 != 0 && counter < countNum)
                    {
                        saveIndex = lastIndex - 1;
                        result[lastCount] = numbers[lastIndex];
                        counter++;
                        break;
                    }
                }

                if (counter == 0)
                {
                    Console.WriteLine("[]");
                    return;
                }
            }

            if (result.Length == counter)
            {
                Console.WriteLine($"[{string.Join(", ", result)}]");
            }
            else
            {
                for (int i = 0; i < counter; i++)
                {
                    result[i] = result[result.Length - counter + i];
                }

                int[] newResult = new int[counter];
                for (int i = 0; i < newResult.Length; i++)
                {
                    newResult[i] = result[i];
                }

                Console.WriteLine($"[{string.Join(", ", newResult)}]");
            }
        }

        static void LastEven(string[] command, int[] numbers)
        {
            int countNum = int.Parse(command[1]);
            int[] result = new int[countNum]; //last 2 odd
            if (countNum > numbers.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            int counter = 0;
            int saveIndex = numbers.Length - 1;
            for (int lastCount = countNum - 1; lastCount >= 0; lastCount--)
            {
                for (int lastIndex = saveIndex; lastIndex >= 0; lastIndex--)
                {
                    if (numbers[lastIndex] % 2 == 0 && counter < countNum)
                    {
                        saveIndex = lastIndex - 1;
                        result[lastCount] = numbers[lastIndex];
                        counter++;
                        break;
                    }
                }

                if (counter == 0)
                {
                    Console.WriteLine("[]");
                    return;
                }
            }

            if (result.Length == counter)
            {
                Console.WriteLine($"[{string.Join(", ", result)}]");
            }
            else
            {
                for (int i = 0; i < counter; i++)
                {
                    result[i] = result[result.Length - counter + i];
                }

                int[] newResult = new int[counter];
                for (int i = 0; i < newResult.Length; i++)
                {
                    newResult[i] = result[i];
                }

                Console.WriteLine($"[{string.Join(", ", newResult)}]");
            }

        }
    }
}

