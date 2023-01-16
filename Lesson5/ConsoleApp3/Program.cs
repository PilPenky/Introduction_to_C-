/* Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да

Массивы к задачам 32 и 33 можно сделать рандомными. В задаче 33 на экран выводится ТОЛЬКО одно сообщение: либо "да", либо "нет". */

int[] GetRandomArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(leftRange, rightRange + 1);
    }
    return array;
}

string FindElement(int[] array, int target)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == target) return "да";
    }
    return "нет";
}

const int SIZE = 10;
const int LEFT = -9;
const int RIGHT = 9;

int[] massive = GetRandomArray(SIZE, LEFT, RIGHT);
Console.WriteLine(string.Join(", ", massive));

Console.Write("Введите искомое число: ");
int find = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(FindElement(array: massive, target: find));