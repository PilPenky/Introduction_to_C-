/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

Console.Clear();
// Необходимо учесть отрицательное введение число.
Console.WriteLine("Введите число от 1 до N: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine($"Таблица кубов чисел от 1 до {number}:");
Console.WriteLine("------------------------------");

/*
// 1. Через цикл for:
for (int x = 1; x <=number; x++)
    {
        if(number < 1)
            {
                Console.WriteLine("Ошибка.Введите число от 1 до N");
                return;
            }
        int result = x*x*x;
        Console.WriteLine($"{x}*{x}*{x} = {result}");
   }
*/

/*
// 2. Через цикл  while:
int x = 1;
while (x <= number)
{
    if(number < 1)
        {
           Console.WriteLine("Ошибка.Введите число от 1 до N");
           return;
        }
    int result = x*x*x;
    Console.WriteLine($"{x}*{x}*{x} = {result}");
    x++;
}
*/

/*
// 3. Через цикл for через Math:
for (int x = 1; x <=number; x++)
    {
        if(number < 1)
            {
                Console.WriteLine("Ошибка.Введите число от 1 до N");
                return;
            }
        Console.Write($"{x}*{x}*{x} = ");
        Console.WriteLine(Math.Pow(x, 3));
   }
*/

/*
// 4. Через цикл  while через Math:
int x = 1;
while (x <= number)
{
    if(number < 1)
        {
            Console.WriteLine("Ошибка.Введите число от 1 до N");
            return;
        }
    Console.Write($"{x}*{x}*{x} = ");
    Console.WriteLine(Math.Pow(x, 3));
    x++;
}
*/
