// Дополнительная задача:
// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

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
            matrix[i, j] = Random.Shared.Next(0, 9);
        }
    }
    return matrix;
}

int[] GetPositionMin(int[,] matrix)
{
    int iPositionMin = 0;
    int jPosition = 0;
    int min = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                iPositionMin = i;
                jPosition = j;
            }
        }
    }
    int[] arrayPair = new int[] { iPositionMin, jPosition };
    return arrayPair;
}

int[,] RemoveRespectiveRowAndColumn(int[,] matrix, int[] ArrayToRemove)
{
    int[,] matrixReduced = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int iShift = 0;
    int jShift = 0;
    for (int i = 0; i < matrixReduced.GetLength(0); i++)
    {
        if (i == ArrayToRemove[0])
        {
            iShift++;
        }
        for (int j = 0; j < matrixReduced.GetLength(1); j++)
        {
            if (j == ArrayToRemove[1])

                jShift++;

            matrixReduced[i, j] = matrix[i + iShift, j + jShift];
        }
        jShift = 0;
    }
    return matrixReduced;
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
int[] array = GetPositionMin(myMatrix);
PrintMatrix(myMatrix);
Console.WriteLine();
int[,] matrixReduced = RemoveRespectiveRowAndColumn(myMatrix, array);
PrintMatrix(matrixReduced);