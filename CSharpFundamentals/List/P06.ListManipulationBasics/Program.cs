namespace P06.ListManipulationBasics
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
            }

            Console.WriteLine(string.Join(" ", numbers));
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