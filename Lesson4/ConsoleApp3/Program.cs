/* Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N. */

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int GetSum1ToA(int a)
{
    int sum = 1;
    for (int i = 1; i <= a; i++)
    {
        sum *= i; //sum = sum + i
    }
    return sum;
}

int number = ReadNumber("Введите число: ");
if (number > 0)
{
    int summa = GetSum1ToA(number);
    Console.WriteLine(summa);
}
else
{
    Console.WriteLine("Введено неверное число");
}