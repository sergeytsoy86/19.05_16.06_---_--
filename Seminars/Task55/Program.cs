﻿
// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

// void SwapRowsColumns1(int[,] arr)
// {
//     for (int i = arr.GetLength(0) - 1; i > 0; i--)
//     {
//         for (int j = 0; j < i; j++)
//         {
//             int temp = arr[i, j];
//             arr[i, j] = arr[j, i];
//             arr[j, i] = temp;
//         }
//     }


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max) // rows = 3, columns = 4
{
    //                        0      1      
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
             matrix[i, j] = rnd.Next(min, max + 1);
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
             Console.Write($"{matrix[i, j], 6}");
        }
        Console.WriteLine();
    }
}

void ReaplaceRowsColumns(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
}

int[,] array2d = CreateMatrixRndInt(3, 3, 1, 50);
PrintMatrix(array2d);
Console.WriteLine();
ReaplaceRowsColumns(array2d);
PrintMatrix(array2d);