// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();

Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > -1)
{
    if((number > 999) || (number < 100))
    {
        Console.WriteLine("Необходимо ввести трёхзначное число");
    }
    else
    {
        while(number > 99)
        {
            number = number / 10;
        }
        Console.WriteLine($"Вторая цифра числа: {number % 10}");
    }
}
else
{   
    Console.WriteLine("Вы ввели отрицательное число.");

    if((number < -999) || (number > -100))
    {
        Console.WriteLine("Необходимо ввести трёхзначное отрицательное число");
    }
    else
    {
        while(number < -99)
        {
            number = number / 10;
        }
        int x = number % 10;
        Console.WriteLine($"Вторая цифра числа: {x * -1}");
    }
}