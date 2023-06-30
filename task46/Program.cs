// Задайте двумерный массив размером m×n, 
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

//  Запятая указавает какой массив - это Двумерный массив

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
            matrix[i, j] = Random.Shared.Next(1, 10);
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
            Console.Write($"{matrix[i, j]}\t ");
        }
    }
}
int[,] myMatrix = GetRandomMatrix(rows, columns);
Console.WriteLine(string.Join(", ", myMatrix));
PrintMatrix(myMatrix);