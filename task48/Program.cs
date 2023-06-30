// Задайте двумерный массив размера m на n,
//  каждый элемент в массиве находится по формуле:
//  Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

const int rows = 3;
const int columns = 4;

int[,] GetRandomMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    // matrix [0,0] // Здесь укзаывается номер строки и номер столбца (0-это 1 строка 0)
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i+j;
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
    }
}
int[,] myMatrix = GetRandomMatrix(rows, columns);
// Console.WriteLine(string.Join(", ", myMatrix));
PrintMatrix(myMatrix);