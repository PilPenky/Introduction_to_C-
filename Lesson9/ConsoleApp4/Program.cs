/* Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9 */

int Number1234(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumN (int n) 
{
    int temp = 0;
    if (n == 0) return temp;
    else 
    {
        temp = n % 10 + SumN(n / 10);
    }
    return temp;
}

int number = Number1234("Введите число: ");
Console.WriteLine(SumN(number));