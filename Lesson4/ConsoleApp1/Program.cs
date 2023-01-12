/* Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А. */

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int GetSum1ToA(int a)
{
    int sum = 0;
    for (int i = 1; i <= a; i++)
    {
        sum += i; //sum = sum + i
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
// Это пишем, если не проводим проверку на отрицательное число:
//int summa = GetSum1ToA(number);
//Console.WriteLine(summa);