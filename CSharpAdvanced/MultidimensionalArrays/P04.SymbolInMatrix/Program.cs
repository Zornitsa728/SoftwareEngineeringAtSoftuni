int size = int.Parse(Console.ReadLine());
char[,] matrix = new char[size,size];

for (int row = 0; row < size; row++)
{
    string symbols = Console.ReadLine();

    for (int col = 0; col < size; col++)
    {
        matrix[row, col] = symbols[col];
    }
}

char specialSymbol = char.Parse(Console.ReadLine());
bool isSymbolValid = false;

for (int currRow = 0; currRow < size; currRow++)
{
    for (int currCol = 0; currCol < size; currCol++)
    {
        if (specialSymbol == matrix[currRow,currCol])
        {
            Console.WriteLine($"({currRow}, {currCol})");
            isSymbolValid = true;
            break;
        }
    }

    if (isSymbolValid)
    {
        break;
    }
}

if (!isSymbolValid)
{
    Console.WriteLine($"{specialSymbol} does not occur in the matrix");
}