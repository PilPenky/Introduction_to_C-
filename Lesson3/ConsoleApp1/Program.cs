/* Напишите программу, которая принимает на вход координаты точки (X и Y), 
причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка. */

Console.WriteLine("Введите X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x == 0 || y == 0)
{
    Console.WriteLine("Точки не могут равняться 0");
    return; // В данном случае, return будет завершать команду в этом месте
}

if (x > 0 && y > 0)
{
    Console.WriteLine("Точки находится в первой четверти");
}

if (x < 0 && y > 0)
{
    Console.WriteLine("Точки находится в второй четверти");
}

if (x < 0 && y < 0)
{
    Console.WriteLine("Точки находится в третьей четверти");
}

if (x > 0 && y < 0)
{
    Console.WriteLine("Точки находится в четвертой четверти");
}