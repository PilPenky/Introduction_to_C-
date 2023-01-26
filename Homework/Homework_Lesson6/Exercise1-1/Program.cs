/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
Ввод чисел останавливается при помощи ввода стоп-слова "stop" и производится при помощи нажатия Enter */

int NumberRR()
{
    int count = 1;
    int countCount = count;
    while(true)
    {
        string str = Console.ReadLine();
        if(str == "stop")
        {
            Console.WriteLine("----");
            break;
        }
        else
        {
            int result = Int32.Parse(str);
            if(result > 0)
            {
                count += 1;
            }       
        }
    }
    return count;
}

Console.WriteLine("Введите целые числа: ");
Console.WriteLine("Для остановки ввода чисел напишите 'stop'");

int a = NumberRR();
Console.WriteLine($"Количество чисел больше нуля: {a-1}");