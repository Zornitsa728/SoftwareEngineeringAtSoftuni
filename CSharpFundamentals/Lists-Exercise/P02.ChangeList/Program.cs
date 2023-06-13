namespace P02.ChangeList
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
                if (input.Contains("Delete"))
                {
                    DeleteNumbers(input, numbers);
                }
                else
                {
                    InsertNumberToPosition(input, numbers);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        static List<int> InsertNumberToPosition(string input, List<int> numbers)
        {
            string[] command = input.Split();
            int numberToInsert = int.Parse(command[1]);
            int position = int.Parse(command[2]);
            numbers.Insert(position, numberToInsert);
            return numbers;
        }

        static List<int> DeleteNumbers(string input, List<int> numbers)
        {
            string[] command = input.Split();
            int numberToDelete = int.Parse(command[1]);
            numbers.RemoveAll(item => item == numberToDelete);
            return numbers;
        }
    }
}