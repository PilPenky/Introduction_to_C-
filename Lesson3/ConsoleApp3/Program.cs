// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

Console.Clear();
Console.WriteLine("Введите значение для x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение для x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение для y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение для y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(x2-x1, 2)+Math.Pow(y2-y1, 2));

Console.WriteLine($"Расстояние между точками: {Math.Round(result, 2)}");