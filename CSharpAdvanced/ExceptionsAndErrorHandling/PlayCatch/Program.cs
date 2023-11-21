namespace PlayCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int counter = 0;

            while (counter != 3)
            {
                string[] cmdArgs = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string cmd = cmdArgs[0];

                try
                {
                    int index = IsIndexValid(cmdArgs[1], numbers.Length);

                    if (cmd == "Replace")
                    {
                        numbers[index] = IsElementValid(cmdArgs[2]);
                    }
                    else if (cmd == "Print")
                    {
                        int endIndex = IsIndexValid(cmdArgs[2], numbers.Length);
                        {
                            int[] result = numbers[index..(endIndex + 1)];

                            Console.WriteLine(string.Join(", ", result));
                        }
                    }
                    else if (cmd == "Show")
                    {
                        Console.WriteLine(numbers[index]);
                    }
                }
                catch (IndexOutOfRangeException ex)
                {
                    counter++;
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException e)
                {
                    counter++;
                    Console.WriteLine(e.Message);
                }
            }

            Console.WriteLine(string.Join(", ", numbers));

            static int IsIndexValid(string index, int arrayLength)
            {
                if (!int.TryParse(index, out int result))
                {
                    throw new FormatException("The variable is not in the correct format!");
                }

                if (result < 0 || result >= arrayLength)
                {
                    throw new IndexOutOfRangeException("The index does not exist!");
                }

                return result;
            }

            static int IsElementValid(string element)
            {
                if (!int.TryParse(element, out int result))
                {
                    throw new FormatException("The variable is not in the correct format!");
                }

                return result;
            }
        }
    }
}