// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int PowerRec(int num, int pow)
{
    if (pow == 0) return 1;
    return num * PowerRec(num, pow - 1);
}

Console.WriteLine("Введите два натуральных числа: ");
int baseNumber = Convert.ToInt32(Console.ReadLine());
int power = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PowerRec(baseNumber, power));

// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int EnterNumber(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Exponentiation(int number, int exp)
{
     if (exp == 0) return 1;
     return number * Exponentiation(number, exp - 1);
}

int Exponentiation1(int number, int exp)
{
     return exp == 0 ? 1 : number * Exponentiation(number, exp - 1);
}
int number = EnterNumber("Введите целое число");
int exp = EnterNumber("Введите степень числа");
Console.WriteLine($"{exp}я степень числа {number} = {Exponentiation1(number, exp)}");

// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int EnterNumber(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumDigits(int num)
{
     if (num == 0) return 0;
     return num % 10 + SumDigits(num / 10) ;
 }


int number = EnterNumber("Enter number");
Console.WriteLine("Сумма цифр числа:");
Console.WriteLine(SumDigits(number));