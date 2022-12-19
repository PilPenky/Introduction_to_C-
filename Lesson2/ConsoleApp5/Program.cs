/* Напишите программу, которая принимает на вход два числа и проверяет, 
является ли одно число квадратом другого. */

Console.WriteLine("Введите первое целое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if((number1 == 1) & (number2 == 1))
{
    Console.WriteLine($"Число {number1} является квадратом {number2}");
}

else if((number1 == 0) & (number2 == 0))
{
    Console.WriteLine($"Число {number1} является квадратом {number2}");
}

else if(number1 == number2)
{
    Console.WriteLine($"Число {number1} не является квадратом {number2}");
}

else if(number1 > number2)
{
    if(number1 == number2*number2)
    {
        Console.WriteLine($"Число {number1} является квадратом {number2}");
    }
    else
        {
            Console.WriteLine($"Число {number1} не является квадратом {number2}");
        }
}

else if(number2 > number1)
{
    if(number2 == number1*number1)
    {
        Console.WriteLine($"Число {number2} является квадратом {number1}");
    }
    else
        {
            Console.WriteLine($"Число {number2} не является квадратом {number1}");
        }
}