﻿
Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1)
    Console.WriteLine("Некоректный ввод");
else
{
    int i = -number;
    while (i <= number)
    {
        Console.Write($"{i} ");
        ++i;
    }
}