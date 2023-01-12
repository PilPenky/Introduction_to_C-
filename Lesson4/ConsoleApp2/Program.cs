/* Напишите программу, которая принимает на вход число и 
выдаёт количество цифр в числе. */

int ReadNumber (string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int CountNumber (int a)
{
    int count = 0;
    while (Math.Abs(a) != 0)
    {
       a = a/10;
       count++;
    } 
    return count;
}

int number = ReadNumber("Введите число: ");

int count1 = CountNumber(number);
Console.WriteLine (count1);