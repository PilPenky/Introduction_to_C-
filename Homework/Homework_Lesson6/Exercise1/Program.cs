/* Задача: Пользователь вводит с клавиатуры размер массива и значение элементов в массиве. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4 */

Console.WriteLine("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] arr = new int [size];


// Метод вывода массива:
void PrintArray (int[] array)
{
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// Метод формирования массива:
void SelectionSort(int[] array)
{
    int num = 1;
    int h = 1;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {h} элемент массива: ");
        array[i] = int.Parse(Console.ReadLine());
        string str1 = array[i].ToString();
        if(str1 == "stop") break;

        num += 1;
        h += 1;
    }
    Console.WriteLine();
}

//Сколько чисел больше нуля:
void Count(int[] array)
{
    for (int i = 0; i < size; i++)
    {
        
        if(array[i] > 0)
        {
            int count1 = 0;
            count1 = count1 + 1;
            Console.Write(count1);
        }
        
    }
    Console.WriteLine();
}

//Сложение единиц:
int CountNew(int[] array)
{
    int count1 = 0;
    for (int i = 0; i < size; i++)
    {
        if(array[i] > 0)
        {
            count1 = count1 + 1;
        }
    }
    return count1;
}

SelectionSort(arr);
Console.Write("Вы задали массив чисел: ");
PrintArray(arr);
//Count(arr);
Console.WriteLine($"Количество чисел больше нуля: {CountNew(array: arr)}");