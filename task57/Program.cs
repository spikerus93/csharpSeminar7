// Задача 57: Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// Элементы [0, 9]

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

int [] GetFrequencyOfElementsInMatrix(int[,] MyTwoDimensionalArray)
{
    int [] FrequencyArray =  new int[10]; //[0,1,2,3,4,5,6,7,8,9]
    int rowCount=MyTwoDimensionalArray.GetLength(0);
    int columnCount = MyTwoDimensionalArray.GetLength(1);
    for(int i=0;i<rowCount;i++)
    {
        for(int j=0; j< columnCount;j++)
        {
            FrequencyArray[MyTwoDimensionalArray[i,j]]++;
        }
    }
    return FrequencyArray;
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

int [,] GMatrix = GetRandomArray(rows,columns);
PrintMatrix(GMatrix);
int [] GFrequence = GetFrequencyOfElementsInMatrix(GMatrix);
for(int i =0; i<GFrequence.Length;++i)
{
    Console.Write($"{i} : Данное Число повторяется {GFrequence[i]} раз |");
}
Console.WriteLine();
// Console.WriteLine(string.Join("| ", GFrequence));