/* Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке. */

int[] FillRandomArray(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0,2);
    }
    return arr;
}

// 1 вариант. Вывод на экран массив через метод:
/*
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

int[] array = FillRandomArray(8);
PrintArray(array);
*/

// 2 вариант. Вывод на экран массив команду:
int[] array = FillRandomArray(8);
Console.WriteLine(string.Join(" ", array));