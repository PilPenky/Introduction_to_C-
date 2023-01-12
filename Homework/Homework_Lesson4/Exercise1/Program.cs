/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. */

int ReadNumberOne(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int ReadNumberTwo(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int GetDegree1ToA(int a, int b)
{
    int sum = a;
    for (int i = 1; i < b; i++)
    {
        sum = sum * a;
    }
    return sum;
}

int number1 = ReadNumberOne("Введите число:");
if (number1 <= 0)
{
    Console.WriteLine("Введено неверное число");
}
else
{
    int number2 = ReadNumberTwo("Введите степень числа:");
    if (number2 <= 0)
    {
        Console.WriteLine("Введено неверное число");
    } 
    else
    {
        int summa = GetDegree1ToA(number1, number2);
        Console.WriteLine(summa);
    }
}