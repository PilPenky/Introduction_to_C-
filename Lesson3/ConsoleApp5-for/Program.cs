/* Пример цикла for */

Console.WriteLine("Сколько раз вывести слово ''Привет''?");
int count = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Цикл завершил работу");
for (int x = 1; x <= count; x++)
{
    Console.WriteLine($"Привет! {x}");
}