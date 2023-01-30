/* Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали
(с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
​
Доп. условие для 51 задачи: сделать суммирование в один цикл. Матрица может быть прямоугольной. */

//                        строки     столбцы
int[,] GetRandomMatrix(int rows, int columns, int leftRange, int rightRange)
{
    int[,] matrix = new int[rows,columns];

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(leftRange, rightRange + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

//Сложение диагональных индексов:
int DiagonalMatrix(int[,] matrix)
{
    int result = 0;
    for(int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++)
    {
        Console.Write($"{matrix[i, i]} ");
        result += matrix[i, i];
    }
    return result;
}

const int ROWS = 5;
const int COLUMNS = 7;
const int LEFTRANGE = 0;
const int RIGHTRANGE = 9;

int[,] array = GetRandomMatrix(ROWS, COLUMNS, LEFTRANGE, RIGHTRANGE);
PrintMatrix(array);
Console.WriteLine();
Console.Write($"Главная диагональ массива: ");
int sum = DiagonalMatrix(array);
Console.WriteLine();
Console.Write($"Сумма элементов главной диагонали массива: {sum}");