﻿// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// Console.WriteLine("Введите целое положительное число: ");
// int number = Convert.IoInt32(Console.ReadLine());

// int SumNumber = SumNumber(number);
// Console.WriteLine($"Сумма чисел до 1 до {number} = {sumNubers}");

// //1+2+3+4+5+6+7
// int SumNumber(int num) // num = number
// {
//     int sum = 0;
//     for (int i = 1; i <= num; i++)
//     {
//         sum = sum + i; // sum +=1
//     }
//     return sum;

// }

Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 0)
{
    Console.WriteLine("Введено некорректное число!");
    return;
}

int sumNumbers = SumNumbers(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {sumNumbers}");

// 1 + 2 + 3 + 4 + 5 + 6 + 7
int SumNumbers(int num) // num = number
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum = sum + i; // sum += i
    }
    return sum;
}