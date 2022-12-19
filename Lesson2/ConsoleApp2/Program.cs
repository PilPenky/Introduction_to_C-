/* Напишите программу, которая выводит случайное трехзначное 
число и удаляет вторую цифру этого числа.
*/

//int number = new Random().Next(100, 1000);
int number = 999;

int thirdDigit = number % 10; //3

int firstDigit = (number / 100); 

int result = firstDigit * 10 + thirdDigit;

Console.WriteLine(number);
Console.Write(result);