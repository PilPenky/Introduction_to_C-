/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу 
квадратов чисел от 1 до N. */

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Квадрат числа {i} = {i*i}");
}
