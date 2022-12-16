/*Напишите программу, которая на вход принимает целое число (N), 
а на выходе показывает все чётные числа от 1 до N.*/

Console.WriteLine("Введите целое число от 1 до ...N: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("---");

int startNumber = 1;

while(startNumber != number+1)
    {
        if(startNumber%2 == 0)
            {
                Console.WriteLine(startNumber);
                startNumber++;
            }
        else
            {
                startNumber++;
            }
    }