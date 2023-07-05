// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.

const int rows = 3;
const int columns = 4;

int[,] GetRandomArray(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(1, 10);

        }
    }
    return matrix;
}

void SwapFirstAndLastRows(int[,] matrix)
{
    int rowsCount = matrix.GetLength(0);
    int columnCount = matrix.GetLength(1);
    for (int j = 0; j < columnCount; j++)
    {
        int temp = matrix[0, j];
        matrix[0, j] = matrix[rowsCount - 1, j];
        matrix[rowsCount - 1, j] = temp;
    }
}

void PrintMatrix(int[,] matrix)
{
    for(int i=0;i<matrix.GetLength(0); i++)
    {
        for(int j=0;j<matrix.GetLength(1);j++)
        {
            Console.Write($"{matrix[i,j]} \t");
        }
        Console.WriteLine();
    }
}

int [,] myMatrix = GetRandomArray(rows,columns);
PrintMatrix(myMatrix);
SwapFirstAndLastRows(myMatrix);
Console.WriteLine();
PrintMatrix(myMatrix);