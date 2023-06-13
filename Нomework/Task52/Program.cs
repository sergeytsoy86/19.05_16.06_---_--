// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

double[,] CreateMartrix(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)

{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine();
    }
}

double[] GetColumnsAverage(double[,] arr)
{
    int rows = arr.GetLength(0), columns = arr.GetLength(1);
    double[] averagesCol = new double[columns];
    for (int j = 0; j < columns; j++)
    {
        double sumCol = 0;
        for (int i = 0; i < rows; i++)
        {
            sumCol += arr[i, j];
        }
        averagesCol[j] = sumCol / rows;
    }
    return averagesCol;
}

void PrintAverages(double[] arr, int digits = 2)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Среднее значение солбца {i} = > {Math.Round(arr[i], digits)}");
    }
}
double[,] matrix = CreateMartrix(3, 4, 1, 9);
PrintMatrix(matrix);
double[] averagesCol = GetColumnsAverage(matrix);
GetColumnsAverage(matrix);
PrintAverages(averagesCol);