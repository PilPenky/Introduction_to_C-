// Перевод числа из 10 системы счисления в двоичную:

int number = 13; //Число, которое нужно сконвертировать в двоичное представление

PrintBinaryView(number);

void PrintBinaryView(int n)
{
    if(n <= 0) return;
    PrintBinaryView(n / 2);
    Console.Write(n % 2);
}
