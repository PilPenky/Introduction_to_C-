/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

int n = 5;

void RecN (int number) 
{
    if (number == 0) return;
    else RecN(number - 1); int result = (n - number) + 1; Console.Write($"{result} ");
}

RecN(n);