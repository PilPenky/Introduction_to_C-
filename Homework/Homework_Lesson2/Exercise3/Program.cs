// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();
/*
Console.WriteLine("Введите числовое значение дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number == 1) Console.WriteLine("Не является выходным днём");
if(number == 2) Console.WriteLine("Не является выходным днём");
if(number == 3) Console.WriteLine("Не является выходным днём");
if(number == 4) Console.WriteLine("Не является выходным днём");
if(number == 5) Console.WriteLine("Не является выходным днём");
if(number == 6) Console.WriteLine("Является выходным днём");
if(number == 7) Console.WriteLine("Является выходным днём");

if((number > 7) || (number<1)) Console.WriteLine("Ошибка: Введите число от 1 до 7");
*/

Console.WriteLine("Введите числовое значение дня недели: ");
    switch (Console.ReadLine())
    {
        case "1":
            Console.WriteLine("Не является выходным днём");
            break;
        case "2":
            Console.WriteLine("Не является выходным днём");
            break;
        case "3":
            Console.WriteLine("Не является выходным днём");
            break;
        case "4":
            Console.WriteLine("Не является выходным днём");
            break;
        case "5":
            Console.WriteLine("Не является выходным днём");
            break;
        case "6":
            Console.WriteLine("Является выходным днём");
            break;
        case "7":
            Console.WriteLine("Является выходным днём");
            break;
    }