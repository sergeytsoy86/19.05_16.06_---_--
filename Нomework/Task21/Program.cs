// Задача 21
// Напишите программу, 
// которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координату х первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату х второй точки: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату х второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату х второй точки: ");
int z2 = Convert.ToInt32(Console.ReadLine());

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Растояние между точками: {length}");



