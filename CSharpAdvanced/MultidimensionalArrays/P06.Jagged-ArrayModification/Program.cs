int rows = int.Parse(Console.ReadLine());
int[][] jaggedArray = new int[rows][];

for (int row = 0; row < rows; row++)
{
    jaggedArray[row] = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();
}

string cmd;
while ((cmd = Console.ReadLine()) != "END")
{
    string[] cmdArgs = cmd
                .Split();
    string operation = cmdArgs[0];
    int row = int.Parse(cmdArgs[1]);
    int col = int.Parse(cmdArgs[2]);
    int value = int.Parse(cmdArgs[3]);
    if (row >= 0 && row < rows && col >= 0 && col < jaggedArray[row].Length)
    {
        if (operation == "Add")
        {
            jaggedArray[row][col] += value;
        }
        else if (operation == "Subtract")
        {
            jaggedArray[row][col] -= value;
        }
    }
    else
    {
        Console.WriteLine("Invalid coordinates");
    }
    
}

foreach (int[] row in jaggedArray)
{
    Console.WriteLine(string.Join(" ",row));
}