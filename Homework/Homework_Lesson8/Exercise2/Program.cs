/* Задача 56: Задайте двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

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

//Метод считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов:
void AverageColumn(int[,] matrix)
{
    int res = 0;
    int minIndex = 0;
    int minLine = 0; 
    int result = 0;

    for(int i = 0; i < matrix.GetLength(0); i++)
    {          
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            result += matrix[i, j];         
        } 

        Console.WriteLine();
        Console.Write($"Строка с индексом {i} имеет значение {result}");

        if(res == 0)
        {
            res = result;
            minLine = result;
            minIndex = i;
        }

        if(result < res)
        {
            res = result;
            minLine = result;
            minIndex = i;
        }
        result = 0;
    }
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine($"Строка с индексом {minIndex} имеет значение ({minLine}) с наименьшей суммой элементов");
}

const int ROWS = 4;
const int COLUMNS = 6;
const int LEFTRANGE = 0;
const int RIGHTRANGE = 9;

int[,] array = GetRandomMatrix(ROWS, COLUMNS, LEFTRANGE, RIGHTRANGE);
PrintMatrix(array);
AverageColumn(array);