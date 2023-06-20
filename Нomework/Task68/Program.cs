// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.Write(" Введите начальное число n: ");
int namN = Convert.ToInt32(Console.ReadLine());

Console.Write(" Введите начальное число m: ");
int namM = Convert.ToInt32(Console.ReadLine());

int Akkerman(int namM, int namN)
{
    if (namM == 0)
    {
        return (namN + 1);
    }
    if ( namM != 0 && namN == 0)
    {
        return Akkerman(namM - 1, 1);
    }    
    if (namM > 0 && namN > 0)
    {
    return (Akkerman(namM - 1, Akkerman(namM, namN - 1)));
    }
    return (Akkerman(namM, namN));
}

Console.WriteLine($"Функция Аккермана для чисел А({namN},{namM}) = {Akkerman(namN, namM)}"); 