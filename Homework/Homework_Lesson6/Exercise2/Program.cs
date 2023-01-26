/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

int Number1234(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

//----------------------------------------------------

double SearchX(double a, double b, double c, double d)
{
    double k1 = a;
    double k2 = b;
    double b1 = c;
    double b2 = d;

    double x = (b2 - b1) / (k1 - k2);
    return x;
}


double SearchY(double a, double b, double c, double d)
{
    double k1 = a;
    double k2 = b;
    double b1 = c;
    double b2 = d;

    double y = k1 * (b2 - b1) / (k1 - k2) + b1;
    return y;
}

//----------------------------------------------------

int k1 = Number1234("Введите значение для числа k1: ");
int k2 = Number1234("Введите значение для числа k2: ");
int b1 = Number1234("Введите значение для числа b1: ");
int b2 = Number1234("Введите значение для числа b2: ");

double x = SearchX(k1, k2, b1, b2);
double y = SearchY(k1, k2, b1, b2);

Console.WriteLine($"{x:f2}, {y:f2}");