// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("введите натуральное число");
double number = Convert.ToDouble(Console.ReadLine());

    if (number % 2 != 0)  
    {
        Console.WriteLine("Вы ввели не натуральное число");
        return;
    }
     if (number <=0)
     {
        Console.WriteLine("Вы ввели не натуральное число");
        return;       
     }


NaturalNumbers(number);

void NaturalNumbers(double num)
{
    if(num == 0) return;
    Console.Write($"{num}, ");
    NaturalNumbers (num -1);
    
}
 