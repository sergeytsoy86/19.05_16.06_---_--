// Задача 50. Напишите программу, 
// которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1,7 -> такого элемента в массиве нет

int rows = ReadInt("Введите индекс строки: ");
int colums = ReadInt("Введите индекс столбца: ");
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

double[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1) / 10.0;
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
            Console.Write($"{matrix[i, j],6} ");
        }
        Console.WriteLine();
    }
}

double[,] array2d = CreateMatrixRndInt(5, 5, -100, 100);
PrintMatrix(array2d);

if (rows < array2d.GetLength(1) && colums < array2d.GetLength(0)) 
    Console.WriteLine($"Число в массиве равно: {array2d[rows, colums]}");
else 
    Console.WriteLine($"{rows},{colums} -> такого числа в массиве нет");



