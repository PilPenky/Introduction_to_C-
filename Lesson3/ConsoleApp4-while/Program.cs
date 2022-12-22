/* Пример цикла while */


Console.WriteLine("Сколько раз вывести слово ''Привет''? ");
int count = Convert.ToInt32(Console.ReadLine());

int x = 1;

while (x <= count)
{
    if (x == 15) //Пример завершения приложение при определенном значении
    {
        break;
    }
    Console.WriteLine($"Привет! {x}");
    x++;
}