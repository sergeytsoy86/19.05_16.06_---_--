// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


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

void PrintArrayDouble(double[] arr, string sep = ",")
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("] ");
}


double[] arrey = CreateArrayRndDouble(5, -10, 10);
PrintArrayDouble(arrey);

double min = 0;
double max = 0;

for (int i = 0; i < arrey.Length; i++)
{
    if (arrey[i] > max)
        {
            max = arrey[i];
        }
    if (arrey[i] < min)
        {
            min = arrey[i];
        }
}
Console.WriteLine($" => ({max}) - ({min}) = {max-min}");