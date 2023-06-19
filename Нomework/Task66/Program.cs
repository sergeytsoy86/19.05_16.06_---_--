
// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Введите начальное число M:");
double numberM = Convert.ToDouble(Console.ReadLine());

if (numberM % 2 != 0)  
    {
        Console.WriteLine("Вы ввели не натуральное число");
        return;
    }
     if (numberM <=0)
     {
        Console.WriteLine("Вы ввели не натуральное число");
        return;       
     }

Console.WriteLine("Введите начальное число N:");
double numberN = Convert.ToDouble(Console.ReadLine());

if (numberN % 2 != 0)  
    {
        Console.WriteLine("Вы ввели не натуральное число");
        return;
    }
     if (numberN <=0)
     {
        Console.WriteLine("Вы ввели не натуральное число");
        return;       
     }


void GapNumberSum1 (double numberM, double numberN, double sum)
{
    if (numberM > numberN) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (numberM++);
    GapNumberSum1(numberM, numberN, sum);
    
}
GapNumberSum1 (numberM, numberN, 0);

void GapNumberSum2 (double numberM, double numberN, double sum)
{
    if (numberM < numberN) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от N до M: {sum}"); 
        return;
    }
    sum = sum + (numberN++);
    GapNumberSum2(numberM, numberN, sum);
    
}
GapNumberSum2 (numberM, numberN, 0);
