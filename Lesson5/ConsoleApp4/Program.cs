/* Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */

int[] array = {1,2,3,4,5};
int size = (array.Length + 1) / 2;

int[] newArray = new int[size];
for(int i = 0; i < array.Length / 2; i++)
{
    newArray[i] = array[i] * array[array.Length - 1 - i];
}

if(array.Length % 2 == 1)
{
    newArray[size - 1] = array[array.Length / 2];
}
Console.WriteLine(string.Join(", ", newArray));