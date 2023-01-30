/* Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8 */

int Number1234(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumN (int a, int b) 
{
    int degree = 0;
    if (b == 0) return 1;
    else 
    {
        degree = a * SumN(a, b-1);
    }
    return degree;
}

int number1 = Number1234("Введите число A (число): ");
int number2 = Number1234("Введите число B (степень числа): ");

int result = SumN(number1, number2);
Console.WriteLine(result);