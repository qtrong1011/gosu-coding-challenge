//Initialize set of A and B
char[] A = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
List<Tuple<char, int>> B = new List<Tuple<char, int>>()
        {
            new Tuple<char, int>('a', 1),
            new Tuple<char, int>('c', 1),
            new Tuple<char, int>('d', 1),
            new Tuple<char, int>('f', 1),
            new Tuple<char, int>('a', 2),
            new Tuple<char, int>('b', 2),
            new Tuple<char, int>('g', 2),
            new Tuple<char, int>('h', 2),
            new Tuple<char, int>('b', 3),
            new Tuple<char, int>('c', 3),
            new Tuple<char, int>('e', 3),
            new Tuple<char, int>('f', 3),
            new Tuple<char, int>('g', 3),
            new Tuple<char, int>('h', 3),
        };

// Determine number of rows and columns
int numCol = A.Length;
int numRow = B.MaxBy(u => u.Item2).Item2;

//Initialize an empty matrix
char[,] matrix = new char[numRow, numCol];
for (int i = 0; i < numRow; i++)
{
    for (int j = 0; j < numCol; j++)
    {
        matrix[i, j] = ' ';
    }
}

//Find indexes and putting '*' to the found indexes
foreach (var pair in B)
{
    int xIndex = pair.Item2 - 1;
    int yIndex = Array.IndexOf(A, pair.Item1);
    matrix[xIndex, yIndex] = '*';
}

// Print the header row
Console.Write("  ");
foreach (var element in A)
{
    Console.Write($"{element}  ");
}
Console.WriteLine();

// Print data
for (int i = 0; i < numRow; i++)
{
    Console.Write($"{i+1} ");
    for (int j = 0; j < numCol; j++)
    {
        // adding hyphen if the element is an empty char
        if (matrix[i,j] == ' ')
        {
            matrix[i, j] = '-';
        }
        Console.Write(matrix[i, j] + "  ");
    }
    Console.WriteLine();
}
Console.ReadKey();