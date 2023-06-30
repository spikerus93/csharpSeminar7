// Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:          
// вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть 
// 1 4 7 2
// 5 81 2 9
// 8 16 2 4

const int Rows = 4;
const int Columns = 4;

int[,] GetRandomMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    // matrix [0,0] // Здесь укзаывается номер строки и номер столбца (0-это 1 строка 0)
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(1, 10);
        }
    }
    return matrix;
}

int ChangeMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 != 0 && j % 2 != 0)
            {
                matrix[i, j] = matrix[i, j] * matrix[i, j];
            }
        }
    }
    return matrix.GetLength(0);
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t ");
        }
        Console.WriteLine();
    }
}
int[,] myMatrix = GetRandomMatrix(Rows, Columns);
int myMatrix1 = ChangeMatrix(myMatrix);
// Console.WriteLine(string.Join(", ", myMatrix));
PrintMatrix(myMatrix);