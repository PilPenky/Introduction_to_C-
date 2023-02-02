/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение одинаковых индексов двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
6 16
9 6                         */

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

//Метод находит произведение одинаковых индексов двух матриц:
int[,] ArrayMultiplication(int[,] array, int[,] arrayTwo)
{
    int[,] resultArray = new int[array.GetLength(0), array.GetLength(1)];

    for(int i = 0; i < resultArray.GetLength(0); i++)
    {
        for(int j = 0; j < resultArray.GetLength(1); j++)
        {
            resultArray[i, j] = array[i, j] * arrayTwo[i, j];
        }
    }
    return resultArray;
}

const int ROWS = 2;
const int COLUMNS = 2;
const int LEFTRANGE = 1;
const int RIGHTRANGE = 5;

int[,] array = GetRandomMatrix(ROWS, COLUMNS, LEFTRANGE, RIGHTRANGE);
PrintMatrix(array);
//ArrayMultiplication(array);
int[,] arrayTwo = GetRandomMatrix(ROWS, COLUMNS, LEFTRANGE, RIGHTRANGE);
Console.WriteLine();
PrintMatrix(arrayTwo);
Console.WriteLine();
Console.WriteLine("Результирующая матрица:");
int[,] matrix2 = ArrayMultiplication(array, arrayTwo);
PrintMatrix(matrix2);