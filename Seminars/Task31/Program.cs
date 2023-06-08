// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3, 9, -8, 1, 0, -7, 2, -1, 8, -3, -1, 6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.


int[] GetSumPositiveNegativElem(int[] arr)
{
    int sumPositive = 0;
    int sumNegative = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) sumPositive += arr[i];
        else sumNegative += arr[i];
    }

    return new int[] {sumPositive, sumNegative};
}

int GetSumPositiveElem(int[] arr)
{
    int sum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) sum += arr[i];
    }

    return sum;
}

int GetSumNegativeElem(int[] arr)
{
    int sum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < 0) sum += arr[i];
    }
    
    return sum;
}
// int[] sumPositiveNegativElem = GetSumPositiveNegativElem(array);
// Console.WriteLine($"Сумма положительных элементов = {sumPositiveNegativElem[0]}");
// Console.WriteLine($"Сумма отрицательных элементов = {sumPositiveNegativElem[1]}");

// int sumPositiveElem = GetSumPositiveElem(array);
// int sumNegativeElem = GetSumNegativeElem(array);
// Console.WriteLine($"Сумма положительных элементов = {sumPositiveElem}");
// Console.WriteLine($"Сумма отрицательных элементов = {sumNegativeElem}");

int[] CreateArrayRndint(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max +1);
    }
    return arr;
}

//нахождение среднего числа 
double[] CreateArrayRndDouble(int size, int min, int max, int round = 2)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, round);
    }
       
    return arr;
}

void PrintArray(double[] arr, string sep = ",")
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write ($"{arr[i]}{sep} ");
        else Console.Write ($"{arr[i]}");
    }
}

// int[] array = CreateArrayRndint(12, -9, 9);
// Console.Write("[");
// PrintArray(array);
// Console.WriteLine("]");