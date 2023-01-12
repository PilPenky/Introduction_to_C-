/*  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Данные вводятся с консоли пользователем */

int[] arr = {0, 0, 0, 0, 0, 0, 0, 0};

// Метод вывода массива:
void PrintArray (int[] array)
{
    for (int i = 0; i < 8; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// Метод формирования массива:
void SelectionSort(int[] array)
{
    int num = 1;
    string h = String.Empty;

    for (int i = 0; i < 8; i++)
    {
        if (num == 1) h = "первый";
        if (num == 2) h = "второй";
        if (num == 3) h = "третий";
        if (num == 4) h = "четвертый";
        if (num == 5) h = "пятый";
        if (num == 6) h = "шестой";
        if (num == 7) h = "седьмой";
        if (num == 8) h = "восьмой";

        Console.Write($"Введите {h} элемент массива: ");
        array[i] = int.Parse(Console.ReadLine());
        num += 1;
    }
    Console.WriteLine();
}

SelectionSort(arr);
PrintArray(arr);