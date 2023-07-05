// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.

Console.WriteLine("Введите число строк матрицы: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов матрицы: ");
int columns = Convert.ToInt32(Console.ReadLine());

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

int[,] SwapMatrix(int[,] matrix)
{
    int rowCount = matrix.GetLength(0);
    int columnCount = matrix.GetLength(1);
    int[,] matrixNew = new int[columnCount, rowCount];
    for (int j = 0; j < columnCount; j++)
    {
        for (int i = 0; i < rowCount; i++)
        {
            matrixNew[j, i] = matrix[i, j];
        }
    }
    return matrixNew;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

int[,] myMatrix = GetRandomArray(rows, columns);
PrintMatrix(myMatrix);
Console.WriteLine();
int [,] matrixNew = SwapMatrix(myMatrix);
PrintMatrix(matrixNew);