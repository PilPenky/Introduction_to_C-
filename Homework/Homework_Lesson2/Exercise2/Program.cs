// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();

Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > -1)
{
    if(number < 100)
    {
        Console.WriteLine($"Нет третьей цифры в числе {number}");
    }
    else
    {
        while(number > 999)
        {
            number = number / 10;
        }
        Console.WriteLine($"Третья цифра введенного числа: {number % 10}");
    }
}
else
{   
    Console.WriteLine("Вы ввели отрицательное число.");

    if(number > -100)
    {
        Console.WriteLine($"Нет третьей цифры нет в отрицательном числе {number}");
    }
    else
    {
        while(number < -999)
        {
            number = number / 10;
        }
        int x = number % 10;
        Console.WriteLine($"Третья цифра отрицательного числа: {x * -1}");
    }
}