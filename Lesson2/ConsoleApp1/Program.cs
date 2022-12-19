// Напишите программу, которая выводит случайное число 
//из отрезка [10, 99] и показывает наибольшую цифру числа.

int number = new Random().Next(10, 99);

//Первая цифра числа
int firstDigit = number / 10;

//Вторая цифра числа
int secondDigit = number % 10;

Console.WriteLine($"Случайное число: {number}");

if (firstDigit > secondDigit)
{
    Console.WriteLine($"Наибольшая цифра числа: {firstDigit}");
}

if (secondDigit > firstDigit)
{
    Console.WriteLine($"Наибольшая цифра числа: {secondDigit}");
}

if (secondDigit == firstDigit)
{
    Console.WriteLine("Цифры в числе равны");
}